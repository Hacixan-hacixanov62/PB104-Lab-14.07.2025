//=================================================== Alqorithms ===================================================



//1)Verilmiş Arrayın ilk və son elementlərinin cəmini tapın


//int ArrayOfNumbersSum(int[] array)
//{
//    if (array.Length == 0)
//    {
//        return 0;
//    }

//    int firstElement = array[0];
//    int lastElement = array[array.Length - 1];
//    int sum = firstElement + lastElement;
//    return sum;
//}

//int[] arr = { 2, 3, 4, 5 };
//Console.WriteLine(ArrayOfNumbersSum(arr));



//2)Verilmiş müsbət tam n ədədinin 2-nin qüvvəti olub-olmamasını tapın

//bool IsPowOfTwo(int n)
//{
//    int count = 0;
//    if (n <= 0)
//    {
//        Console.WriteLine("musbet ededi daxil edin");
//    }
//    while (n % 2 == 0)
//    {
//        n /= 2;
//        count++;
//    }
//    if(count > n)
//    {
//        return true;
//    }
//    return false;
//}

//Console.WriteLine(IsPowOfTwo(16));



//bool IsPowerOfTwo(int n)
//{
//    if (n <= 0)
//    {
//        return false;
//    }
//    while (n % 2 == 0)
//    {
//        n /= 2;
//    }

//    return n == 1;
//}

//Console.WriteLine(IsPowerOfTwo(16));



//3)Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın. Məs: 23452, output: 5  

//int NumberOfFloors(int n)
//{
//    int count = 0;
//    if (n <= 0)
//    {
//        Console.WriteLine("musbet eded olmalidir");
//        return count;
//    }
//    while (n > 0)
//    {
//        n /= 10;
//        count++;
//    }
//    return count;
//}

//Console.WriteLine(NumberOfFloors(100));

//int NumberOfFloors(int n)
//{
//    if (n <= 0)
//    {
//        Console.WriteLine("musbet daxil edin");
//    }
//    for (int i = 0; n>0; i++)
//    {
//        n /= 10;
//        if (n == 0)
//        {
//            return i + 1;
//        }
//    }
//    return 0;
//}

//Console.WriteLine(NumberOfFloors(1000));


//4)Verilmiş artan sıra ilə düzülmüş ədədlər siyahısındaki n ədədinin yerləşdiryi indexi tapan alqoritm
// (meselen 50 axtaririq egər siyahıda 50 ədədi yoxdursa -1 print olsun, varsa var olduğu index)




//int FindNumInArray(int num,int[] arr)
//{
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (num == arr[i])
//        {
//            return i;
//        }
//    }
//    return -1;
//}

//Console.WriteLine(FindNumInArray(10, [1,2,3,4,5,6,7]));




//5)Verilmiş yazılar siyahısında verilmiş hərfdən neçə ədəd olduğunu tapan proqram.
//     Məs: "Hello World"-> 'l'-> 3(Boyukdu kicikdi nezere alinmir)

//int CountLetterL(string[] texts,char word)
//{
//    int count = 0;
//	foreach (var text in texts)
//	{
//		foreach (char letter in text)
//		{
//			if(letter ==word || letter == (char)(word - 32))
//			{
//				count++;
//			}
//		}
//	}
//	return count;
//}
//string[] array = { "salam", "Sagol", "Alma", "armud" };
//char letter = 'a';
//Console.WriteLine(CountLetterL(array,letter));



//6)Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən proqram 
//                          (Misalçün verilmiş yazı "   salam necesen?   "-dirsə yeni düzələcək string "salam necəsən?   " ) olmalıdır.


//string RemoveSentenceSpaces(string text)
//{
//    int index = 0;

//	while (index<text.Length && text[index] ==' ')
//	{
//		index++;
//	}

//	string result = "";

//	for (int i = index; i < text.Length; i++)
//	{
//		result += text[i];
//	}
//	return result;

//}

//string input = " salam necesen?";
//Console.WriteLine(RemoveSentenceSpaces(input));


//8)Verilmiş yazının içində A hərfinin olub olmadığını tapan proqram.


//bool StringOfLetter(string text)
//{
//	foreach (char item in text)
//	{
//		if (item == 'A')
//		{
//			return true;
//		}
//	}
//	return false;
//}

//string input = "Salam Aleykum";
//Console.WriteLine(StringOfLetter(input));



//9)Verilmiş ədədlər siyahısını içindəki bütün ədədlər kvadratına yüksəlmiş array-ə çevirən metod.

//int[] SquareOfArray(int[] array)
//{
//    int[] squaredArray = new int[array.Length];
//	for (int i = 0; i < array.Length; i++)                    // Bu suali hele kecmedik kecende yazariq
//	{
//		squaredArray[i] = array[i] * array[i];
//	}
//	return squaredArray;
//}



//10)Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram.


//int FindCharInString(string text)
//{
//    int count = 0;
//    for (int i=0; i<text.Length; i++)
//    {
//        if (text[i] == 'A')
//        {
//            count++;
//        }
//    }
//    return count;
//}
//Console.WriteLine(FindCharInString("sAlam"));


// Tasklar Practica


//1) method yazirsiz, hemin method gelen arrayin icindeki en boyuk reqemi tapib qaytarsin


//int FindMaxArr(int[] arr)
//{
//    int max = arr[0];
//    for (int i =1;  i <arr.Length; i++)
//    {
//        if (max < arr[i])
//        {
//            max = arr[i];
//        }
//    }
//    return max;
//}
//Console.WriteLine(FindMaxArr([1,2,3,4,5,6,2]));



