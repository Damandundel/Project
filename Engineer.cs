using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.Enumerations;
using MilitaryElite.Interfaces;
using MilitaryElite.Models;

namespace MilitaryElite
{
    public class Engineer : Private, IEngineer
    {
        private int repairs;
        private SoldierCorpEnum corp;
        private ICollection<IRepair> repairs1;

        public Engineer(int id, string firstName, string lastName, decimal salary, SoldierCorpEnum SoldierCorp, int repairs)
            : base(id, firstName, lastName, salary)
        {
            this.repairs = repairs;
        }

        public Engineer(int id, string firstName, string lastName, decimal salary, SoldierCorpEnum corp, ICollection<IRepair> repairs1) : base(id, firstName, lastName, salary)
        {
            this.corp = corp;
            this.repairs1 = repairs1;
        }

        public ICollection<IRepair> Repairs { get; }
        public object SoldierCorp { get; private set; }

        public override string ToString()
        {
            return base.ToString()
                  + Environment.NewLine
                  + $"Corps: {this.SoldierCorp}"
                  + Environment.NewLine;
        }
    }
}
