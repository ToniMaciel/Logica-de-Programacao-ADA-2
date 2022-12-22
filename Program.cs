using System;
using System.Diagnostics; 

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.Assert(10 == funcaoRetornaQuantitadePOV(0.1M, 90));
            Debug.Assert(11 == funcaoRetornaQuantitadePOV(0.1M, 100));
            Debug.Assert(17 == funcaoRetornaQuantitadePOV(0.2M, 70));
        }

        static int funcaoRetornaQuantitadePOV(decimal porcentagem, int totalNegociado)
        {
            return (int)((totalNegociado*porcentagem)/(1.0M-porcentagem));
        } 
    }
}