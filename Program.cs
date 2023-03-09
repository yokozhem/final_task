//Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
//Примеры:
//["hello", "2", "world", ".-)"] -> ["2", ":-)"]
//["1234", "1567", "-2", "computer science"] -> ["-2"7
//["Russia", "Denmark", "Kazan"] -> []



        string[] arr = {"hello", "2", "world", ".-)"};
        string[] arr2 = new string[0];

        foreach (string str in arr)
        {
            int len = str.Length;

            if (len <= 3)
            {
                Array.Resize(ref arr2, arr2.Length + 1);
                arr2[arr2.Length - 1] = str;
            }
        }
      
        Console.WriteLine("Новый массив:");
        foreach (string str in arr2)
        {
            Console.WriteLine(str);
        }


       
  