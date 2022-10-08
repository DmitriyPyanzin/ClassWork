from datetime import datetime as dt


def temperature_logger(data):
    time = dt.now().strftime('%H:%M')
    with open('g:/i_am_programmer/my_programs/ClassWork/2._Getting_to_know_Python/Lectures/Lesson_4._Python_from_simple_to_practical_translation/Task_2/log.cvs'
    , 'a') as file:
        file.write('{};temperature;{}\n'
                    .format(time, data))

def pressure_logger(data):
    time = dt.now().strftime('%H:%M')
    with open('g:/i_am_programmer/my_programs/ClassWork/2._Getting_to_know_Python/Lectures/Lesson_4._Python_from_simple_to_practical_translation/Task_2/log.cvs'
    , 'a') as file:
        file.write('{};pressure;{}\n'
                    .format(time, data))

def wind_speed_logger(data):
    time = dt.now().strftime('%H:%M')
    with open('g:/i_am_programmer/my_programs/ClassWork/2._Getting_to_know_Python/Lectures/Lesson_4._Python_from_simple_to_practical_translation/Task_2/log.cvs'
    , 'a') as file:
        file.write('{};wind_speed;{}\n'
                    .format(time, data))