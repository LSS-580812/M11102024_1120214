using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("學號：M11102024  姓名：劉順松");
            Console.WriteLine("1A2B猜數字");
            int playNum = 1;
            int sco = 1;
            Random random = new Random();
            string isPC = random.Next(0, 9999).ToString("0000");
            do
            {
                Console.WriteLine("\n{0},請玩家輸入4位數碼({1})：", sco, isPC); string playStr = Console.ReadLine();
                if (playStr.Length != 4)
                {
                    Console.WriteLine("輸入4位數碼有誤，是否重新輸入？(Y-再玩[重新輸入], N-遊戲結束)"); string IsReplay1 = Console.ReadLine();
                    if (IsReplay1 == "n" || IsReplay1 == "N")
                    {
                        break;
                    }
                }
                else
                {
                    if (isPC == playStr)
                    {
                        Console.WriteLine("恭喜你！猜對了！！，是否再玩一次？(Y-再玩一次, N-遊戲結束)"); string IsReplay2 = Console.ReadLine();
                        if (IsReplay2 == "n" || IsReplay2 == "N")
                        {
                            break;
                        }
                        playNum++; isPC = random.Next(0, 9999).ToString("0000");
                        Console.WriteLine("\n\n玩家第 {0} 次挑戰....開始{1}", playNum, isPC);
                    }
                    else
                    { //判斷結果
                        //char[] arrPlay = playStr.ToCharArray(); //字元陣列
                        int a = 0; int b = 0;
                        for (int i = 0; i < playStr.Length; i++)
                        {
                            string ab = playStr.Substring(i, 1); //Console.Write(ab);

                            for (int j = 0; j < isPC.Length; j++)
                            {
                                string pcAB = isPC.Substring(j, 1);
                                if (ab == pcAB)
                                {
                                    if (i == j)
                                    {
                                        a = a + 1;
                                    }
                                    else
                                    {
                                        b = b + 1;
                                    }
                                }
                            }
                        }
                        Console.WriteLine("判定結果是 {0}A {1}B", a, b);
                    }
                }

                sco++;

            } while (true);

            Console.WriteLine("遊戲結束，下次再來玩喔～");
            Console.ReadKey();
        }
    }
}
