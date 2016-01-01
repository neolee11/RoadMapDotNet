using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoadMapDotNet.Core.Domain;
using RoadMapDotNet.Core.Domain.Recipe;
using Xunit;


namespace RoadMapDotNet.Core.Tests.DomainTests
{
    public class RecipeTests
    {
        [Fact]
        public void BaseTest()
        {
            Recipe recipe = new StepRecipe();



        }


    }

    public class StepRecipe : Recipe
    {
    }
}
