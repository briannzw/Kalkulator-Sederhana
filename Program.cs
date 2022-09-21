namespace TugasIndividu{
    class Program{
        static void CetakInstruksi(){
            Console.WriteLine("Masukkan operasi yang ingin Anda lakukan");
            Console.WriteLine("Input 1 untuk Penambahan");
            Console.WriteLine("Input 2 untuk Pengurangan");
            Console.WriteLine("Input 3 untuk Perkalian");
            Console.WriteLine("Input 4 untuk Pembagian");

            Console.WriteLine();
        }

        static double toNumeric(string? s){
            double n;
            if(double.TryParse(s, out n)) return n;
            
            return double.NaN;
        }

        static void InvalidInput(){
            Console.WriteLine("Input invalid. Press ENTER to exit...");
            Console.ReadLine();
            Console.Clear();
            Environment.Exit(1);
        }

        static double ReadNum(){
            string? input = Console.ReadLine();
            double n = toNumeric(input);
            if(!double.IsNaN(n)){
                return n;
            }
            
            InvalidInput();
            return 0;
        }

        static void Main(string[] args){
            CetakInstruksi();

            double input1 = 0, input2 = 0;
            string? inputString = Console.ReadLine();
            double inputNum = toNumeric(inputString);
            if(!double.IsNaN(inputNum)){
                if((inputNum < 1) || (inputNum > 4)){
                    InvalidInput();
                }
            }
            else InvalidInput();

            Console.WriteLine("Masukkan input ke-1");
            input1 = ReadNum();
            Console.WriteLine("Masukkan input ke-2");
            input2 = ReadNum();

            double result = 0;
            switch(inputNum){
                case 1 : {
                    result = input1 + input2;
                    break;
                }
                case 2 : {
                    result = input1 - input2;
                    break;
                }
                case 3 : {
                    result = input1 * input2;
                    break;
                }
                case 4 : {
                    result = input1 / input2;
                    break;
                }
                default : {
                    InvalidInput();
                    break;
                }
            }
            Console.WriteLine("Hasilnya adalah " + result.ToString());
        }
    }
}