//3) method yazirsiz, string qebul edecek, hemin method o stringi tersine cevirib qaytarmalidir.

//string GetString(string text)
//{
//    string res = "";
//	for (int i = text.Length-1;  i>=0;i--)
//	{
//		res += text[i];
//	}
//	return res;
//}
//Console.WriteLine(GetString("Salamlar"));


//4) method string qebul edir, (cumle), hemin method cumledeki sozlerin sayini qaytarsin.


//int GetOfCount(string sentences)
//{
//    int count = 0;
//    for (int i = 0; i < sentences.Length; i++)
//    {
//        if (sentences[i] != ' ' && (i == 0 || sentences[i - 1] == ' '))
//        {
//            count++;
//        }


//    }
//    return count;
//}
//Console.WriteLine(GetOfCount("salam 234sagol235"));


//5) method string qebul edir (reqemlerle qarisiq). hemin method o stringin icindeki reqemleri cixarib geri qaytarsin


//string FindNumsInText(string text)
//{
//    string result = "";
//    string nums = "1234567890";

//    for(int i = 0; i < text.Length; i++)
//    {
//        for (int j = 0; j < nums.Length; j++)
//        {
//            if (text[i] == nums[j])
//            {
//                result += text[i];
//            }

//        }

//    }
//    return result;

//}

//Console.WriteLine(FindNumsInText("salam12sagol34"));


//6) method gelen arrayin reqemlerinin ortalamasini qaytarsin.

//int AverageOfNums(int[]arr)
//{
//    int sum = 0;
//    int average = 0;
//    for(int i=0; i<arr.Length; i++)
//    {
//        sum += arr[i];
//    }
//    average = sum / arr.Length;
//    return average;
//}

//Console.WriteLine(AverageOfNums([1,2,3,4,5]));


//7) method gelen reqemin arrayda olub olmaidigini qaytarsin.

//bool ReturnArray(int a, int[] arr)
//{
//     for (int i = 0; i < arr.Length; i++)
//    {
//         if (arr[i] == a)
//        {
//            return true;
//        }
//    }
//    return false;
//}

//Console.WriteLine(ReturnArray(8,([1, 3, 6, 7])));

//8) method stringlerden ibaret array qebul edir, gelen stringin hemin arrayda  ne qeder tekrarlandigini tapin.



//int CountStringsInArray(string text, string[] text2)
//{
//    int count = 0;
//    for (int i = 0; i < text2.Length; i++)
//    {
//        if (text == text2[i])
//        {
//            count++;
//        }
//    }
//    return count;
//}
//Console.WriteLine(CountStringsInArray("salam",["salam", "salam", "are", "you"]));


//11)Verilmiş stringin Palindrome olub olmamağını yoxlayın.Eger soz palindromdursa mene 1 qaytarsin , palindrom deyilse 0 qaytarsin.

//int IsPalindrome(string text)
//{
//    int left = 0;
//    int right = text.Length - 1;
//    while (left<right)
//    {
//        if (text[left] != text[right])
//        {
//            return 0;
//        }
//        left++;
//        right--;
//    }
//    return 1;
//}

//string input = "radar";
//Console.WriteLine(IsPalindrome(input));


//12)Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq hala gətirən metod.
//       Misal olaraq, name = " Hikmet  Abbasov " deyə bir variable-mız varsa onu yaratdigimiz metoda göndərdikdə variable-daki dəyər "HikmətAbbasov" olmalıdır.


//string RemoveSpace(string word)
//{
//    string newWord = "";
//    for (int i=0;i<word.Length;i++)
//    {
//        if (word[i]!=' ')
//        {
//            newWord += word[i];
//        }
//    }
//    return newWord;
//}
//Console.WriteLine(RemoveSpace(" Hikmet Abbasov "));


//13)Verilmiş strigin ilk 4 hərfini ekrana yazdırın.Eger soz 4 herfden az olsa mesaj cixartmalisan.


//void FirstFour(string word)
//{
//    string s = "";

//    for(int i= 0; 4> i; i++)
//    {
//        if (4 > word.Length)
//        {
//            Console.WriteLine("4 simvoldan azdir");
//            return;
//        }
//        else
//        {
//            s += word[i];
//        }
//    }
//    Console.WriteLine(s);
//}


//FirstFour("sln");


//14)Verilmiş yazının ilk hərfini böyük qalanlarını kiçik edib qaytaran metod

//string FirstFourLettersInBig(string texts)
//{
//    char firstChar = texts[0];

//    if(firstChar >='a' && firstChar <= 'z')
//    {
//        firstChar = (char)(firstChar - 32);
//    }

//    string response = "";
//    for (int i = 1; i < texts.Length; i++)
//    {
//        char item = texts[i];
//        if(item>='A' && item <= 'Z')
//        {
//            item = (char)(item + 32);
//        }
//        response += item;
//    }
//    return firstChar + response;
//}

//string input = "salam NECESEN";
//Console.WriteLine(FirstFourLettersInBig(input));


//16)Fibonacci sequence(ardiciligi) algoritmi : 99 - a qeder.

//void Fibonacci(int t)
//{
//    int a = 0;
//    int b = 1;
//    Console.Write(a + " " + b + " ");
//    int sum = a + b;
//    while(sum < t)
//    {
//        Console.Write(sum + " ");
//        a = b;
//        b = sum;
//        sum = a + b;
//    }
//}
//Fibonacci(99);
















