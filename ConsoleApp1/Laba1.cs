


class Laba1
{
    static void Main(string[] args)
    {
        try
        {
            int[] arr = inputArr();
            Console.Write("полученный массив: ");
            printArr(reconfigureArr(arr));
            Console.WriteLine($"сумма между 1 и вторым положительным элементами: {sum12(arr)}");
            Console.WriteLine($"максимальный по модулю элемент: {maxAbs(arr)}");
        }
        catch (Exception ex) { Console.WriteLine("Введены некорректные данные"); return;}
    }
    //печать массива
    static void printArr(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write($"{arr[i]}, ");
        }
        Console.Write($"{arr[arr.Length - 1]}.\n");
    }

    //ввод массива
    static int[] inputArr()
    {
        Console.WriteLine("Введите размерность массива: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Введите {i + 1}-й элемент массива: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        return arr;
    }

    //подсчет максимального по модулю
    static int maxAbs(int[] arr)
    {
        int max = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (Math.Abs(arr[i]) > Math.Abs(max))
            {
                max = arr[i];
            }
        }
        return max;
    }

    //подсчет суммы между 1 и 2 положительным
    static int sum12(int[] arr) {
        int first = -1;
        int second = -1;
        int sum = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i]>0&&first==-1)
                first=i;
            else if(arr[i]>0&&first!=-1&&second==-1)
                second=i;
            if (first != -1 && second != -1)
                break;
        }
        for(int j=first+1;j<second; j++)
        {
            sum+=arr[j];
        }
        return sum;
    }

    static int[] reconfigureArr(int[] arr)
    {
        int counter = 0;
        int[] arrNew=new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i]!=0)
                arrNew[counter++]=arr[i];
        }
        for(int i=counter;i<arrNew.Length; i++)
        {
            arrNew[i] = 0;
        }
        return arrNew;
    }

}