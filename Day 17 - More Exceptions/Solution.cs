using System;

    class Calculator{

        public Calculator() {}

        public int power(int n, int p) {

            double num = n;
            double pwr = p;
            int result = 0;

            if ((n >= 0) && (p >= 0)) {
                result = (int)Math.Pow(num, pwr);
            }
            else throw new Exception("n and p should be non-negative");

            return result;
        }        
    }

class Solution{
    static void Main(String[] args){
        Calculator myCalculator=new  Calculator();
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]); 
            try{
                int ans=myCalculator.power(n,p);
                Console.WriteLine(ans);
            }
            catch(Exception e){
               Console.WriteLine(e.Message);

            }
        }
        
        
        
    }
}