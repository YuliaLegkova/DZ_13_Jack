using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Part
{
    public List<string> Poem {get;protected set;}= new List<string>();

    public abstract void AddPart(List<string> previousPoem);
}
