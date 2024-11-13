using NC_Safari.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari;

public class EnvironmentMap
{
    public List<SafariEnvironment> EnvironmentList { get; set; }
    
    public EnvironmentMap() { EnvironmentList = new List<SafariEnvironment>(); }

    public void Tick()
    {
        foreach (SafariEnvironment env in EnvironmentList)
        {
            foreach(ITravel i in env.animalsInEnvironment)
            {
                
            }
        }
    }
}
