//'TASK-1.   daxil edilen 3reqemli ededleri teklik,onluq,yuzluklere ayirsin

//Console.WriteLine("reqem daxil edin");
//Evvele:
//int numberConvert = Convert.ToInt32(Console.ReadLine());

//532

//if (numberConvert > 999 || numberConvert < 100)
//{
//    Console.WriteLine("100 ile 999 arasinda reqem secin");
//    goto Evvele;


//}
//int yuzluk = numberConvert / 100;
//int onluq = (numberConvert % 100) / 10;
//int teklik = (numberConvert % 100) % 10;

//Console.WriteLine(yuzluk + "yuzluk\n" + onluq + "onluq\n" + teklik + "teklik");



//500 yazanda 0 teklik ve 0 onluq yazmasin


//Task 2  daxil edilen ededin sade eded olub olmamasi
//Evvele:

//Console.WriteLine("reqem daxil edin");
//int ededConvert=Convert.ToInt32(Console.ReadLine());

//int checkNumber = ededConvert % 2;

//if (checkNumber == 0)
//{
//    Console.WriteLine("bu eded sade eded deyil");
//    goto Evvele;
//}

//Console.WriteLine(ededConvert);




//Task-3  daxil edilen 3 reqemin en boyuk ve en kiciyin cemi
//Console.WriteLine("Nece element");
//int elementsCount=int.Parse(Console.ReadLine());
//int[] massiv=new int[elementsCount];
//for(int i=0; i<massiv.Length; i++)
//{
//    Console.WriteLine("Massiv elementi nomre"+""+i);
//    massiv[i]=int.Parse(Console.ReadLine());
//}

//int a = massiv.Max();
//int b = massiv.Min();
//Console.WriteLine(a+b);




//Task-4  
//axirincidan basqa digerlerinde bosluq qoysun

//string[] myArr = { "hello", "world", "this", "is", "great" };

//string cumle = "";

//for (int i = 0; i < myArr.Length; i++)
//{
//    if (i != myArr.Length - 1)
//    {
//        cumle += myArr[i]+" ";
//    }
//    else
//    {
//        cumle+=myArr[i];
//    }

//}

//Console.WriteLine(cumle);

//=> returns "(123) 456-2383"

//int[] numbers = {1,2,3, 4,5,6,7,8,9,0};
//string phoneNumbers =" ";

//for (int i = 0; i < numbers.Length; i++)
//{
//    phoneNumbers += numbers[i];
//}
////int number=Convert.ToInt32(phoneNumbers);

////Console.WriteLine(number.ToString("(###) ###-####"));


//Console.WriteLine(long.Parse(string.Concat(numbers);


//string words = "asdhhask";
//string word = "asdhhaskb";
//int count=string.Compare(words, word);


//Console.WriteLine(count);


//var result=Math.Pow(1.02, 16);
//Console.WriteLine(result);


//*************************************************************************

//int seconds = 3720;

//int hour = (seconds / 60) / 60;
//int minute = (seconds / 60) / -(hour*60);
//int second = (seconds - (60 * 60) % 60);


//Console.WriteLine(hour+"saat :"+minute+"deqiqe :"+second);


/////////////////////////////////////


//Random rnd=new Random();

//int random = rnd.Next(10);

//int inoutNumber=Convert.ToInt32(Console.ReadLine());
//int counter = 0;

//while (true)
//{
//    counter++;
//    random= rnd.Next(10);
//    if (inoutNumber == random)
//    {
//        break;
//    }

//}

//Console.WriteLine(inoutNumber+"reqemi"+counter+"defeye tapildi");


//daxil edilen 3 dene reqemin her birini nece defeye tapar

//int[] numbers = new int[3];
//for(int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine((i+1)+" .reqem daxil edin :");
//    numbers[i] =Convert.ToInt32(Console.ReadLine());
//}


//Random rnd = new Random();
//int random = rnd.Next(10);
//for (int i = 0; i < numbers.Length; i++)
//{
//    int counter = 0;

