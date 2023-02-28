# Аттестация по первому блоку
В данном репозитории находятся следующие файл и папки:
 * папка Task_for_attestation с решением задачи по аттестации; 
 * файл README.md с текстовым описанием решения;
 * папка images с двумя рисунками блок-схем с основной содержательной частью решения задачи;
 * папка с оригиналами блок-схем, реализованных с помощью [drowio.com](https://app.diagrams.net/).

## Задача
**Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна три символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.**

## Решение задачи
Задача решена с использованием нескольких функций:

* GetNumber(...) - просит ввести и возвращает целое число, которое задает размер исходного массива. В случае введения нечислового значения или равного или меньшего нуля, возвращает сообщение об ошибке.

* FillArray(...) - создает и заполняет массив типа string путем ввода данных с клавиатуры и возвращает заполненный массив.

* FindQuantityOfElements(...) - находит и возвращает количество элементов массива, удовлетворяющих условию: длина меньше либо равна 3.

* ComponateResultArray(...) - создает новый массив и заполняет его элементами, удовлетворяющими условию задачи: длина меньше либо равна 3.

* ShowArrays(...) - выводит массив на печать.

Блок-схемы основной части алгоритма по решению задачи представлены ниже.

## Блок-схемы:

![Блок схема функции по нахождению количества элементов в массиве, длина которых меньше либо равна 3](/images/FindQuantityOfElements.png)
![Блок схема функции по созданию нового массива с элементами, длина которых меньше либо равна 3](/images/ComponateResultArray.png)