from datetime import datetime


def print_result(result, number_first, number_second, answer):
    with open('g:/i_am_programmer/my_programs/ClassWork/2._Getting_to_know_Python/Seminars/Lesson_7._Python_from_simple_to_practical_translation/result.txt', 'a+', encoding='UTF-8') as file:
        file.write(f'{number_first} {answer} {number_second} = {result} --- {datetime.now()}\n')