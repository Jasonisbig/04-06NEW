using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_06NEW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //04-02
            //string original = "banana";//建立了一個名為 original 的字串變數，並將它的初始值設為 "banana"。
            //original 現在存儲的值是 "banana"。
            //string copy = string.Copy(original); //建立了一個名為 copy 的字串變數，並通過 string.Copy 方法將 original 的值複製給它。
            //現在 copy 儲存的值也是 "banana"。
            //original = "orange";//這行將字串變數 original 的值改為 "orange"。
            //Console.WriteLine(original);//印出original
            //Console.WriteLine(copy);//印出copy
            //04-02使用情境:複製字串
            //string original = "Hello, World!";//這行程式碼創建了一個名為 original 的變數。它的值被設為 "Hello, World!"。
            //string copy = string.Copy(original);//使用了 string.Copy() 方法，從 original 字串生成一個新的字串副本。
            //Console.WriteLine($"Original: {original}");//輸出原始字串的值
            //Console.WriteLine($"Copy: {copy}");//輸出副本字串的值
            //05-01
            //string str2 = "Programming";//建立了一個名為 str 的字串變數，並將它的初始值設為 "Programming"。
            //bool result2 = str2.StartsWith("Pro");//這行使用 StartsWith 方法來檢查 str 是否以 "Pro" 開頭。
            //StartsWith 方法會返回一個布林值（bool），如果 str 以 "Pro" 開頭，result 將為 true；否則，它將為 false。
            //string output = result2 ? "字串以 'Pro' 開頭" : "字串不以 'Pro' 開頭";//這行使用條件運算符（?）來根據 result 的值決定 output 的內容。
            //如果 result 為 true，則 output 被賦值為 "字串以 'Pro' 開頭"；如果 result 為 false，則 output 被賦值為 "字串不以 'Pro' 開頭"。
            //Console.WriteLine(output); //這行將 output 的值輸出到控制台。
            //05-01StartsWith()用法舉例:判斷是否為網址
            //string url = "https://example.com";
            //if (url.StartsWith("https://"))
            //{
            //Console.WriteLine("This is a secure URL.");
            //}//判斷是否為"https://"，如果是輸出"This is a secure URL."
            //else if (url.StartsWith("http://"))
            //{
            //Console.WriteLine("This is an insecure URL.");
            //}//判斷是否為"http://"，如果是輸出"This is an insecure URL."
            //else
            //{
            //Console.WriteLine("This is not a valid URL.");
            //}//如兩個條件都不符合輸出"This is not a valid URL."
            //06-01
            //string str = "HelloWorld";//建立了一個名為 str 的字串變數，並將它的初始值設為 "HelloWorld"。
            //bool result = str.EndsWith("World");//這行使用 EndsWith 方法來檢查 str 是否以 "World" 結尾。
            //EndsWith 方法會返回一個布林值（bool），如果 str 以 "World" 結尾，result 將為 true；否則，它將為 false。
            //string output = result ? "字串以 'World' 結尾" : "字串不以 'World' 結尾";//這行使用條件運算符（?）來根據 result 的值決定 output 的內容。
            //Console.WriteLine(output); //這行將 output 的值輸出到控制台。
            //06-01EndsWith()用法舉例:檢查檔案副檔名
            //string fileName = "picture.jpg";
            //if (fileName.EndsWith(".pdf"))
            //{
            //Console.WriteLine("This is a PDF file.");
            //}//檢查副檔名是否為".pdf"是的話輸出"This is a PDF file."
            //else
            //{
            //Console.WriteLine("This is not a PDF file.");
            //}//如果副檔名不為".pdf"輸出"This is not a PDF file."
            //Console.ReadLine();//這行使程序暫停，等待使用者輸入，以便窗口不會立即關閉
        }
    }
}
