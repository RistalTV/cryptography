import socket
import threading
import time

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
        print('Сервер запущен по адресу: ' + str(self.ip) + " " + str(self.port) + "!")

    # Обрабатываем входящие соединения
    def connect_handler(self):
        while True:
            clieт, address = self.server.accept()  # принимаем подключения
            if clieт not in self.all_client:  # если клиента нет в списке то:
                self.all_client.append(clieт)  # добавляем ео в список;
                threading.Thread(target=self.message_handler,
                                 args=(clieт,)
                                 ).start()  # запускаем другой поток который принимается для обработки других значений
                clieт.send('Успешное подключение к чату!'.encode('utf-8'))
            time.sleep(1)

    # Обрабатываем отправленный текст
    def message_handler(self, client_socket):
        while True:
            try:
                message = client_socket.recv(1024)  # принмаем данные от клиента, принимая 1024 байт
                print("Сервер принял в таком виде данные: '" + str(message) + "'")

                # Удаляем текущий сокет
                if message == b'exit':  # если сообщение будет содержать "exit" то есть клиент покинул чат
                    self.all_client.remove(client_socket)  # удаляем его из списка
                    break  # заканчиваем поток с "message_handler" и "connect_handler"

                for clien in self.all_client:  # если условие не выполниось пробегаемся по всем клиентам
                    if clien != client_socket:  # проверяем не является клиент сервером
                        clien.send(message)  # отправляем сообщение клиенту
            except Exception as e:
                print(str(e.args[0]))
            time.sleep(1)


# import socket

if __name__ == "__main__":
    print("Лабораторная работа №2")  # Основная информация
    print("Выполнил: Скребнев Леонид ФИТУ 2-5")  # Основная информация
    print("Выполнила: Чернуцкая Екатерина ФИТУ 2-5")  # Основная информация
    print("Выполнил: Кутузов Леонид ФИТУ 2-5")  # Основная информация
    print("Введите адресс сервера(0 для локального сервера):")
    ip=str(input())
    if(ip == "0"):
        ip = '127.0.0.1'
    print("Введите порт сервера(0 для локального сервера):")
    port = int(input())
    if(port == 0):
        port = 8080
    # Запускаем сервер
    my_server = Server(ip, port)