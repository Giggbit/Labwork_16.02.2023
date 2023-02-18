using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Day_Of_Week { Monday, Thuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
enum Month { January = 1, February, March, April, May, June, July, August, September, October, November, December };

struct Fraction {
    public int numerator;
    public int denominator;

    public Fraction(int n, int d) {
        numerator = n;
        denominator = d;
    }

    public void Addition(Fraction obj) {
        numerator += obj.numerator;
        denominator += obj.denominator;
    }
    public void Subtraction(Fraction obj) {
        numerator -= obj.numerator;
        denominator -= obj.denominator;
    }
    public void Multiplication(Fraction obj) {
        numerator *= obj.numerator;
        denominator *= obj.denominator;
    }
    public void Division(Fraction obj) {
        numerator *= obj.denominator;
        denominator *= obj.numerator;
    }
}
struct Complex {
    public double num, i;

    public Complex(double num, double i) {
        this.num = num;
        this.i = i;
    }
    public Complex Addition(Complex a, Complex b) {
        Complex result = new Complex();
        result.num = a.num + b.num;
        result.i = a.i + b.i;
        Console.WriteLine($"\nnum = {result.num}\ni = {result.i}");
        return result;
    }
    public Complex Substraction(Complex a, Complex b) {
        Complex result = new Complex();
        result.num = a.num - b.num;
        result.i = a.i - b.i;
        Console.WriteLine($"\nnum = {result.num}\ni = {result.i}");
        return result;
    }
    public Complex Multiplication(Complex a, Complex b) {
        Complex result = new Complex();
        result.num = a.num * b.num;
        result.i = a.i * b.i;
        Console.WriteLine($"\nnum = {result.num}\ni = {result.i}");
        return result;
    }
    public Complex Division(Complex a, Complex b) {
        Complex result = new Complex();
        result.num = a.num / b.num;
        result.i = a.i / b.i;
        Console.WriteLine($"\nnum = {result.num}\ni = {result.i}");
        return result;
    }
}
struct Birthday {
    private int year;
    private int day;
    private int month;

    public Birthday(int y, int d, int m) {
        year = y;
        day = d;
        month = m;
    }
    public void Date(Birthday obj) {
        Console.WriteLine($"\nYour birthday is {day}.{month}.{year}");
    }

    public void Week(Birthday obj) {
        int day = obj.day; 

        int[] day_of_week = { 1, 2, 3, 4, 5, 6, 7 };
        Day_Of_Week i; 
        for (i = Day_Of_Week.Monday; i <= Day_Of_Week.Sunday; i++) {
            Console.WriteLine(i + " - это " + day_of_week[(int)i]);
        }
        Console.WriteLine();
    }

}

namespace Labwork_16._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Birthday a = new Birthday(27,09,2004);
            a.Week(a);
            

        }
    }
}
