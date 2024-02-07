namespace TipStroki2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            /*
            int k = 0;
            string str = ("asd bdasfg abasd baweqwe btrret asd trw bewfdsf baser");
            if (str[0] == 'b')
                k++;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == 'b' && str[i - 1] == ' ')
                    k++;
            }
            Console.WriteLine("Количество слов начинающихся на b: " + k);
            Console.ReadKey();
            */
            #endregion 1

            #region 2
            /*
            string input = "C# — объектно-ориентированный язык программирования общего назначения. Разработан в 1998—2001 годах группой инженеров компании Microsoft под руководством Андерса Хейлсберга и Скотта Вильтаумота как язык разработки приложений для платформы Microsoft .NET Framework и .NET Core. Впоследствии был стандартизирован как ECMA-334 и ISO/IEC 23270.";
            string output = "-" + String.Join(" -", input.Split(' '));
            int len = output.Length;
            Console.WriteLine(output);
            Console.ReadKey();
            */
            #endregion 2
        }
    }
}
