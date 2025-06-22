using System;

namespace q1{
    //singleton class
    public class Logger{
        private static Logger instance;

        //private constructor
        private Logger(){
            Console.WriteLine("Logger has been instantiated");
        }

        //public static method to get the instance
        public static Logger Instance(){
            if (instance == null){
                instance = new Logger();
            }

            return instance;
        }

        public void log_message(string message){
            Console.WriteLine(message);
        }
    }


    class Program{
            static void Main(String[] args){
                Logger log1 = Logger.Instance();
                Logger log2 = Logger.Instance();

                //verifying if the instanecs are the same
                if (log1 == log2){
                    Console.WriteLine("Same Instances are created across the application. Singleton.");
                }else{
                    Console.WriteLine("Not singleton.");
                }
            }
    }

}

