﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integral
{
    class integral
    {
    public static double Y(double p)
            {
                return 1 / (1 + p * p);
            }

        public static double input(double someValue)
        {
            Console.WriteLine("Отрезок интегрирования [a,b] --> (a) =");
            someValue = int.Parse(Console.ReadLine());
            return someValue;
        }

        public static double inputEnd(double someValue)
        {
            Console.WriteLine("Отрезок интегрирования [a,b] --> (b) =");
            someValue = int.Parse(Console.ReadLine());
            return someValue;
        }
        public static double inputSigment(double someValue)
        {
            Console.WriteLine("На сколько частей нужно разделить отрезок? n=");
            someValue = int.Parse(Console.ReadLine());
            return someValue;
        }
        
        public static void traceValue()
        {
            double someValue = 0;
            double a = input(someValue);
            double b = inputEnd(someValue);
            int n = Convert.ToInt32(inputSigment(someValue));
            int sigment = factorial(n);
            resultIntegral(a, b, sigment);
            //factorial(n);
        }

        public static void resultIntegral(double a, double b, int n)
        {
            double h = (b - a) / n;
            double s = 0;
            double x = a + h;
            while (x < b)
            {
                s = s + 4 * Y(x);
                x = x + h;
                s = s + 2 * Y(x);
                x = x + h;
            }
            s = h / 3 * (s + Y(a) + Y(b));
            Console.WriteLine("Интеграл = {0}", s);
            Console.ReadKey();
        }

        public static int factorial(int n)
        {
            if (n != 1)
            {
                return n * factorial(n - 1);
            }
            else
            {
                return 1;
            }
           
        }

        static void Main(string[] args)
            {
                traceValue();
            //factorial();
            }
        }
    }