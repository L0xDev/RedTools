using System;
using System.Collections.Generic;
using Sytem.Ling;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace dctool
{
    internal class NewBaseType
    {
        static void Banner() => Console.WriteLine("""
        
        

                                                                                          
88888888ba                       88     888888888888                       88             
88      "8b                      88          88                            88             
88      ,8P                      88          88                            88             
88aaaaaa8P'  ,adPPYba,   ,adPPYb,88          88   ,adPPYba,    ,adPPYba,   88  ,adPPYba,  
88""""88'   a8P_____88  a8"    `Y88          88  a8"     "8a  a8"     "8a  88  I8[    ""  
88    `8b   8PP"""""""  8b       88          88  8b       d8  8b       d8  88   `"Y8ba,   
88     `8b  "8b,   ,aa  "8a,   ,d88          88  "8a,   ,a8"  "8a,   ,a8"  88  aa    ]8I  
88      `8b  `"Ybbd8"'   `"8bbdP"Y8          88   `"YbbdP"'    `"YbbdP"'   88  `"YbbdP"'  
                                                                                          
                                                                                          


        """);
        static void Main(string[] args)
        {
            Console.Title = "dcrat";
            Console.ReadKey();
        }
    };

    internal class Program : NewBaseType
    {
    }
};