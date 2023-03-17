namespace Beam.Logic
{
    public class Logic
    {
        private readonly string _txt;

        public Logic(string txt)
        {
            _txt = txt;
        }
        public String Validator()
        {

            if (!(_txt[0] == '%' || _txt[0] == '&' || _txt[0] == '#'))
            {
                return "La viga esta mal construida!";
            }

            for (int i = 1; i < _txt.Length ; i++)
            {
                if (!(_txt[i].Equals('=') || _txt[i].Equals('*')))
                {
                    return "La viga esta mal construida!";
                }
            }
            for (int i = 1; i < _txt.Length - 1; i++)
            {
                if (_txt[i].Equals('*') && _txt[i + 1].Equals('*'))
                {
                    return "La viga esta mal construida!";
                }

            }
            return "Beam correct";

        }
        public int BeamResistence()
        {
            int baseResistence = 0;
            int weigthBeam = 0;
            int count = 0;
            int TotalWeigth = 0;


            if (_txt[0] == '%')
            {
                baseResistence = 10;
            }
            if (_txt[0] == '&')
            {
                baseResistence = 30;
            }
            if (_txt[0] == '#')
            {
                baseResistence = 90;
            }

            for (int i = 1; i < _txt.Length - 1; i++)
            {
                if (_txt[i].Equals('='))
                {
                    count++;
                    weigthBeam += count;
                }
                else
                {
                    TotalWeigth += weigthBeam;
                    TotalWeigth += (weigthBeam * 2);
                    count = 0;
                    weigthBeam = 0;
                }
            }
            return baseResistence - weigthBeam;
        }

        public string ValidateResistence()
        {
            if (Validator().Equals("Beam correct"))
            {
                if (BeamResistence() < 0)
                {
                    return "La viga NO soporta el peso";
                }
                else
                {
                    return "La viga resiste!";
                }
            }
            return "";
            
        }

    }
}