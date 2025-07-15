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
//    while (sum < t)
//    {
//        Console.Write(sum + " ");
//        a = b;
//        b = sum;
//        sum = a + b;
//    }
//}
//Fibonacci(99);



//================================================================================ 15.07.2025 =========================================


//18)"Orfoqrafiya" sozunde her herfden nece dene oldugu cixsin.

//void CountLettersInWord(string text)
//{
//    string checkedLetters = "";
//    for (int i = 0; i < text.Length; i++)
//    {
//        char current = text[i];
//        bool alreadyCheck = false;

//        for (int j = 0; j < checkedLetters.Length; j++)
//        {
//            if (checkedLetters[j] == current)
//            {
//                alreadyCheck = true;
//                break;
//            }
//        }

//        if (!alreadyCheck)
//        {

//            int count = 0;

//            for (int k = 0; k < text.Length; k++)
//            {
//                if (text[k] == current)
//                {
//                    count++;
//                }

//            }
//            Console.WriteLine($"{current} herfi {count} dene var");
//            checkedLetters += current;
//        }
//    }
//}

//string imput = "Salamlas";
//CountLettersInWord(imput);





//19)Verilmiş email dəyərinin domain hissəni qaytaran metod 
//                     (test@code.edu.az email-i daxil edilsə code.edu.az hiss'sini qaytarmalıdır)


//void FindDomainInEmail(string mail) 
//{
//    char domain = '@';
//    int index = 0;

//    for(int i = 0; i < mail.Length; i++)
//    {
//        if (mail[i] == domain)
//        {
//            index = i;
//        }
//    }

//    for(int i = index+1; i < mail.Length; i++)
//    {
//        Console.Write(mail[i]);
//    }


//}
//FindDomainInEmail("emil@code.edu.az");




//20) Verilmiş tam ədədlərdən ibarət bir array verilir. Bu massivdəki yalnız müsbət ədədlər arasından:
//         Rəqəmlərinin cəmi cüt olan ədədləri tap və onların cəmini hesabla (cutCem).
//         Rəqəmlərinin cəmi tək olan ədədləri tap və onların cəmini hesabla (tekCem).

//Misal : int[] arr = { 12, -7, 13, 28, 5, 30 };
//12-- > 1 + 2 = 3(tek)-- > tekcem += 12
//       13-- > 1 + 3 = 4(cut)-- > cutcem += 13
//       28-- > 2 + 8 = 10(cut)-- > cutcem += 28
//       5-- > 5(tek)-- > tekcem += 5

//tekcem = 12 + 5 = 17


//void EvenOrOdd(int[] arr)
//{
//    string oddNum = "Tek";
//    string evenNum = "Cut";
//    int sumEven = 0;
//    int sumOdd = 0;
//    int res = 0;

//    for(int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] > 0)
//        {
//            int res2 = arr[i] / 10;
//            int res3 = arr[i] % 10;
//            res = res2 + res3;

//            if (res % 2 == 0)
//            {
//                Console.WriteLine($"{res}  {evenNum}");
//                sumEven += res;
//            }
//            else
//            {
//                Console.WriteLine($"{res}  {oddNum}");
//                sumOdd += res;
//            }


//        }

//    }

//    Console.WriteLine($"Cut ededlerin cemi={sumEven}");
//    Console.WriteLine($"Tek ededlerin cemi={sumOdd}");

//}

//EvenOrOdd([137]);



//21)Parameter olaraq integer array variable-i ve bir integer value qebul eden ve hemin integer value-nu integer array-e yeni element kimi elave eden metod. 
//   Misal üçün int[] nums = { 1,5,7}
//deyə bir variable-mız var.yazdığımız metodu çağırıb arqument olaraq nums və 3 göndərsək nums 
//                                                                                         arrayının dəyəri  {1,5,7,3} olmalıdır.


//void AddedArray(int added, int[] arr)
//{
//    int[] nums = new int[arr.Length + 1];
//    for (int i = 0; i < arr.Length; i++)
//    {
//        nums[i] = arr[i];
//    }
//    nums[nums.Length - 1] = added;
//    Console.WriteLine(string.Join("," ,nums));
//}
//AddedArray(5, [1, 2, 3, 4]);



//22)int tipindən bir array olur içində müsbət və mənfi ədədlər olur elə bir method yazın ki, bu array-i parametr olaraq qəbul etsin 
//        və qəbul etdiyi array-in əvvəlcədən  ədədləri müsbətə çevirib 
//                                                                                                    həmin array-i geriyə qaytarsın




//void IsNegative(int[] numbers)
//{
//    for (int i = 0; i < numbers.Length; i++)
//    {
//        if (numbers[i] < 0)
//        {
//            numbers[i] = -numbers[i];
//        }
//        else
//        {
//            numbers[i] = numbers[i];
//        }
//    }
//    Console.WriteLine(string.Join(",", numbers));
//}
//IsNegative([1, 2, -3, -4, 5, 6]);



//24)Verilmis sozun ilk 2 ve son 2 herfinin beraberdirse outputda "beraber" deyilse "beraber deyil
//     yazilsin uzunluqu 4 den azdirsa Console "someting went wrong" yazilsin;

//Meselen: mexonicome-- > ilk iksi "me" son 2 si "me" beraberdirler:
// me  xonico      me


//void EqualOrNot(string word)
//{
//    if (word.Length<4)
//    {
//        Console.WriteLine("Something went wrong");
//    }
//    else
//    {
//        if (word[0] == word[word.Length-2] && word[1] == word[word.Length-1])
//        {
//            Console.WriteLine("beraber");
//        }
//        else
//        {
//            Console.WriteLine("beraber deyil");
//        }
//    }
//}
//EqualOrNot("mexanicome");


//29)Arrayda en boyuk 5-e bolunen tek ededi tapin;

//{ 5,12,17,19,23,25,30,20}
//resoult->25

//int NumberOfDivideFive(int[] array)
//{
//    int result = 0;
//	for (int i = 0; i < array.Length; i++)
//	{
//		if (array[i] > result && array[i] %5==0&& array[i] % 2 == 1)
//		{
//			result = array[i];
//		}
//	}
//	return result;
//}

//int[] array = { 5, 12, 17, 19, 23, 155, 30, 200 };
//Console.WriteLine(NumberOfDivideFive(array));



























