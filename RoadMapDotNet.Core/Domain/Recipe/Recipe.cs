using System.Collections.Generic;

namespace RoadMapDotNet.Core.Domain.Recipe
{
    public abstract class Recipe
    {
        public IEnumerable<RecipeItem> Items { get; set; }
        public RecipeStatus RecipeStatus { get; set; }
    }
}