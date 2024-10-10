using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

public class KorobkaZadach // создаём публичный класс, в котором будут находиться все решения задач.
{
    /*Задание 1. Методы
     * #2 Сумма знаков.
Дана сигнатура метода: public int sumLastNums (int x);
Необходимо реализовать метод таким образом, чтобы он возвращал результат
сложения двух последних знаков числах, предполагая, что знаков в числе не
менее двух. Подсказки:
int x=123%10; // х будет иметь значение 3
int у=123/10; // у будет иметь значение 12
Пример:
x=4568
результат: 14*/
    public void Zadanie1()
    {
        Console.WriteLine("Методы, задание #2. Введите число, которое состоит не менее, чем из двух цифр: ");
        int input = Convert.ToInt32(Console.ReadLine());
        int result = sumLastNums(input);
        Console.WriteLine($"Результат сложения двух последних знаков числа {input} = {result}");
    }
    // Метод нахождения суммы двух последних цифр
    public int sumLastNums(int x)
    {
        int LastCifra = x % 10; // Вычисляем последнюю цифру в числе
        int secondLastCifra = (x / 10) % 10; // Вычисляем предпоследнюю цифру в числе
        return LastCifra + secondLastCifra; // И возвращаем сумму предпоследней и последней цифры числа.
    }
    /* #4 Есть ли позитив.
Дана сигнатура метода: public bool isPositive (int x);
Необходимо реализовать метод таким образом, чтобы он принимал число x и
возвращал true, если оно положительное.
Пример 1:
x=3
результат: true
Пример 2:
x=-5
результат: false */
    public void Zadanie2()
    {
        Console.WriteLine("Методы, задание #4. Введите число для проверки на то, является ли оно положительным: ");
        int input = Convert.ToInt32(Console.ReadLine());
        bool result = isPositive(input);
        Console.WriteLine($"Число {input} является положительным: {result}"); ;
    }
    // проверка на положительное число
    public bool isPositive(int x)
    {
        return x > 0; // возвращаем true, если x больше 0
    }
    /* #6 Большая буква.
Дана сигнатура метода: public bool isUpperCase (char x);
Необходимо реализовать метод таким образом, чтобы он принимал символ x и
возвращал true, если это большая буква в диапазоне от ‘A’ до ‘Z’.
Пример 1:
x=’D’
результат: true
Пример 2:
x=’q’
результат: false */
    public void Zadanie3()
    {
        Console.WriteLine("Методы, задание #6. Введите букву английского алфавита для проверки, является ли она большой: ");
        char input = Convert.ToChar(Console.ReadLine());
        bool result = isUpperCase(input);
        Console.WriteLine($"Является ли символ {input} большой буквой? {result}");
    }
    public bool isUpperCase(char x)
    {
        return char.IsUpper(x);
    }
    /* #8 Делитель.
Дана сигнатура метода: public bool isDivisor (int a, int b);
Необходимо реализовать метод таким образом, чтобы он возвращал true, если
любое из принятых чисел делит другое нацело.
Пример 1:
a=3 b=6
результат: true
Пример 2:
a=2 b=15
результат: false */
    public void Zadanie4()
    {
        Console.WriteLine("Методы, задание #8. Введите два числа для проверки на делимость: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        bool result = isDivisor(a, b);
        Console.WriteLine($"Разделится ли число нацело? {result}");
    }
    // проверка на делимость
    public bool isDivisor(int a, int b)
    {
        return (b % a == 0 || a % b == 0); // возвращаем true, если число b делит a нацело и наоборот
    }
    /* #10 Многократный вызов.
Дана сигнатура метода: public int lastNumSum(int a, int b)
Необходимо реализовать метод таким образом, чтобы он считал сумму цифр
двух чисел из разряда единиц. Выполните с его помощью последовательное
сложение пяти чисел и результат выведите на экран. Постарайтесь выполнить
задачу, используя минимально возможное количество вспомогательных
переменных.
Пример:
5+11 это 6
6+123 это 9
9+14 это 13
13+1 это 4
Итого 4 */
    public void Zadanie5()
    {
        int sum = 0;
        Console.WriteLine("Методы, задание #10. Введите 5 чисел для сложения: ");
        int input = Convert.ToInt32(Console.ReadLine());
        sum += input % 10; // Прибавляем последнюю цифру к сумме
        for (int i = 1; i < 5; i++) // Цикл для ввода 5 чисел.
        {
            input = Convert.ToInt32(Console.ReadLine());
            sum = lastNumSum(sum, input);
        }
        Console.WriteLine($"Результат: {sum}");
    }
    public int lastNumSum(int a, int b)
    {
        return (a % 10) + (b % 10);
    }
    /* Задание 2. Условия
     * #2 Безопасное деление.
Дана сигнатура метода: public double safeDiv (int x, int y);
Необходимо реализовать метод таким образом, чтобы он возвращал деление x
на y, и при этом гарантировал, что не будет выкинута ошибка деления на 0. При
делении на 0 следует вернуть из метода число 0. Подсказка: смотри
ограничения на операции типов данных.
Пример 1:
x=5 y=0
результат: 0
Пример 2:
x=8 y=2
результат: 4 */
    public void Zadanie6()
    {
        Console.WriteLine("Условия, задание #2, введите два числа для деления: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        double result = safeDiv(x, y);
        Console.WriteLine($"Ответ: {result} ");
    }
    public double safeDiv(int x, int y)
    {
        if (y == 0) 
        { 
        return 0;
        }
        if (x == 0)
        {
            return 0;
        }
        else
        {
            return (double) x / y;
        }
    }
    /* #4 Строка сравнения.
Дана сигнатура метода: public String makeDecision (int x, int y);
Необходимо реализовать метод таким образом, чтобы он возвращал строку,
которая включает два принятых методом числа и корректно выставленный
знак операции сравнения (больше, меньше, или равно).
Пример 1:
x=5 y=7
результат: “5< 7”
Пример 2:
x=8 y=-1
результат: “8 >-1”
Пример 3:
x=4 y=4
результат: “4==4” */
    public void Zadanie7()
    {
        Console.WriteLine("Условия, задание #4, введите два числа для сравнения: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        string result = makeDecision(x, y);
        Console.WriteLine($"Результат: {result}");
    }
    public string makeDecision(int x, int y) 
    {
        if (x > y)
        {
            return $"{x} > {y}";
        }
        else if (x < y)
        {
            return $"{x} < {y}";
        }
        else { 
        return $"{x} == {y}";
        }
    }
    /* #6 Тройная сумма.
Дана сигнатура метода: public bool sum3 (int x, int y, int z);
Необходимо реализовать метод таким образом, чтобы он возвращал true, если
два любых числа (из трех принятых) можно сложить так, чтобы получить
третье.
Пример 1:
x=5 y=7 z=2
результат: true
Пример 2:
x=8 y=-1 z=4
результат: false */
    public void Zadanie8()
    {
        Console.WriteLine("Условия, задание #6, введите три числа для проверки на возможность из суммы двух чисел, получить третье: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int z = Convert.ToInt32(Console.ReadLine());
        bool result = sum3(x, y, z);
        Console.WriteLine($"Результат: {result}");
    }
    public bool sum3(int x, int y, int z)
    {
        return (x + y == z) || (x + z == y) || (y + z == x);
    }
    /* #8 Возраст.
Дана сигнатура метода: public String age (int x);
Необходимо реализовать метод таким образом, чтобы он возвращал строку, в
которой сначала будет число х, а затем одно из слов:
год
года
лет
Слово “год” добавляется, если число х заканчивается на 1, кроме числа 11.
Слово “года” добавляется, если число х заканчивается на 2, 3 или 4, кроме чисел
12, 13, 14.
Слово “лет”добавляется во всех остальных случаях.
Подсказка: оператор % позволяет получить остаток от деления.
Пример 1:
x=5
результат: “5 лет”
Пример 2:
x=31
результат: “31 год”
Пример 3:
x=44
результат: “44 года */
    public void Zadanie9()
    {
        Console.WriteLine("Условия, задание #8, введите возраст: ");
        int x = Convert.ToInt32(Console.ReadLine());
        string result = age(x);
        Console.WriteLine($"Результат: {result}");
    }
    public String age(int x)
    {
        string slovo;
        int lastCifra = x % 10;
        int lastDveCifri = x % 100;
        if (lastCifra == 1 && lastDveCifri != 11)
        {
            slovo = "год";
        }
        else if ((lastCifra == 2 || lastCifra == 3 || lastCifra == 4) && (lastDveCifri != 12 ||  lastDveCifri != 13 || lastDveCifri != 14))
        {
            slovo = "года";
        }
        else
        {
            slovo = "лет";
        }
        return $"{x} {slovo}";
        
    }
    /* #10 Вывод дней недели.
Дана сигнатура метода: public void printDays (String x);
В качестве параметра метод принимает строку, в которой записано название
дня недели. Необходимо реализовать метод таким образом, чтобы он выводил
на экран название переданного в него дня и всех последующих до конца недели
дней. Если в качестве строки передан не день, то выводится текст “это не день
недели”. Первый день понедельник, последний – воскресенье. Вместо if в данной
задаче используйте switch.
Пример 1:
x=”четверг”
результат:
четверг
пятница
суббота
воскресенье
Пример 2:
x=”чг”
результат:
это не день недели */
    public void Zadanie10()
    {
        Console.WriteLine("Условия, задание #10, введите день недели: ");
        string input = Console.ReadLine().ToLower(); // ToLower для того, чтобы регистр не влиял на результат
        PrintDays(input);
    }
    public void PrintDays(string x)
    {
        switch (x)
        {
            case "понедельник":
                Console.WriteLine("понедельник");
                Console.WriteLine("вторник");
                Console.WriteLine("среда");
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "вторник":
                Console.WriteLine("вторник");
                Console.WriteLine("среда");
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "среда":
                Console.WriteLine("среда");
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "четверг":
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "пятница":
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "суббота":
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "воскресенье":
                Console.WriteLine("воскресенье");
                break;
            default:
                Console.WriteLine("это не день недели");
                break;
        }
    }
    /* Задание 3. Циклы
     * #2 Числа наоборот.
Дана сигнатура метода: public String reverseListNums (int x);
Необходимо реализовать метод таким образом, чтобы он возвращал строку, в
которой будут записаны все числа от x до 0 (включительно).
Пример:
x=5
результат: “5 4 3 2 1 0” */
    public void Zadanie11()
    {
        Console.WriteLine("Циклы, задание #2, введите число для обратного отсчёта: ");
        int input = Convert.ToInt32(Console.ReadLine());
        string result = reverseListNums(input);
        Console.WriteLine($"Результат: {result}");
    }
    public string reverseListNums(int x)
    {
        string result = "";
        for (int i = x; i >= 0; i--) {
            result += i + " ";
        }
        return result.Trim(); // для удаления лишних пробелов, используем Trim()
    }
    /* #4 Степень числа.
Дана сигнатура метода: public int pow (int x, int y);
Необходимо реализовать метод таким образом, чтобы он возвращал результат
возведения x в степень y.
Подсказка: для получения степени необходимо умножить единицу на число x, и
сделать это y раз, т.е. два в третьей степени это 1*2*2*2
Пример:
x=2
y=5
результат: 32 */

    public void Zadanie12()
    {
        Console.WriteLine("Циклы, задание #4, введите число x и степень y для возведения в степень: ");
        Console.Write("Введите число x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите степень y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        int result = pow(x, y);
        Console.WriteLine($"Результат: {x} в степени {y} = {result}");
    }
    public int pow(int x, int y) {
        int result = 1;
        for (int i = 0; i < y; i++)
        {
            result *= x;
        }
        return result;
    }
    /* #6 Одинаковость.
Дана сигнатура метода: public bool equalNum (int x);
Необходимо реализовать метод таким образом, чтобы он возвращал true, если
все знаки числа одинаковы, и false в ином случае.
Подсказки:
intx=123%10; // х будет иметь значение 3
intу=123/10; // у будет иметь значение 12
Пример 1:
x=1111
результат: true
Пример 2:
x=1211
результат: false */
    public void Zadanie13()
    {
        Console.WriteLine("Циклы, задание #6, введите число для проверки на одинаковость: ");
        int input = Convert.ToInt32(Console.ReadLine());
        bool result = equalNum(input);
        Console.WriteLine($"Одинаковы ли все цифры числа {input}? {result}");
    }
    public bool equalNum(int x) {
        int lastCifra = x % 10;
        x /= 10;
        while (x > 0)
        {
            if (x % 10 != lastCifra)
            {
                return false;
            }
            x /= 10;
        }
        return true;
    }
    /* #8 Левый треугольник.
Дана сигнатура метода: public void leftTriangle (int x);
Необходимо реализовать метод таким образом, чтобы он выводил на экран
треугольник из символов ‘*’ у которого х символов в высоту, а количество
символов в ряду совпадает с номером строки.
Пример 1:
x=2
результат:
*
**
Пример 2:
x=4
результат:
*
**
***
**** */
    public void Zadanie14()
    {
        Console.WriteLine("Циклы, задание #8, введите вашу высоту треугольника: ");
        int input = Convert.ToInt32(Console.ReadLine());
        leftTriangle(input);
    }
    public void leftTriangle(int x)
    {
        for (int i = 1; i <= x; i++) // цикл количества строк
        {
            for (int j = 1; j <= i; j++) // цикл для вывода звёздочек 
            {
                Console.Write("*");
            }
            Console.WriteLine(); // переход на новую строчку после каждой строки со звёздочками
        }
    }
    /* Задание 4. Массивы
     * #2 Поиск последнего значения.
Дана сигнатура метода: public int findLast (int[] arr, int x);
Необходимо реализовать метод таким образом, чтобы он возвращал индекс
последнего вхождения числа x в массив arr. Если число не входит в массив –
возвращается -1.
Пример:
arr=[1,2,3,4,2,2,5]
x=2
результат: 5 */
    public void Zadanie16()
    {
        // размер массива
        Console.Write("Массивы, задание #2, введите размер массива: ");
        int size = int.Parse(Console.ReadLine()); // Parse тут нужен для перевода строки в число
        // создание массива
        int[] arr = new int[size];
        // Ввод элементов массива
        Console.WriteLine("Введите элементы массива: ");
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine()); // Parse тут нужен для перевода строки в число
        }
        // Вводим число x для поиска
        Console.Write("Введите число для поиска последнего вхождения в массив arr: ");
        int x = int.Parse(Console.ReadLine());
        int result = findLast(arr, x);
        Console.WriteLine($"Индекс последнего вхождения числа {x}: {result}");
    }
    public int findLast(int[] arr, int x)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == x)
            {
                return i; // Возвращение индекса последнего вхождения
            }
        }
        return -1;
    }
    /* #4 Добавление в массив.
Дана сигнатура метода: public int[]add (int[] arr, int x, int pos);
Необходимо реализовать метод таким образом, чтобы он возвращал новый
массив, который будет содержать все элементы массива arr, однако в позицию
pos будет вставлено значение x.
Пример:
arr=[1,2,3,4,5]
x=9
pos=3
результат: [1,2,3,9,4,5] */
    public void Zadanie17()
    {
        Console.Write("Массивы, задание #4, введите размер массива: ");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        Console.WriteLine("Введите элементы массива: ");
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Введите число для вставки: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Введите позицию для вставки: ");
        int pos = int.Parse(Console.ReadLine());
        int[] result = add(arr, x, pos);
        Console.WriteLine("Ваш новый массив: " + string.Join(", ", result)); // string.Join нужно для вывода массива в строку с разделением значений через запятую и пробел.
    }
    public int[] add(int[] arr, int x, int pos) {
        int[] newArr = new int[arr.Length + 1];
        // Копирование элементов из старого массива до pos
        for (int i = 0; i < pos; i++)
        {
            newArr[i] = arr[i];
        }
        newArr[pos] = x;
        for (int i = pos; i < arr.Length; i++)
        {
            newArr[i + 1] = arr[i];
        }
        return newArr;
    }
    /* #8 Объединение.
Дана сигнатура метода: public int[] concat (int[] arr1,int[] arr2);
Необходимо реализовать метод таким образом, чтобы он возвращал новый
массив, в котором сначала идут элементы первого массива (arr1), а затем
второго (arr2).
Пример:
arr1=[1,2,3]
arr2=[7,8,9]
результат: [1,2,3,7,8,9] */
    public void Zadanie19() {
        Console.Write("Массивы, задание #8, введите размер первого массива: ");
        int size1 = int.Parse(Console.ReadLine());
        Console.Write("Введите размер второго массива: ");
        int size2 = int.Parse(Console.ReadLine());
        int[] arr1 = new int[size1];
        Console.WriteLine("Введите элементы первого массива: ");
        for (int i = 0; i < size1; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }
        int[] arr2 = new int[size2];
        Console.WriteLine("Введите элементы второго массива: ");
        for (int i = 0;i < size2; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
        }
        int[] result = concat(arr1, arr2);
        Console.WriteLine("Объединённый массив: " + string.Join(", ", result));
    }
    public int[] concat(int[] arr1, int[] arr2)
    {
        int[] newArr = new int[arr1.Length + arr2.Length];
        for (int i = 0 ; i < arr1.Length; i++)
        {
            newArr[i] = arr1[i];
        }
        for (int i = 0 ;i < arr2.Length; i++)
        {
            newArr[arr1.Length + i] = arr2[i];
        }
        return newArr;
    }
    /* #10 Удалить негатив.
Дана сигнатура метода: public int[] deleteNegative (int[] arr);
Необходимо реализовать метод таким образом, чтобы он возвращал новый
массив, в котором записаны все элементы массива arr кроме отрицательных.
Пример:
arr=[1,2,-3,4,-2,2,-5]
результат: [1,2,4,2] */
    public void Zadanie20()
    {
        Console.Write("Массивы, задание #10, введите размер массива: ");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        Console.WriteLine("Введите элементы массива: ");
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int[] result = deleteNegative(arr);
        Console.WriteLine("Обновлённый массив без отрицательных элементов: " + string.Join(",", result));
    }
    public int[] deleteNegative(int[] arr)
    {
        int positiveCount = 0;
        for (int i = 0; i < arr.Length;i++)
        {
            if (arr[i] >= 0)
            {
                positiveCount++;
            }
        }
        int[] newArr = new int[positiveCount];
        int newArrIndex = 0;
        for (int i = 0;i < arr.Length;i++)
        {
            if (arr[i] >= 0)
            {
                newArr[newArrIndex] = arr[i];
                newArrIndex++;
            }
        }
        return newArr;
    }
    public static void Main(string[] args)
    {
        KorobkaZadach reshenie = new  KorobkaZadach();
        reshenie.Zadanie1(); // сумма двух последних цифр числа
        reshenie.Zadanie2(); // проверка положительного числа
        reshenie.Zadanie3(); // проверка на большую букву
        reshenie.Zadanie4(); // проверка на делимость числа.
        reshenie.Zadanie5(); // многократный вызов.
        reshenie.Zadanie6(); // безопасное деление
        reshenie.Zadanie7(); // Строка сравнения.
        reshenie.Zadanie8(); // Тройная сумма.
        reshenie.Zadanie9(); // Возраст.
        reshenie.Zadanie10(); // Вывод дней недели
        reshenie.Zadanie11(); // Числа наоборот.
        reshenie.Zadanie12(); // Степень числа.
        reshenie.Zadanie13(); // Одинаковость.
        reshenie.Zadanie14(); // Левый треугольник
        reshenie.Zadanie16(); // Поиск последнего значения.
        reshenie.Zadanie17(); // Добавление в массив
        reshenie.Zadanie19(); // Объеденение
        reshenie.Zadanie20(); // Удалить негатив
    }
}
