import socket
import sys
import time

from PyQt5 import QtCore
from PyQt5.QtWidgets import QMainWindow, QApplication

# Мониторинг входящих сообщений
from protocol_shamir import decrypt_mes, crypt_message

# Импортируем наш шаблон.
from mydesign import Ui_MainWindow


class message_monitor(QtCore.QThread):
    mysignal = QtCore.pyqtSignal(str)

    def __init__(self, server_socket, p_number, e_number, ip, port, parent=None):
        QtCore.QThread.__init__(self, parent)
        self.server_socket = server_socket
        self.message = None
        self.p_number = p_number
        self.e_number = e_number
        self.ip = ip
        self.port = port

    def run(self):
        global decrypt_message
        while True:
            try:  # Данные от собеседника (зашифрованные)
                self.message = self.server_socket.recv(1024)
                if type(self.message) is bytes:
                    mes = str(bytes(self.message), 'utf-8')
                else:
                    mes = str(self.message)
                decrypt_message = decrypt_mes(mes,
                                              self.server_socket,
                                              int(self.p_number),
                                              int(self.e_number),
                                              self.ip,
                                              int(self.port)
                                              )
                if decrypt_message[0] != "[":
                    self.mysignal.emit(str(decrypt_message))
            except Exception as e:
                self.mysignal.emit(self.message.decode('utf-8'))
                break


class mywindow(QMainWindow):
    def __init__(self, parent=None):
        super(mywindow, self).__init__()
        self.ui = Ui_MainWindow()
        self.ui.setupUi(self)
        self.ip = None
        self.port = None
        self.p_number = None
        self.e_number = None
        self.ui.btn_send.setEnabled(False)
        self.ui.send_Text.setEnabled(False)
        self.ui.btn_clear.setEnabled(False)
        # Обработчики кнопок
        self.ui.btn_connect.clicked.connect(self.connect_server)
        self.ui.btn_send.clicked.connect(self.send_message)
        self.ui.btn_clear.clicked.connect(self.clear_panel)

    def connect_server(self):
        # Подключаемся к серверу
        try:
            if (len(self.ui.ip_address.text()) > 0 or
                    len(self.ui.port_address.text()) > 0 or
                    len(self.ui.p_number.text()) > 0 or
                    len(self.ui.e_number.text()) > 0):
                self.ip = self.ui.ip_address.text()
                self.port = self.ui.port_address.text()
                self.p_number = self.ui.p_number.text()
                self.e_number = self.ui.e_number.text()
                self.tcp_client = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
                self.tcp_client.bind(('', 0))  # Задаем сокет как клиент
                self.tcp_client.connect((self.ip, int(self.port)))
                time.sleep(2)
                # Запускаем мониторинг входящих сообщений
                self.message_monitor = message_monitor(self.tcp_client, self.p_number, self.e_number, self.ip,
                                                       int(self.port))
                self.message_monitor.mysignal.connect(self.update_chat)
                self.message_monitor.start()
                # Производим действия с объектами
                self.ui.ip_address.setEnabled(False)
                self.ui.port_address.setEnabled(False)
                self.ui.btn_connect.setEnabled(False)
                self.ui.p_number.setEnabled(False)
                self.ui.e_number.setEnabled(False)
                self.ui.btn_send.setEnabled(True)
                self.ui.send_Text.setEnabled(True)
                self.ui.btn_clear.setEnabled(True)
            else:
                self.ui.WindowChat.clear()
                self.ui.WindowChat.appendPlainText('Не введены полностью данные в настройках')
                self.ui.btn_send.setEnabled(False)
                self.ui.send_Text.setEnabled(False)
                self.ui.btn_clear.setEnabled(False)
        except Exception as e:
            self.ui.WindowChat.clear()
            self.ui.WindowChat.appendPlainText('Ошибка подключения к серверу!')
            self.ui.WindowChat.appendPlainText('Ошибка(connect_server): ' + str(e.args[0]))

    # Отправить сообщение
    def send_message(self):
        text = self.ui.send_Text.text()
        try:
            if len(text) > 0:
                message = self.ui.send_Text.text()
                message = message.lower()
                crypto_message = crypt_message(message, self.p_number, self.e_number)
                self.ui.WindowChat.appendPlainText(f'[Вы]: {message}')
                self.tcp_client.send(crypto_message.encode('utf-8'))
                self.ui.send_Text.clear()
        except Exception as e:
            self.ui.WindowChat.clear()
            self.ui.WindowChat.appendPlainText('Ошибка(send_message): ' + e.args[0])
            sys.exit()

    # Закрытия соединения
    def closeEvent(self, event):
        try:
            self.tcp_client.send(b'exit')
            self.tcp_client.close()
        except Exception as e:
            self.ui.WindowChat.clear()
            self.ui.WindowChat.appendPlainText('Ошибка(closeEvent): ' + e.args[0])

    # Обновляем окно чата
    def update_chat(self, value):
        self.ui.WindowChat.appendHtml(value)

    # Очищаем окно с чатом
    def clear_panel(self):
        self.ui.ip_address.setEnabled(True)
        self.ui.port_address.setEnabled(True)
        self.ui.btn_connect.setEnabled(True)
        self.ui.p_number.setEnabled(True)
        self.ui.e_number.setEnabled(True)
        self.ui.WindowChat.clear()


if __name__ == "__main__":
    app = QApplication([])
    application = mywindow()
    application.show()
    sys.exit(app.exec())
