#!/usr/bin/env python
# -*- coding: utf-8 -*-


import os
import sys
from typing import Type

import rsa
import time
import shelve
import json
import socket
import threading
from PyQt5 import QtCore, QtGui, QtWidgets
from rsa import PublicKey

from des import *


# Мониторинг входящих сообщений
class message_monitor(QtCore.QThread):
    mysignal = QtCore.pyqtSignal(str)

    def __init__(self, server_socket, private_key, parent=None):
        QtCore.QThread.__init__(self, parent)
        self.server_socket = server_socket
        self.private_key = private_key
        self.message = None

    def run(self):
        while True:
            try:  # Данные от собеседника (зашифрованные)
                self.message = self.server_socket.recv(1024)
                if not self.message is bytes:
                    decrypt_message = rsa.decrypt(self.message, self.private_key)
                    self.mysignal.emit(decrypt_message.decode('utf-8'))
                else:
                    self.mysignal.emit(self.message)
            except Exception as e:  # Данные от сервера (не зашифрованные)
                self.mysignal.emit(self.message.decode('utf-8'))

                break


class Client(QtWidgets.QMainWindow):
    friend_public_key: Type[PublicKey]

    def __init__(self, parent=None):
        QtWidgets.QWidget.__init__(self, parent)
        self.ui = Ui_MainWindow()
        self.ui.setupUi(self)

        self.ip = None
        self.port = None
        self.friend_public_key = None

        # Ключи шифрования текущего клиента
        self.mypublickey = None
        self.myprivatekey = None

        # Проверка на наличие идентификатора собеседника
        if not os.path.exists('friend_id/public.json'):
            self.ui.lineEdit.setEnabled(False)
            self.ui.pushButton.setEnabled(False)
            self.ui.pushButton_2.setEnabled(False)
            self.ui.pushButton_4.setEnabled(False)
            message = 'Поместите идентификатор собеседника в "friend_id"'
            self.ui.plainTextEdit.appendPlainText(message)

        # Проверка создан ли личный идентификатор
        if not os.path.exists('private.json'):
            self.ui.lineEdit.setEnabled(False)
            self.ui.pushButton.setEnabled(False)
            self.ui.pushButton_2.setEnabled(False)
            self.ui.pushButton_4.setEnabled(False)
            message = 'Также необходимо сгенерировать свой идентификатор'
            self.ui.plainTextEdit.appendPlainText(message)

        else:
            # Подгрузка данных текущего клиента
            with open("private.json", "r") as file:
                data = json.load(file)  # десериализация JSON
                pubkey = rsa.PublicKey
                pubkey.e = data['pubkey']['e']
                pubkey.n = data['pubkey']['n']
                privkey = rsa.PrivateKey
                privkey.coef = data['privkey']['coef']
                privkey.d = data['privkey']['d']
                privkey.e = data['privkey']['e']
                privkey.exp1 = data['privkey']['exp1']
                privkey.exp2 = data['privkey']['exp2']
                privkey.n = data['privkey']['n']
                privkey.p = data['privkey']['p']
                privkey.q = data['privkey']['q']
                self.mypublickey = pubkey
                self.myprivatekey = privkey
                self.ip = data['ip']
                self.port = data['port']

            # Подгрузка данных собеседника
            if os.path.exists('friend_id/public.json'):
                with open('public.json', "r") as file:
                    data = json.load(file)  # десериализация JSON
                    pubkey = rsa.PublicKey
                    pubkey.e = data['pubkey']['e']
                    pubkey.n = data['pubkey']['n']
                    self.friend_public_key = pubkey

            message = 'Подключитесь к серверу'
            self.ui.plainTextEdit.appendPlainText(message)
            self.ui.lineEdit.setEnabled(False)
            self.ui.pushButton.setEnabled(False)
            self.ui.pushButton_4.setEnabled(False)
            self.ui.pushButton_2.setEnabled(True)

        # Обработчики кнопок
        self.ui.pushButton_2.clicked.connect(self.connect_server)
        self.ui.pushButton.clicked.connect(self.send_message)
        self.ui.pushButton_5.clicked.connect(self.generate_encrypt)
        self.ui.pushButton_4.clicked.connect(self.clear_panel)

    # Сохранить ник
    def connect_server(self):
        # Подключаемся к серверу
        try:
            self.tcp_client = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
            self.tcp_client.connect((self.ip, self.port));
            time.sleep(2)

            # Запускаем мониторинг входящих сообщений
            self.message_monitor = message_monitor(self.tcp_client, self.myprivatekey)
            self.message_monitor.mysignal.connect(self.update_chat)
            self.message_monitor.start()

            # Производим действия с объектами
            self.ui.lineEdit_4.setEnabled(False)
            self.ui.lineEdit_5.setEnabled(False)
            self.ui.pushButton_2.setEnabled(False)
            self.ui.pushButton.setEnabled(True)
            self.ui.lineEdit.setEnabled(True)
            self.ui.pushButton_4.setEnabled(True)
            self.ui.pushButton_5.setEnabled(False)
        except:
            self.ui.plainTextEdit.clear()
            self.ui.plainTextEdit.appendPlainText('Ошибка подключения к серверу!')
            self.ui.plainTextEdit.appendPlainText('Измените идентификаторы и повторите попытку!')

    # Отправить сообщение
    def send_message(self):
        try:
            if len(self.ui.lineEdit.text()) > 0:
                message = str(self.ui.lineEdit.text())
                crypto_message = rsa.encrypt(message.encode('utf-8'), self.friend_public_key)

                self.ui.plainTextEdit.appendPlainText(f'[Вы]: {message}')
                self.tcp_client.send(crypto_message)
                self.ui.lineEdit.clear()
        except:
            sys.exit()

    # Сгенерировать ключи шифрования
    def generate_encrypt(self):
        if len(self.ui.lineEdit_4.text()) > 0:
            if len(self.ui.lineEdit_5.text()) > 0:
                (pubkey, privkey) = rsa.newkeys(512)
                with open('public.json', "w") as File:
                    key = {
                        'e': int(pubkey.e),
                        'n': int(pubkey.n)
                    }
                    data = {
                        'pubkey': key,
                        'ip': str(self.ui.lineEdit_4.text()),
                        'port': int(self.ui.lineEdit_5.text())
                    }
                    json.dump(data, File, indent=4)  # Cериализация JSON
                with open('private.json', "w") as File:
                    pubkey = {
                        'e': int(pubkey.e),
                        'n': int(pubkey.n)
                    }
                    privkey = {
                        'coef': int(privkey.coef),
                        'd': int(privkey.d),
                        'e': int(privkey.e),
                        'exp1': int(privkey.exp1),
                        'exp2': int(privkey.exp2),
                        'n': int(privkey.n),
                        'p': int(privkey.p),
                        'q': int(privkey.q)
                    }
                    data = {
                        'pubkey': pubkey,
                        'privkey': privkey,
                        'ip': str(self.ui.lineEdit_4.text()),
                        'port': int(self.ui.lineEdit_5.text())
                    }
                    json.dump(data, File, indent=4)  # Cериализация JSON

                self.ui.plainTextEdit_2.appendPlainText('Создан "public" идентификатор')
                self.ui.plainTextEdit_2.appendPlainText('Передайте его собеседнику и начните диалог')
            else:
                self.ui.plainTextEdit_2.clear()
                self.ui.plainTextEdit_2.appendPlainText('Проверьте правильность вводимых данных!')
        else:
            self.ui.plainTextEdit_2.clear()
            self.ui.plainTextEdit_2.appendPlainText('Проверьте правильность вводимых данных!')

    # Закрытия соединения
    def closeEvent(self, event):
        try:
            self.tcp_client.send(b'exit')
            self.tcp_client.close()
        except:
            pass

    # Обновляем окно чата
    def update_chat(self, value):
        self.ui.plainTextEdit.appendHtml(value)

    # Очищаем окно с чатом
    def clear_panel(self):
        self.ui.plainTextEdit.clear()


if __name__ == "__main__":
    try:
        os.mkdir('friend_id')
    except OSError:
        print("Создать директорию %s не удалось 'friend_id'")
    else:
        print("Успешно создана директория %s 'friend_id'")
    app = QtWidgets.QApplication(sys.argv)
    myapp = Client()
    myapp.show()
    sys.exit(app.exec_())
