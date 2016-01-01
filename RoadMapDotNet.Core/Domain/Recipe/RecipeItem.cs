using System;

namespace RoadMapDotNet.Core.Domain.Recipe
{
    public class RecipeItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public RecipeStatus Status { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime TimeLastModified { get; set; }
        public DateTime TimeLastStatusChange { get; set; }

    }
}