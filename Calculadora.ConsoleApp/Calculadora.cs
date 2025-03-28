﻿namespace Calculadora.ConsoleApp
{
    public static class Calculadora
    {
        static int contadorHistorico = 0;
        static string[] historicoOperacoes = new string[100];
        public static decimal Somar(decimal primeiroNumero, decimal segundoNumero)
  
        {
            decimal resultado = primeiroNumero + segundoNumero;
            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
            contadorHistorico++;

            return resultado;
        }
        public static decimal Subtrair(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero - segundoNumero;
            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";
            contadorHistorico++;

            return resultado;
        }
        public static decimal Multiplicar(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero * segundoNumero;
            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} * {segundoNumero} = {resultado}";
            contadorHistorico++;

            return resultado;
        }
        public static decimal Dividir(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero / segundoNumero;
            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} / {  segundoNumero} = {resultado}";
            contadorHistorico++;

            return resultado;
        }

        public static string[] GerarTabuada(int numeroTabuada)
        {
            string[] linhasTabuada = new string[10];

            for (int contador = 1; contador <= 10; contador++)
            {
                int resultadoTabuada = numeroTabuada * contador;

                linhasTabuada[contador - 1] = $"{numeroTabuada} x {contador} = {resultadoTabuada}";

            }
            return linhasTabuada;
        }

        public static string[] ObterHistoricoDeOperacoes()
        {
            return historicoOperacoes;
        }


    }
}
