using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     //Q1將指定文字內容存檔, 由於要存放的文字內容與檔案存放位置都會
    //變化, 所以我們可以將這兩項資訊設計成 method的參數, 由外界傳入
    //請設計一個FileManager class, 內含一個 Save method
     //只需要設定method, 不必實作出功能

    internal class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        static void Main(string[] args)
        {
            MyMethod();
            FileManager util = new FileManager();
            int result = util.Add(2,5);
        }
    }
    public class  FileManager
    {
        #region Methods

       public int Add(int num1, int num2)//倆數相加
        {
            return num1+num2;
        }

        #endregion Methods
    }


}
