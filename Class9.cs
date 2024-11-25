﻿using _JackHouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Part9 : Part
{
    public override void AddPart(List<string> previousPoem)
    {
        Poem = new List<string>(previousPoem)
            {
                "",
                "Вот два петуха,",
                "Которые будят того пастуха,",
                "Который бранится с коровницей строгою,",
                "Которая доит корову безрогую,",
                "Лягнувшую старого пса без хвоста,",
                "Который за шиворот треплет кота,",
                "Который пугает и ловит синицу,",
                "Которая часто ворует пшеницу,",
                "Которая в тёмном чулане хранится",
                "В доме,",
                "Который построил Джек."
            };
    }
}