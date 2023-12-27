namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string _numero;             
        private string _modelo;
        private string _imei;
        private int _memoria;

        public string Numero { 
            get => _numero;
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O número precisa ser preenchido.");
                }
                _numero = value;
            }
        }
        private string Modelo { 
            get => _modelo;
            set {
                if(value == "")
                {
                    throw new ArgumentException("O modelo precisa ser preenchido.");
                }
                _modelo = value;
            }
         }
        private string Imei { 
            get => _imei;
            set {
                if(value == "")
                {
                    throw new ArgumentException("O imei precisa ser preenchido.");
                }
                _imei = value;
            }
        }
        private int Memoria {
            get => _memoria; 
            set 
            {
                if(value.ToString() == "")
                {
                    throw new ArgumentException("A memoria precisa ser preenchida.");
                }
                _memoria = value;
            }
        }


        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Memoria = memoria;
            Imei = imei; 
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
        
        public abstract void InstalarAplicativo(string nomeApp);
    }
}