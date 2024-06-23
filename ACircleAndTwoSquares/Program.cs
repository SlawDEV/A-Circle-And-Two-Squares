/*
 Function, that takes an integer (radius of the circle) and returns the difference of the areas of the two squares.
 For the smaller one, the circle is a circumcircle and for the bigger one, an incircle.
 */

using System;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(square_areas_difference(5));
            Console.WriteLine(square_areas_difference(6));
            Console.WriteLine(square_areas_difference(7));

            Console.ReadKey();
        }

        static int square_areas_difference(int radius)
        {
            return ((2 * radius) *(2 * radius)) - (2*(radius*radius));
        }
    }
}