using System;
using System.Collections.Generic;

namespace _01.Planet_and_Spaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury","Mars"};
            showList( planetList );

            // Add() Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            showList( planetList );

            // Create another List that contains that last two planet of our solar system.
            List<string> lastTwoPlanets = new List<string>(){"Uranus","Neptune"};

            // Combine the two lists by using AddRange().
            planetList.AddRange(lastTwoPlanets);
            showList( planetList );

            // Use Insert() to add Earth, and Venus in the correct order.
            planetList.Insert( planetList.IndexOf("Mercury") + 1, "Venus" );
            planetList.Insert( planetList.IndexOf("Venus") + 1, "Earth" );
            showList( planetList );

            // Use Add() again to add Pluto to the end of the list.
            planetList.Add("Pluto");
            showList( planetList );

            // Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.
            List<string> rockyPlanets = planetList.GetRange( 0,4 );
            showList( rockyPlanets );

            // Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
            planetList.Remove("Pluto");
            showList( planetList );
        }

        static void showList( List<string> planets )
        {
            Console.WriteLine( "Current planets list:");
            foreach( string planet in planets )
            {
                Console.WriteLine( $"{planets.IndexOf(planet)} {planet}" );
            }
            Console.WriteLine( "\n" );
        }
    }
}
