namespace Bridge.Logic
{
    public class Bridges
    {
        private readonly string _bridge;

        public Bridges(String bridge)
        {
            _bridge = bridge;
        }
        public String ValidateBridge()
        {
            int countPlatform = 0;

            if (!(_bridge[0] == '*' && _bridge[_bridge.Length-1] == '*'))
            {
                return "Invalide Bridge";
            }
            for (int i = 1; i < _bridge.Length - 1; i++)
            {
                if (!(_bridge[i].Equals('=') || _bridge[i].Equals('+')))
                {
                    return "La viga esta mal construida!";
                }
            }
            for (int i = 1; i < _bridge.Length-1; i++)
            {
                if (!(_bridge[i].Equals(_bridge[_bridge.Length - i - 1])))
                {
                    return "La viga esta mal construida!";
                }
            }
            for (int i = 1; i < _bridge.Length - 1; i++)
            {
                if (_bridge[i].Equals('='))
                {
                    countPlatform++;
                    
                    if (countPlatform > 2)
                    {
                        if (!(i-1 == (int)(_bridge.Length/2)))
                        {
                            return "La viga esta mal construida, tiene mas plataformas!";
                        }                        
                    }
                }
                else
                {
                    countPlatform = 0;
                }  
            }
            return "Valid bridge";
            
        }
    }
}