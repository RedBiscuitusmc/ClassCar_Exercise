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
    public class Car
    {

        public Car()
        {

        }

        public Car(string engineNoise, string honkNoise, string make, string model, int year)
        {
            _enginenoise = engineNoise;
            _honknoise = honkNoise;
            _make = make;
            _model = model;
            _year = year;
        }

        public  int _year { get; set; }
        public  bool _isdriveable { get; set; }
        public  string _make { get; set; }
        public  string _model { get; set; }
        public  string _enginenoise { get; set; }
        public  string _honknoise { get; set; }

        public void MakeEngineNoise()
        {
            System.Console.WriteLine(_enginenoise);
        }
        public void MakeHonkNoise()
        {
            System.Console.WriteLine(_honknoise);
        }
    }
}
