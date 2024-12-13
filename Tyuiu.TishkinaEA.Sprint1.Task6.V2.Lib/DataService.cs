﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TishkinaEA.Sprint1.Task6.V2.Lib
{
    public class DataService : ISprint1Task6V2
    {
        public bool CheckHello(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            return value.Contains("Hello", StringComparison.OrdinalIgnoreCase);
        }
    }
}
