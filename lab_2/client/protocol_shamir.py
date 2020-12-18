import socket
import sys
import base64


def gcd_extended(num1: int, num2: int):
    """Расширенный алгоритма Евклида"""
    if num1 == 0:
        return num2, 0, 1
    else:
        div, x, y = gcd_extended(num2 % num1, num1)
    return div, y - (num2 // num1) * x, x


def re_squaring(m: int, e: int, p: int) -> int:
    """Повторное возведение в квадрат"""
    return pow(m, e, p)


def generate_key(e: int, p: int) -> int:
    """Генерируем ключ"""
    return pow(e, -1, (p - 1))


def crypt_message(message: str, p_number, e_number) -> str:
    """Шифруем сообщение"""
    # [1]
    alph, cmessage = "abcdefghijklmnopqrstuvwxyz", "[1]"
    for mes in message:
        # Переводим букву в числовой эквивалент
        m = 1
        for letter in alph:
            if mes == letter:
                break
            m += 1
        # Выполняем 1 шаг алгоритма Шамира
        cmessage += alph[re_squaring(m, int(e_number), int(p_number))-1]
    return cmessage


def decrypt_mes(message: str, server_socket, p_number, e_number, ip, port) -> str:
    """Расшифровываем сообщение"""
    # ----------------- [1] -----------------
    cmessage = ""
    if message[0] == '[' and message[1] == '1' and message[2] == ']':
        # отчищаем сообщение от транспортировочной мешуры
        for c in message:
            if c != '[' and c != '1' and c != ']':
                cmessage += c
        message = cmessage

        alph, cmessage = "abcdefghijklmnopqrstuvwxyz", "[2]"
        for mes in message:
            # Переводим букву в числовой эквивалент
            m = 1
            for letter in alph:
                if mes == letter:
                    break
                m += 1
            # Выполняем 2 шаг алгоритма Шамира
            cmessage += alph[re_squaring(m, int(e_number), int(p_number))-1]
        server_socket.sendto(cmessage.encode('utf-8'), (ip, int(port)))
        return cmessage
    # ----------------- [2] -----------------
    elif message[0] == '[' and message[1] == '2' and message[2] == ']':
        # отчищаем сообщение от транспортировочной мешуры
        for c in message:
            if c != '[' and c != '2' and c != ']':
                cmessage += c
        message = cmessage
        alph, cmessage = "abcdefghijklmnopqrstuvwxyz", "[3]"
        for mes in message:
            # Переводим букву в числовой эквивалент
            m = 1
            for letter in alph:
                if mes == letter:
                    break
                m += 1
            # Выполняем 2 шаг алгоритма Шамира
            cmessage += alph[re_squaring(m, generate_key(int(e_number), int(p_number)), int(p_number))-1]
        server_socket.sendto(cmessage.encode('utf-8'), (ip, int(port)))
        return cmessage
    # ----------------- [3] -----------------
    elif message[0] == '[' and message[1] == '3' and message[2] == ']':
        # отчищаем сообщение от транспортировочной мешуры
        for c in message:
            if c != '[' and c != '3' and c != ']':
                cmessage += c
        message = cmessage
        alph, cmessage = "abcdefghijklmnopqrstuvwxyz", ""
        for mes in message:
            # Переводим букву в числовой эквивалент
            m = 1
            for letter in alph:
                if mes == letter:
                    break
                m += 1
            # Выполняем 2 шаг алгоритма Шамира
            cmessage += alph[re_squaring(m, generate_key(int(e_number), int(p_number)), int(p_number))-1]
        return cmessage
    # ----------------- Остальные -----------------
    else:
        return message
