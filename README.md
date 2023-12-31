# Задача: 

 Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

 * Пример: [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]


## Решение: 

1. Определение массива исходных строк:

```
В программе определен массив строк inputArray, содержащий значения "Hello", "2", "world", ":-)".
```

2. Вызов метода фильтрации:

 ```
 Программа вызывает метод FilterArray и передает ему массив inputArray.
 ```

3. Определение метода фильтрации:

```
Метод FilterArray принимает массив строк и выполняет следующие шаги.
```

4. Определение переменных:

 ```
 В методе создаются переменные count и index для подсчета количества подходящих строк и отслеживания текущей позиции в новом массиве.
 ```

5. Первый проход по исходному массиву для подсчета:

```
Программа проходит по каждой строке в inputArray и увеличивает count на 1 для каждой строки, длина которой меньше или равна 3 символам. В данном случае, "2" и ":-)" соответствуют этому условию.
```

6. Создание нового массива нужной длины:

 ```
 Создается новый массив resultArray длиной, равной значению переменной count.
 ```

7. Второй проход по исходному массиву для заполнения нового массива:

```
Программа проходит снова по каждой строке в inputArray и добавляет строки, удовлетворяющие условию (длина меньше или равна 3 символам), в resultArray.
```

8. Вывод результата на консоль:

```
Программа выводит строки из resultArray на консоль. В данном случае, выводит "2 :-)".
```

9. Ожидание ввода перед закрытием консольного окна:

```
Console.ReadLine() используется для ожидания ввода пользователя перед завершением выполнения программы.
```













