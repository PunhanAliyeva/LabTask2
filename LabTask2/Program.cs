
#region Task1
//Console.WriteLine("N deyeri daxil edin:");
//num:
//string strNum=Console.ReadLine();
//bool CheckNum = int.TryParse(strNum, out int input);
//int result = 1;
//if (!CheckNum)
//{
//    Console.WriteLine("Duzgun eded daxil edin..");
//    goto num;
//}
//for (int i = 1; i <= 10; i++)
//{
//    result = input * i;
//    Console.WriteLine(result);
//}
#endregion


#region Task2

//int[] arr = { 3, 1, 21, 9, 2, 7, 12 };
//int[] arr1 = new int[arr.Length];          //3,9,12,0,0,0,0
//int[] arr2 = new int[arr.Length];          //1,2,0,0,0,0,0
//int[] arr3 = new int[arr.Length];          //21,7,0,0,0,0,0
//int j = 0;
//for (int i = 0; i < arr.Length; i+=3)
//{
//    arr1[j] = arr[i];
//    if (i + 1 < arr.Length)
//    {
//        arr2[j] = arr[i + 1];
//    }
//    if(i + 2 < arr.Length)
//    {
//        arr3[j] = arr[i + 2];
//    }
//    j++;
//}
//foreach (int i in arr1)
//{
//    Console.WriteLine(i);
//}
#endregion


#region Task3

//string[] names = { "Punhan", "Aygun", "Ali", "Selma", "Kubra" };
//string[] newArr = new string[names.Length];
//char letter = 'u';
//char newLetter = 'e';
//foreach (string name in names)
//{
//    for (int i = 0; i < name.Length; i++)
//    { 
//        if (name[i] == letter)
//        {
//            newArr[i] = name;
//            Console.WriteLine($"Old Name:{newArr[i]}");
//        }
//        char[] charArr = name.ToCharArray();
//        if (charArr[i] == letter)
//        {
//            charArr[i] = newLetter;
//            string newNames = new string(charArr);
//            Console.WriteLine($"New Name:{newNames}");
//        }
//    }
//}
#endregion