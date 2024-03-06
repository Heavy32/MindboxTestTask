Доброго времени суток! Здесь представлены варианты выполнения тестового задания.
Так как оценивается в первую очередь умение рассуждать - я решил предложить несколько вариантов.



Задание:
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

Юнит-тесты

Легкость добавления других фигур

Вычисление площади фигуры без знания типа фигуры в compile-time

Проверку на то, является ли треугольник прямоугольным



Для удобства все варианты можно продебажить здесь https://github.com/Heavy32/MindboxTestTask/blob/master/MindboxTestTask/Program.cs

Первый вариант:
https://github.com/Heavy32/MindboxTestTask/tree/master/LogicInClassVersion

Суть заключается в том, что логика вычисления площади лежит в самом классе фигуры. 

Из минусов:
-Данные и логика работы с этими данными лежат в одном месте. Хочется всё-таки разделять эти вещи, создавая, например, модельки и сервисы, которые работают с этими моделями.
В данном тестовом задании это может считаться допустимым (на мой взгляд), так как сама логика маленькая и легко ложиться в функционал обычных свойств. Однако, если мы хотим добавить что-то ещё, нам будет тяжелее это сделать и поддерживать этот код будет проблематично.

Из плюсов:
-Добавление новых фигур может считаться относительно лёгким, так как нам не нужно создавать много сервисов. Если нам не нужна фигура, у которой вычисляется площадь, мы не будем использовать интрефейс ISquareCalculatedFigure. В теории,  можно было бы выстроить иерархию интерфейсов, где ISquareCalculatedFigure наследуется от условного IFigure (как сделано в других вариантах).
-Нам не нужно создавать много отдельных сервисов для расчета площади каждой фигуры - у нас есть один класс Calculator, которым может пользоваться внешний клиент. Calculator умеет вычислять площадь любой фигуры, которая реализует интерфейс ISquareCalculatedFigure.

Тесты: 
https://github.com/Heavy32/MindboxTestTask/tree/master/LogicInFigureVersionTests

Второй вариант:
https://github.com/Heavy32/MindboxTestTask/tree/master/SquareCalculatorFactoryVersion

Суть заключается в том, что сервис Calculator по фигуре достаёт нужный сервис расчёта площади через фабрику. 

Из минусов:
-На данный момент этого минуса не видно, но если сервисы расчёта площади будут иметь какие-то зависимости, то их все нужно будет иньектить в фабрику. Больше сервисов - больше зависимостей. К тому же, не все из этих зависимостей действительно будут нужны в конкретный момент времени.
-Нарушается open/closed principle. При добавлении нового сервиса расчёта, нужно будет добавлять в существующий код новый кейсы. Пока у нас две фигуры - это не страшно, но фигур может быть больше, а значит метод Create в фабрике станет очень большим.
Данный минусы можно решить применением паттерна "сервис-локатор". Но этот паттерн считается анти-паттерном и влечёт другие проблемы. Поэтому данный подход я даже и не реализовывал.

Из плюсов:
-Клиенту проще работать с классом Calculator - он всего лишь передаёт туда фигуру, а площадь уже сама будет высчитываться. Единственное, что хочется отметить - для данной фигуры может быть не реализовано сервиса расчёт площади, в данном случае будет кидаться кастомное исключение.


Третий вариант:
https://github.com/Heavy32/MindboxTestTask/tree/master/FigureServices

Здесь у нас на каждую фигуру создаётся свой сервис расчёта площади. Класс Calculator теперь дженериковый.

Из минусов:
-Клиенту придётся вызывать свой сервис для каждой фигуры. В теории, можно воспользоваться паттерном "медиатор", который по типу фигуры будет вызывать нужный сервис. Если будет нужно - готов попробовать реализовать.

Из плюсов:
-Добавление фигур происходит быстро.
-Много компактных классов, у которых четко выражена одна ответственность.

Тесты: 
https://github.com/Heavy32/MindboxTestTask/tree/master/FigureServicesVersionTests


P.S. условие "Проверку на то, является ли треугольник прямоугольным" не было реализовано по причине того, то ни в один из трёх вариантов нельзя передать прямоугольник, чтобы посчитать площадь треугольника.
Если проверялось умение валидирования - то я реализовал пару небольших проверок.
Если условие обязательно, то мне нужны рабочие кейсы, где это могло бы случиться. На данный момент не вижу, где это могло бы "выстрелить".


Sql запрос для второго задания: https://github.com/Heavy32/MindboxTestTask/blob/master/MindboxSQL.sql
Для удобства добавлено заполнение и создание базы. Можно посмотреть как работает

Мне было бы очень приятно и полезно, если бы я получил любой фидбэк по своему коду. Так как любая критика повышает мой навык.
Со мной можно связаться
в телеграмме : +7-952-659-22-32
по почте: maksim.gorankov@gmail.com
