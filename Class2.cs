using _JackHouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    public class Part2 : Part
    {
        public override void AddPart(List<string> previousPoem)
        {
            Poem = new List<string>(previousPoem)
            {
                "",
                "А это пшеница,", 
                "Которая в тёмном чулане хранится",
                "В доме,",
                "Который построил Джек."
            };
        }
    }