using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*.=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= -.
   /------------------------------ \
  |     By                                     |
  |     Jacob Merlin                   |
   \------------------------------ /
                 !           ! 
                !           !
                !          !
               ! _       !
         /   !__)     !
 __/___/_____)
        (_______)
 ___(______)
      \_(____)
         !       !
         !      !
         \__/
'-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-='*/

namespace CarLot
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Jeep = new Car();
            Jeep._make = "chrysler";
            Jeep._model = "Jeep Wrangler";
            Jeep._year = 2016;
            Jeep._isdriveable = true;
            Jeep._enginenoise = " OFF ROAD";
            Jeep._honknoise = "BEEP MEEP BEEP";
            CarLot.ParkingLot.Add(Jeep);

            var car = new Car();
            car._make = "chrysler";
            car._model = "PMP 300";
            car._year = 2018;
            car._isdriveable = true;
            car._enginenoise = "HONK Hewk";
            car._honknoise = "ROOM Zoom Verm";
            CarLot.ParkingLot.Add(car);

            var Suv = new Car();
            Suv._make = "chrysler";
            Suv._model = "Jeep Cherokee";
            Suv._year = 1988;
            Suv._isdriveable = false;
            Suv._enginenoise = "ROOM cough cough";
            Suv._honknoise = "meep meep";
            CarLot.ParkingLot.Add(Suv);

            foreach (var c in CarLot.ParkingLot)
            {
                Console.WriteLine($"{c._year} {c._make} {c._model}");
                c.MakeEngineNoise();
                c.MakeHonkNoise();
                Console.WriteLine("-------------");
            }
        }    
    }
}