//    while (true)
//    {
//        counter++;  
//        random = rnd.Next(10);
//        if (random == numbers[i])
//        {
//            break;
//        }
//    }
//    Console.WriteLine(numbers[i] +""+ "reqemi " + counter + " "+"defeye tapildi ");
//}



//int x = 2;
//int n = 5;

//List<int> list = new List<int>();
//for (int i = 1; i <=n; i++)

//    list.Add(x*i);


//list.ToArray();

//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}





//Random rnd=new Random();
//int random = rnd.Next(100);

//int can = 5;

//Console.WriteLine(random);
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("reqem daxil edin");
//    int number = Convert.ToInt32(Console.ReadLine());

//    if (number > random)
//    {
//        can--;
//        Console.Clear();
//        Console.WriteLine("asagi reqem secin");
//    }

//    else if(number < random)
//    {
//        can--;
//        Console.Clear();

//        Console.WriteLine("yuxari qlax");
//    }

//    else
//    {
//        Console.Clear();
//        Console.WriteLine("duzgun tapdiniz");
//        break; 
//    }
//}

//if (can == 0)
//{
//    Console.WriteLine("game over");
//}
//else
//{
//    Console.WriteLine("siz oyunu "+ can +" can ile bitirdiniz");
//}




//string commnet = "https://www.codewars.com/dashboard";

//if (commnet.Contains("https://") || commnet.Contains("www."))
//{
//    Console.WriteLine("bu span mesajidi");
//}
//else
//{
//    Console.WriteLine(commnet);
//}


//List<string> email =new List<string>();


//enubled true=false 


//14.05.22


//int number = 23;

//string result = "";
//res=10011

//string ReversResult(string res)
//{
//    string reverseResult = "";
//    for (int i = res.Length-1; i>=0 ; i--)
//    {
//        reverseResult += res[i];//11001
//    }
//    return reverseResult;
//}

//while (true)
//{
//    result+=(number%2).ToString();
//    number=number/2;

//    if (number == 1)
//    {
//        result += 1;
//        break;
//    }
//}
//Console.WriteLine(result);
//Console.WriteLine(ReversResult(result));



//verilmis massivde en boyuk ve en kicik element istisna olmaqla digerlerinin cemini tapin
//int[] numbers = { 5, 3, 3, 9, 10 };
//int cem = 0;
////3 ve 10 istisna olmaqla

//for (int i = 0; i < numbers.Length; i++)
//{
//    var min = numbers.Min();
//    var max = numbers.Max();
//    if (numbers[i] != min && numbers[i] != max)
//    {
//        cem = cem + numbers[i];
//        Console.WriteLine(cem);
//    }
//}


///
//string words = "Dermatoglyphics";

//string checkWord = "";
//for (int i = 0; i < words.Length; i++)
//{
//    checkWord += words[i];
//	for (int j = 0; j < words.Length; j++)
//	{
//		if (words[i] == words[j])
//		{
//			Console.WriteLine("False");
//		}
//		else
//		{
//			Console.WriteLine("True");
//		}
//	}
//}

//******************************
//cutleri yerinde saxlamaqla tekleri artan sira ile duzsun

//int[] arr = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
//List<int> odd = new();
//List <int> result = new();
//for (int i = 0; i < arr.Length; i++)
//{
//    if(arr[i] % 2 != 0)
//    {
//        odd.Add(arr[i]);
//    }

//}
//var sortOdd = odd.OrderBy(i => i);
//int skipCount=0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 != 0)
//    {
//        for (int j = 0; j < 1; j++)
//        {
//            var findOdd = sortOdd.Skip(skipCount).FirstOrDefault();
//            result.Add(findOdd);
//            skipCount++;
//        }

//    }
//    else
//    {
//        result.Add(arr[i]);
//    }
//}

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//in other way
//Queue<int> odds = new Queue<int>(array.Where(e => e % 2 == 1).OrderBy(e => e));
//return array.Select(e => e % 2 == 1 ? odds.Dequeue() : e).ToArray();



