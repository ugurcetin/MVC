using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using MuhendislerBurada.Data.Models;
using MuhendislerBurada.Model.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MuhendislerBurada.Data
{
    public class GoalsSampleData : DropCreateDatabaseIfModelChanges<MuhendislerBuradaEntities>
    {
        protected override void Seed(MuhendislerBuradaEntities context)
        {
            new List<Metric>
            {
                new Metric { Type ="%"},
                new Metric { Type ="$"},
                new Metric { Type ="$ M"},
                new Metric { Type ="Rs"},
                new Metric { Type ="Hours"},
                new Metric { Type ="Km"},
                new Metric { Type ="Kg"},
                new Metric { Type ="Years"}

            }.ForEach(m => context.Metrics.Add(m));

            new List<GoalStatus>
            {
                new GoalStatus{GoalStatusType="Açık"},
                new GoalStatus{GoalStatusType="Alıma bir süre kapalı"},
                new GoalStatus{GoalStatusType="Kapalı"}
            }.ForEach(m => context.GoalStatus.Add(m));

            context.Commit();

        }

    }
}