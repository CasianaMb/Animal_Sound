using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Animal_Sound.Animals
{
    public abstract class Animal
    {
        public abstract string Type { get; }
        public abstract string Sound { get; }

        public virtual string MakeSound()
        {
            return $"{Type} makes sound: {Sound}";
        }
    }
}

