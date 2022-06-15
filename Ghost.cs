using System.Collections.Generic;

namespace Phasmo_Journal_2
{
    public class Ghost
    {
        //Fields

        private string _GhostName;
        private List<string> _potentialEvidence;


        public Ghost(string ghostName, List<string> potentialEvidence)
        {
            //constructor
            GhostName = ghostName;
            this.PotentialEvidence = potentialEvidence;
        }

        public string GhostName { get => _GhostName; set => _GhostName = value; }
        public List<string> PotentialEvidence { get => _potentialEvidence; set => _potentialEvidence = value; }

        public void removeEvidence(string evidence)
        {
            _potentialEvidence.Remove(evidence);
        }






    }
}
