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
        public void DesignDrive()
        {
            IRecipe recipe = RecipeFactory.CreateStepRecipe();
            recipe.Add(new RecipeItem());  

            //A list, creation, from disk, add, delete, reorder
        }

        [Fact]
        public void BaseTest()
        {
            //todo: should use factory pattern here
            IRecipe recipe = new StepRecipe();
            
            var item = new RecipeItem();
            //recipe.Add(item);

            //Assert.Equal(recipe.Count,  1);

        }


    }

    public static class RecipeFactory
    {
        public static StepRecipe CreateStepRecipe()
        {
            return new StepRecipe();
        }

        public static TaskRecipe CreateTaskRecipe()
        {
            return new TaskRecipe();
        }
    }

    public class TaskRecipe : IRecipe
    {
        public RecipeStatus RecipeStatus { get; set; }
        public int ItemCount { get; set; }
        public void Add(RecipeItem item)
        {
            throw new NotImplementedException();
        }

        public void Remove(RecipeItem item)
        {
            throw new NotImplementedException();
        }

        public void InsertAt(RecipeItem item, int index)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }

    public class StepRecipe : IRecipe
    {
        public RecipeStatus RecipeStatus { get; set; }
        public int ItemCount { get; set; }
        public void Add(RecipeItem item)
        {
            throw new NotImplementedException();
        }

        public void Remove(RecipeItem item)
        {
            throw new NotImplementedException();
        }

        public void InsertAt(RecipeItem item, int index)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }
}
