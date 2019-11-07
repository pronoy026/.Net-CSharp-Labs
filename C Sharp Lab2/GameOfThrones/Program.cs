using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfThrones
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListOfHeroes = from hero in Hero.GetHeroesList()
                               select hero;
            Console.WriteLine("List of Heroes : ");
            foreach (var hero in ListOfHeroes)
            {
                Console.WriteLine(hero);
            }

            var ListOfHouses = from house in House.GetGreatHousesList()
                               select house;
            Console.WriteLine("\nList of Houses :");
            foreach (var house in ListOfHouses)
            {
                Console.WriteLine(house);
            }

            var HouseSTAHeroes = from hero in Hero.GetHeroesList()
                                 where hero.HouseId == "STA"
                                 select hero;
            Console.WriteLine("\nHeroes from STA house");
            foreach (var hero in HouseSTAHeroes)
            {
                Console.WriteLine(hero);
            }


            ////////////////
            var HouseSTAFemaleHeroes = from hero in Hero.GetHeroesList()
                                 where hero.HouseId == "STA" && hero.Gender == "F"
                                 select new { hero.Id, hero.Name};
            Console.WriteLine("\nFemale Heroes from STA house");
            foreach (var hero in HouseSTAFemaleHeroes)
            {
                Console.WriteLine($"Id : { hero.Id}, Name : {hero.Name}");
            }


            //

            var HouseSTAHeroesContainingA = from hero in Hero.GetHeroesList()
                                where hero.HouseId == "STA" && hero.Name.Contains("a") || hero.Name.Contains("A")
                                orderby hero.Name
                                select new { hero.Id, hero.Name };
            Console.WriteLine("\nHeroes from STA house having 'a' in Name ordered by Name:");
            foreach (var hero in HouseSTAHeroesContainingA)
            {
                Console.WriteLine($"Id : { hero.Id}, Name : {hero.Name}");

            }

            ///////
            var HouseSTAandTARHeroes = from hero in Hero.GetHeroesList()
                                 where hero.HouseId == "STA" || hero.HouseId == "TAR"
                                 orderby hero.HouseId
                                 select new { hero.Id, hero.Name};
            Console.WriteLine("\nHeroes from STA or TAR house ordered by HouseID");
            foreach (var hero in HouseSTAandTARHeroes)
            {
                Console.WriteLine($"Id : { hero.Id}, Name : {hero.Name}");
            }


            //////
            var HousesOfLocation = from house in House.GetGreatHousesList()
                                   where house.HouseLocation.Contains("Crownlands") || (house.HouseLocation.Contains("Westernlands"))
                                   select house;
            Console.WriteLine("Houses of Crownlands and Westerlands");
            foreach (var house in HousesOfLocation)
            {
                Console.WriteLine(house);
            }

            //combine hero and house data


            //var HousePerson = from house in House.GetGreatHousesList()
            //                  from hero in Hero.GetHeroesList()
            //                  where house.HouseId == hero.HouseId
            //                  select new { hero.Name, house.HouseLocation };
            //Console.WriteLine("Combining hero and house data");

            //var HousePerson = from hero in Hero.GetHeroesList()
            //                  join house in House.GetGreatHousesList()
            //                  on hero.HouseId equals house.HouseId
            //                  orderby hero.Name
            //                  select new
            //                  {
            //                      hero.Name,
            //                      house.HouseLocation
            //                  };

            var HousePerson = Hero.GetHeroesList().Join(House.GetGreatHousesList(),
                hero => hero.HouseId,
                house => house.HouseId,
                (hero, house) => new { hero.Name, house.HouseLocation });

            Console.WriteLine("Combining hero and house data");

            foreach (var hero in HousePerson)
            {
                Console.WriteLine($"Hero : {hero.Name }, Location: { hero.HouseLocation}");
            }


            //female Dragonstone heroes

            var DragonstoneFemales = Hero.GetHeroesList().Join(House.GetGreatHousesList(),
                hero => hero.HouseId,
                house => house.HouseId,
                (hero, house) => new { hero.Name, hero.Gender, house.HouseLocation }).Where(hero => hero.Gender == "F" && hero.HouseLocation.Contains("Dragonstone")).Select(hero => hero);

            Console.WriteLine("\nAll female Dragonstone heroes : ");
            foreach (var hero in DragonstoneFemales)
            {
                Console.WriteLine($"Name : {hero.Name}, HouseLocation : {hero.HouseLocation}, Gender : {hero.Gender}emale");
            }












            Console.ReadLine();

        }
    }
}
