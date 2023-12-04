namespace Strings.Logic
{
    public class MyString
    {
        private readonly string _text;

        public MyString(String text)
        {
            _text = text;
        }

        public bool Ispalindrome()
        {
            string Aux2=_text.ToLower();
            Aux2 = Aux2.Replace("ا", "a");
            Aux2 = Aux2.Replace("ح", "h");
            Aux2 = Aux2.Replace("م", "m");
            Aux2 = Aux2.Replace("د", "d");
            string Aux = string.Empty;
            for (int i = 0; i < Aux2.Length; i++)
            {
                if (!(Aux2[i] == (' ') || Aux2[i] == ('.') || Aux2[i] == ('!') || Aux2[i] == ('?')
                    || Aux2[i] == ('!') || Aux2[i] == '¡' || Aux2[i] == '!' || Aux2[i] == '\'' || Aux2[i] == '"'))
                    {
                    Aux += Aux2[i];
                    }
            }
            int n = Aux.Length / 2;
            for (int i = 0; i < n; i++)
            {
                if (Aux[i] != Aux[Aux.Length-i-1])
                {
                    return false;
                }
            }
            return true;

        }
    }
}
