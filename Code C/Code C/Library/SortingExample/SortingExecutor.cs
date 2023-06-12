﻿using System;
using BuildingBlocks;
using Library.SortingExample.Libs;
using Library.SortingExample.Libs.Common;

namespace Library.SortingExample
{
    public static class SortingExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Sorting example");

            ISort sort = new SortByFirstName();
            var sortablePersons = new SortablePersons(sort);

            sortablePersons.Add(new Person("Dennis", "Ritchie", 1941));
            sortablePersons.Add(new Person("Linus", "Torvalds", 1969));
            sortablePersons.Add(new Person("Tim", "Berners-Lee", 1955));
            sortablePersons.Add(new Person("Larry", "Page", 1973));
            sortablePersons.Add(new Person("Anders", "Hejlsberg", 1960));
            sortablePersons.Add(new Person("Bjarne", "Stroustrup", 1950));

            Console.WriteLine("Sorting persons by first name.");
            foreach (Person person in sortablePersons.Sort())
            {
                Console.WriteLine(person.ToString());
            }

            sortablePersons.Sort = new SortByYearOfBirth();

            Console.WriteLine("\nSorting persons by year of birth.");
            foreach (Person person in sortablePersons.Sort())
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
