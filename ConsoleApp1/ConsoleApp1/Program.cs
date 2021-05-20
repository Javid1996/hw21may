using System;

namespace ConsoleApp1
{
    public interface ITools
    {
        static public string KEY  = "C major";
        static public string KEY1 = "Bum-Bum";
        static public string KEY2 = "Too too roo";
        void Play()
        {

        }
       
    }

    class Guitar : ITools
    {
        public int strings { get; set; }
        public Guitar(int strings) 
        {
            this.strings = strings;
        }

        public void Play()
        {
            Console.WriteLine(" The Guitar with " + strings + " strings play " + ITools.KEY);
        }

    }

    class Drum : ITools
    {
        public string sizeOfDrum { get; set; }
        public Drum(string sizeOfDrum)
        {
            this.sizeOfDrum = sizeOfDrum;
        }

        public void Play()
        {
            Console.WriteLine( " The " + sizeOfDrum + " Drum plays " + ITools.KEY1);
        }
    }
    class Trumpet : ITools
    {
        public int diameterOfTrumpet { get; set; }
        public Trumpet(int diameterOfTrumpet)
        {
            this.diameterOfTrumpet = diameterOfTrumpet;
        }

        public void Play()
        {
            Console.WriteLine(" The Trumpet with " + diameterOfTrumpet + " centimeters in diameter plays " + ITools.KEY2);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Guitar guitar = new Guitar(7);
            Drum drum = new Drum("Big");
            Trumpet trumpet = new Trumpet(15);

          
            ITools[] instruments = new ITools [3];
            instruments[0] = new Guitar(7);
            instruments[1] = new Drum("Big");
            instruments[2] = new Trumpet(15);
           
            {
                foreach (ITools instrument in instruments)
                {
                    instrument.Play();
                }
                
            }
            Console.ReadKey();
            
        }

        //public static int InputNumber()
        //{
        //    for (; ; )
        //    {
        //        int result;
        //        string message = Console.ReadLine();
        //        if (Int32.TryParse(message, out result))
        //        {
        //            return result;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Enter number");
        //        }
        //    }
        //}


    }
    //class AddMethod
    //{
    //    ITools[] arr;
    //    public int Length;

    //    public AddMethod(int size)
    //    {
    //        arr = new ITools[size];
    //        Length = size;
    //    }

        
    //    public ITools this[int index]
    //    {
    //        set
    //        {
    //            arr[index] = value;
    //        }

    //        get
    //        {
    //            return arr[index];
    //        }
    //    }
    //}

}
