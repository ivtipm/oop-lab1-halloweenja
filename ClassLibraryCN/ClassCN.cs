using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCN
{
    public class ClassCN
    {
        double re, im;              //Реальная и мнимая часть комплекного числа

        /// <summary>
        /// Конструстор по умолчанию
        /// </summary>
        public ClassCN()             
        { 
            re = 0; 
            im = 0; 
        }

        /// <summary>
        /// Комструктор с одним параметром
        /// </summary>
        public ClassCN(double r)    
        { 
            re = r; 
            im = 0; 
        }

        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        public ClassCN(double r, double i)   
        { 
            re = r; 
            im = i; 
        }

        /// <summary>
        /// Конструктор для дублирования полей с другого экземпляра класса
        /// </summary>
        public ClassCN(ClassCN c)           
        { 
            re = c.Re; 
            im = c.Im; 
        }

        /// <summary>
        /// get / set реальной части комплексного числа
        /// </summary>
        public double Re                    
        { 
            get => re; 
            set => re = value; 
        }

        /// <summary>
        /// get / set мнимой части комплексного числа
        /// </summary>
        public double Im                    
        { 
            get => im; 
            set => im = value; 
        }

        /// <summary>
        /// Модуль комплексного числа
        /// </summary>
        public double abs()                 
        {
            return Math.Sqrt(re * re + im * im);
        }

        /// <summary>
        /// Аргумент комплексного числа
        /// </summary>
        public double argument()            
        {
            return Math.Atan2(re, im) * 180 / Math.PI;
        }

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        public static ClassCN Sum(ClassCN a, ClassCN b)     
        {
            ClassCN res = new ClassCN();
            res.re = a.re + b.re;
            res.im = a.im + b.im;
            return res;
        }

        /// <summary>
        /// Сложение комплексного числа и обычного реального числа
        /// </summary>
        public static ClassCN Sum(ClassCN a, double b)      
        {
            ClassCN res = new ClassCN();
            res.re = a.re + b;
            res.im = a.im;
            return res;
        }

        /// <summary>
        /// Умножение комплексного числа и комплексного числа
        /// </summary>
        public static ClassCN Multiplication(ClassCN a, ClassCN b)  
        {
            ClassCN res = new ClassCN();
            res.re = a.re * b.re - a.im * b.im;
            res.im = a.im * b.re + a.re * b.im;
            return res;
        }

        /// <summary>
        /// Умножение комплексного числа и числа
        /// </summary>
        public static ClassCN Multiplication(ClassCN a, double b)   
        {
            ClassCN res = new ClassCN();
            res.re = a.re * b;
            res.im = a.im * b;
            return res;
        }

        /// <summary>
        /// Разность комплексного числа и комплексного числа
        /// </summary>
        public static ClassCN Subtract(ClassCN a, ClassCN b)        
        {
            ClassCN res = new ClassCN();
            res.re = a.re - b.re;
            res.im = a.im - b.im;
            return res;
        }

        /// <summary>
        /// Разность комплексного числа и реального числа
        /// </summary>
        public static ClassCN Subtract(ClassCN a, double b)
        {
            ClassCN res = new ClassCN();
            res.re = a.re - b;
            res.im = a.im;
            return res;
        }

        
        /// <summary>
        /// Оператор суммы комплексного числа с комплексный числом или числом
        /// </summary>
        public static ClassCN operator +(ClassCN a, ClassCN b)
        {
            return ClassCN.Sum(a, b);
        }

        /// <summary>
        /// Оператор суммы комплексного числа с комплексный числом или числом
        /// </summary>
        public static ClassCN operator +(ClassCN a, double b)
        {
            return ClassCN.Sum(a, b);
        }

        /// <summary>
        /// Оператор разности комплексного числа с комплексный числом или числом
        /// </summary>
        public static ClassCN operator -(ClassCN a, ClassCN b)
        {
            return ClassCN.Subtract(a, b);
        }

        /// <summary>
        /// Оператор разности комплексного числа с комплексный числом или числом
        /// </summary>
        public static ClassCN operator -(ClassCN a, double b)
        {
            return ClassCN.Subtract(a, b);
        }

        /// <summary>
        /// Оператор умножения комплексного числа на комплексный числом или числом
        /// </summary>
        public static ClassCN operator *(ClassCN a, ClassCN b)
        {
            return ClassCN.Multiplication(a, b);
        }

        /// <summary>
        /// Оператор умножения комплексного числа на комплексный числом или числом
        /// </summary>
        public static ClassCN operator *(ClassCN a, double b)
        {
            return ClassCN.Multiplication(a, b);
        }

        /// <summary>
        /// Вывод комплексного числа
        /// </summary>
        public override string ToString()
        {
            return String.Format("{0} + i{1}", this.re, this.im);
        }
    }
}
