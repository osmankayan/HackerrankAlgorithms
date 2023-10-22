using System.Collections;
using System.Drawing;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;


public class Program
{
    public static void Main(string[] args)
    {
        #region compareTriplets
        //List<int> list1 = new List<int>() {5,6,7};
        //List<int> list2 = new List<int>() {3,6,10};
        //List<int> list3 = compareTriplets(list1, list2);
        //foreach (int i in list3) 
        //{
        //    Console.WriteLine(i);
        //}
        #endregion

        #region PlusMinus
        //List<int> list = new List<int>() { -4, 3, -9, 0, 4, 1 };
        //plusMinus(list);
        #endregion

        #region miniMaxSum
        //List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
        //miniMaxSum(list);
        #endregion

        #region timeConversion
        //string s = "06:40:03AM";
        //timeConversion(s);
        #endregion

        #region lonelyinteger
        //List<int> list = new List<int>() {1,2,3,4,3,2,1};

        //Console.WriteLine(lonelyinteger(list));

        #endregion

        #region diagonalDifference
        //List<int> list = new List<int>() {11,2,4 };
        //List<int> list2 = new List<int>() {4,5,6 };
        //List<int> list3 = new List<int>() {10,8,-12 };
        //List<List<int>> bList = new List<List<int>>() { list,list2,list3};
        //diagonalDifference(bList);
        #endregion

        #region countingSort

        //List<int> list = new List<int>() { 63, 25, 73, 1, 98, 73, 56, 84, 86, 57, 16, 83, 8, 25, 81, 56, 9, 53, 98, 67, 99, 12, 83, 89, 80, 91, 39, 86, 76, 85, 74, 39, 25, 90, 59, 10, 94, 32, 44,
        //    3, 89, 30, 27, 79, 46, 96, 27, 32, 18, 21, 92, 69, 81, 40, 40, 34, 68, 78, 24, 87, 42, 69, 23, 41, 78, 22, 6, 90, 99, 89, 50, 30, 20, 
        //    1, 43, 3, 70, 95, 33, 46, 44, 9, 69, 48, 33, 60, 65, 16, 82, 67, 61, 32, 21, 79, 75, 75, 13, 87, 70, 33 };
        //countingSort(list);
        #endregion

        #region caesarCipher
        //caesarCipher("middle-Outz", 2);
        #endregion

        #region gridChallange

        //List<string> list = new List<string>() {"bac","ade","efg"};

        //gridChallenge(list);
        #endregion

        #region superDigits
        //superDigit("1717", 2);
        //SuperDigit2("9875", 4);
        #endregion

        int[] a = { 5, 2, 5, 1, 6, 0 };
        List<int> b = new List<int>();
        for (int i = 0; i < a.Length; i++)
        {
            b.Add(a[i]);
        }
        b.Sort();


        Console.ReadLine();
    
    }

   


    ////////////////////////////////////////////////////////////////

    #region superDigits
    public static int superDigit3(string n, int k)
    {
        //burası hatalı çarma değil k kadar n eklenecek, düzelt.
        BigInteger concatenatedValue = BigInteger.Parse(n) * k;


        while (concatenatedValue >= 10)
        {
            BigInteger newSum = 0;
            while (concatenatedValue > 0)
            {

                newSum += concatenatedValue % 10;
                concatenatedValue /= 10;
            }
            concatenatedValue = newSum;
        }


        return (int)concatenatedValue;
    }
    public static int SuperDigit2(string n, int k)
    {
        // n dizesini k kez yan yana getirin
        string concatenatedString = string.Concat(Enumerable.Repeat(n, k));
        
        int sum = 0;

        // Dize üzerinde doğrudan işlem yaparak rakamları toplayın
        foreach (char digit in concatenatedString)
        {
            int numericValue = Convert.ToInt32(digit.ToString()); // Karakteri sayıya dönüştür
            sum += numericValue; // Sayıyı toplama ekler
        }

        // Eğer toplam 10 veya daha büyükse, rekürsif olarak hesapla
        if (sum >= 10)
        {
            return SuperDigit2(sum.ToString(), 1); // 1 kez daha hesapla
        }
        Console.WriteLine(sum);

        return sum;
    }
    public static int superDigit(string n, int k)
    {
        double returned = 0;
        double sum = 0;
        string sb = "";
        //StringBuilder sb = new StringBuilder();
        for (int i = 0; i < k; i++) 
        {
           sb += n;
            //sb.Append(n); 
        }
        //foreach (char digit in sb)
        //{
        //    int numericValue = Convert.ToInt32(digit.ToString());
        //    sum += numericValue;
        //}

        for (int i = 0; i < sb.Length; i++)
        {
            int numericValue = Convert.ToInt32(sb[i].ToString());
            sum += numericValue;


            //sum += char.GetNumericValue(sb[i]);

        }
        if (sum < 10)
        {
            returned = sum;
        }
        if (sum > 10)
        {
            string sb2 = sum.ToString();
            double sum2 = 0;
            for (int j = 0; j < sum.ToString().Length; j++)
            {
                sum2 += char.GetNumericValue(sb2[j]);
            }
            sum = sum2;


            if (sum > 10)
            {
                string sb3 = sum.ToString();
                double sum3 = 0;
                for (int r = 0; r < sb3.Length; r++)
                {

                    sum3 += char.GetNumericValue(sb3[r]);
                }
                sum = sum3;

            }
        }

        Console.WriteLine(sum);
        int returned2=Convert.ToInt32(returned);

        return returned2;
    }
    #endregion

