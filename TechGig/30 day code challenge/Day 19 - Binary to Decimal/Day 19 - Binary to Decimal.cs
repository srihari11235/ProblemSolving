using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode {
    static void Main(String[] args) {
                           
            int binaryNumber = int.Parse(Console.ReadLine());
            int decimalValue = 0;
            int base1 = 1;
            
            while (binaryNumber > 0)
            {
                int reminder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            
            Console.Write(decimalValue);
    }
}
