using _JackHouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Part5 : Part
{
    public override void AddPart(List<string> previousPoem)
    {
        Poem = new List<string>(previousPoem)
            {
                "",
                "Вот пёс без хвоста,",
                "Который за шиворот треплет кота,",
                "Который пугает и ловит синицу,",
                "Которая часто ворует пшеницу,",
                "Которая в тёмном чулане хранится",
                "В доме,",
                "Который построил Джек."
            };
    }
}
