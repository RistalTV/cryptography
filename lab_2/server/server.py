import time
import socket
import base64
import threading


class Server:
    def __init__(self, ip, port):  # Инциализируем ip и port для прослушки соединения
        self.ip = ip  # ip к которому будут подключаться пользователи
        self.port = port  # порт к которому будут подключаться пользователи
        self.all_client = []  # список подключённых пользователей

        # Запускаем прослушивание соединений
        self.server = socket.socket(socket.AF_INET,
                                    socket.SOCK_STREAM)  # создаём IPv4 протокол и указываем что будет использоваться Tcp
        self.server.bind((self.ip, self.port))  # начинаем прослушивание по определённому ip и порту
        self.server.listen(0)  # сколько клиенов могут прослушивать сервер
        threading.Thread(target=self.connect_handler).start()  # запускаем поток чтобы отслеживать новое соединение
        print('Сервер запущен!')

    # Обрабатываем входящие соединения
    def connect_handler(self):
        while True:
            client, address = self.server.accept()  # принимаем подключения
            if client not in self.all_client:  # если клиента нет в списке то:
                self.all_client.append(client)  # добавляем ео в список;
                threading.Thread(target=self.message_handler, args=(
                    client,)).start()  # запускаем другой поток который принимается для обработки других значений
                client.send('Успешное подключение к чату!'.encode('utf-8'))
            time.sleep(1)

    # Обрабатываем отправленный текст
    def message_handler(self, client_socket):
        while True:
            message = client_socket.recv(1024)  # принмаем данные от клиента, принимая 1024 байт
            print("Сервер принял в таком ввиде данные: '" + message + "'")

            # Удаляем текущий сокет
            if message == b'exit':  # если сообщение будет содержать "exit" то есть клиент покинул чат
                self.all_client.remove(client_socket)  # удаляем его из списка
                break  # заканчиваем поток с "message_handler" и "connect_handler"

            for client in self.all_client:  # если условие не выполниось пробегаемся по всем клиентам
                if client != client_socket:  # проверяем не является клиент сервером
                    client.send(message)  # отправляем сообщение клиенту
            time.sleep(1)


if __name__ == "__main__":
    print("Лабораторная работа №2")  # Основная информация
    print("Выполнил: Скребнев Леонид ФИТУ 2-5")  # Основная информация
    print("Выполнила: Чернуцкая Екатерина ФИТУ 2-5")  # Основная информация
    print("Выполнил: Кутузов Леонид ФИТУ 2-5")  # Основная информация
    # запускаем сервер
    my_server = Server('127.0.0.1', 5555)
