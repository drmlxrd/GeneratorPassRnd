// See https://aka.ms/new-console-template for more information


    class PassGet
    {
    public string GetPass(int col)
    {
        int[] PassArr = new int[col];
        Random rnd = new Random();
        string Passwd = "";

        for (int i = 0; i < PassArr.Length; i++)
        {
            PassArr[i] = rnd.Next(50, 100);
            Passwd += (char)PassArr[i];
        }
         return Passwd;

        }
    }

    class Program 
    { 
        static void Main()
        {
         Console.WriteLine("Какой длинны вы хотите пароль?");
         PassGet ObjPass = new PassGet();
         int MaxPass = Convert.ToInt32(Console.ReadLine());
         string Passwd = ObjPass.GetPass(MaxPass);
         Console.Clear();
         Console.WriteLine("Пароль: {0}", Passwd);
         Console.ReadLine();

        }




    }