    ////////////////////////////////////////////////////////////////

    #region gridChallange
    //Sample testlerde ilginç değerler girildiği için program hackeerankta bazı test caselerde patladı, tek matrix girilmiyor 2 3 giriliyor ve patlıyor. algoritma bunun için dizayn edilmedi
    public static string gridChallenge(List<string> grid)
    {
       
        string yesOrNo = "YES";
        List<char> charList1 = new List<char>();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < grid.Count; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                sb.Append(grid[j][i]);
            }
            sb.Append('.');
        }
        string s1=sb.ToString();
       s1= s1.Remove(s1.Length-1,1);
        
        List<string> stringList = new List<string>(s1.Split('.'));

        string originalAlphabet = "abcdefghijklmnopqrstuvwxyz";

        Hashtable ht = new Hashtable();

        for(int i = 0; i < originalAlphabet.Length; i++) 
        {
            ht.Add(originalAlphabet[i],i);
        }

        for (int i = 0; i < stringList.Count; i++)
        {

            for (int j = 0; j < stringList[i].Length-1; j++)
            {
                if (Convert.ToInt32( ht[stringList[i][j]]) > Convert.ToInt32( ht[stringList[i][j+1]])) 
                {
                    yesOrNo = "NO";
                }
            }
        }

        Console.WriteLine(ht);
        return "a";
    }
    #endregion

    ////////////////////////////////////////////////////////////////

    #region caesarCipher(Baya uzun incele)
    public static string caesarCipher(string s, int k)
    {
        Hashtable alphabet = new Hashtable();
        string originalAlphabet = "abcdefghijklmnopqrstuvwxyz";
        char swap = ' ';
       
        //rotasyona uğramış alfabe
       var a= originalAlphabet.ToCharArray();
        for (int j = 0; j< k; j++)
        {
            
            swap = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                
                a[i - 1] = a[i];
            }
            a[a.Length - 1] = swap;
        }
       
        for (int i = 0;i< a.Length; i++) 
        {
            alphabet.Add(originalAlphabet[i], a[i]);
        }
        string toLower=s.ToLower();
        var input=s.ToCharArray();
        
        for (int i = 0; i < input.Length; i++)
        {
            if (alphabet.ContainsKey(input[i]) ) 
            {
                char deneme = input[i];
                
                input[i] =(char)alphabet[input[i]];
            }
            else if (char.IsUpper(input[i])  ) 
            {
                
                string c1= input[i].ToString().ToLower();
                char c2 = char.Parse(c1);

               if(alphabet.ContainsKey(c2)) 
                {
                    
                    char c3= (char)alphabet[c2];
                    string c4=c3.ToString().ToUpper();
                    char c5=char.Parse(c4);
                    input[i] = c5;
                }
            }
        }
        string result=new string(input);
        
        
        Console.WriteLine(result);

        return "a";
    }
    #endregion 

    ////////////////////////////////////////////////////////////////

    #region flippingMatrix??????
    public static int flippingMatrix(List<List<int>> matrix)
    {
        int queryLength = matrix[0].Count() - 1;
        int halfQueryLength = (matrix[0].Count() / 2) - 1;
        int maxSum = 0;
        for (int row = 0; row <= halfQueryLength; row++)
        {
            for (int col = 0; col <= halfQueryLength; col++)
            {
                var counter = new List<int>(){
            matrix[row][col],
            matrix[row][queryLength - col],
            matrix[queryLength - row][col],
            matrix[queryLength - row][queryLength - col],
         };
                maxSum += biggerNumber(counter);
            }
        }
        return maxSum;
    }

    public static int biggerNumber(List<int> numberList)
    {
        int bigger = 0;
        foreach (var num in numberList)
        {
            bigger = Math.Max(bigger, num);
        }
        return bigger;
    }
    #endregion
   
    ////////////////////////////////////////////////////////////////

    #region countingSort
    //AÇIKLAMA

    //Yeni bir liste oluşturup ilk alınan listedeki elemanlar geçtikçe o listeden aynı indeksi bir arttırarak yapılan bir sıralama metodu(?)
    //beklenen outuo 0 0 0 1 0 2 0 3 0 2 1 0 0 şeklindedir.
    public static List<int> countingSort(List<int> arr)
    {
        int[] cont = new int[100];

        foreach (var num in arr)
        {
            cont[num] += 1;
        }

        return cont.ToList();
    }
    #endregion

    ////////////////////////////////////////////////////////////////

    #region diagonalDifference
    //AÇIKLAMA

    //matrix'te sol yukarıdan capraz asagı ve sag yukarıdan capraz asagı sayıların toplamının birbirinden çıkarılmasının mutlak değeri isteniyor.
    public static int diagonalDifference(List<List<int>> arr)
    {
        int sum1 = 0;
        int sum2 = 0;
        int reversed = arr.Count-1;
        for (int a=0;a<arr.Count; a++)
        {
                sum1 += arr[a][a]; 
            sum2 += arr[a][reversed];
            reversed--;
        }
        
       
        return Math.Abs(sum1-sum2);
    }
    #endregion


    ////////////////////////////////////////////////////////////////

    #region lonelyinteger
    //AÇIKLAMA

    //benzersiz integer'ı bul.
    public static int lonelyinteger(List<int> a)
    {
        int lonelyNumber = 0;
        foreach (var item in a)
        {
            int count = a.Where(x => x == item).Count();
           if (count == 1) { lonelyNumber = item; }
        }
        return lonelyNumber;
    }
    #endregion


    ////////////////////////////////////////////////////////////////

    #region timeConversion
    // AÇIKLAMA

    // 12'lik saat dilimleri veriliyor. bunları 24lük dilime dönüştürüyoruz.


    public static string timeConversion(string s)
    {
        int hours = Convert.ToInt32( s.Substring(0, 2));
        string amOrPm = s.Substring(8,2);
        string convertedTime = "";

        if (amOrPm == "AM") 
        {
            if(hours ==12){
               
                hours = 0;
                convertedTime = hours.ToString()+0 + s.Substring(2, 6);

            }
            if (hours < 10) 
            {
                convertedTime=0 + hours.ToString() + s.Substring(2, 6);
            }
            
           
        }
        else if (amOrPm == "PM") 
        {
            if (hours != 12) 
            {
                hours = hours + 12;
            }
            convertedTime = hours.ToString() + s.Substring(2, 6);
        }


        return convertedTime;
    }
    #endregion

    ////////////////////////////////////////////////////////////////

    #region miniMaxSum
    //AÇIKLAMA

    //verilen listedeki 5 sayı içerisinden toplamı en kucuk ve en buyuk olacak 4 sayıyı bulup toplayıp minimum ve maksımumu yanyana yazdır.
    //sum değerlerini int'da tuttugum zaman büyük sayılarda patladı,dikkatli ol.
    public static void miniMaxSum(List<int> arr)
    {
        arr.Sort();
        long minSum = 0, maxSum=0;
        for (int i=0;i<arr.Count-1;i++) 
        {
            minSum += arr[i];
        }
        arr.Reverse();
        for (int i = 0; i < arr.Count - 1; i++)
        {
            maxSum += arr[i];
        }
        Console.WriteLine(minSum.ToString()+" "+maxSum.ToString());

    }
    #endregion

    ////////////////////////////////////////////////////////////////

    #region PlusMinus
    //AÇIKLAMA

    //inputtan aldıgım sayıları pozitif,negatif,sıfır olmasına gore oranlayarak output ver
    //input { -4, 3, -9, 0, 4, 1 }
    //output 0.50000,0.333333,0.166667 gibi
    // yani 3/6       2/6      1/6
    public static void plusMinus(List<int> arr)
    {



        int countPositives = 0, countNegatives = 0, countZeros = 0;


        foreach (var item in arr)
        {
            if (item > 0) { countPositives++; }
            else if (item < 0) { countNegatives++; }
            else { countZeros++; }
        }
        //yakaladıgım sayıların noktasının ardından 6 devam etmesını ıstedım ancak 0.500000 sonucunu alamadım ditek 0.5 oalrak verdi
        decimal ratioPositives =Math.Round(Convert.ToDecimal(countPositives) / Convert.ToDecimal(arr.Count()),6);
        decimal ratioNegatives =Math.Round(Convert.ToDecimal(countNegatives) / Convert.ToDecimal(arr.Count()),6);
        decimal ratioZeros =Math.Round(Convert.ToDecimal(countZeros) / Convert.ToDecimal(arr.Count()),6);
        //stringe cevırmemnın ardından "f6" formatı ısımı gordu.
        string a = ratioPositives.ToString("f6");
        string b = ratioNegatives.ToString("f6");
        string c = ratioZeros.ToString("f6");
        
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        



        
        
    }
    #endregion

    ////////////////////////////////////////////////////////////////


    #region compareTriplets
    //AÇIKLAMA

    //2 liste al. elemanlarını tek tek kıyasla ve bir eleman diğerinden büyük oldukca 1,2,3 diye rakamı arttır. en son durumu bir listeye at ve döndür.
    //    a = [1, 2, 3]
    //    b = [3, 2, 1]
    //    For elements *0*, Bob is awarded a point because a[0] .
    //For the equal elements a[1] and b[1], no points are earned.
    //Finally, for elements 2, a[2] > b[2] so Alice receives a point.
    //The return array is [1, 1] with Alice's score first and Bob's second.
   
    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        List<int> result = new List<int>();
        int countA = 0; 
        int countB=0;

        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
            {
                countA++;
            }
            else if (a[i] < b[i])
            {
                countB++;
            }
            
        }
        result.Add(countA);
        result.Add(countB);

        
        
        
        
        return result;
    }
    #endregion

    ////////////////////////////////////////////////////////////////




}