﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recipes.Ado.Models;
using Recipes.DiscoverTablesAndColumns;

namespace Recipes.Ado.DiscoverTablesAndColumns
{
    [TestClass]
    public class DiscoverTablesAndColumnsTests : Recipes.DiscoverTablesAndColumns.DiscoverTablesAndColumnsTests
    {
        protected override IDiscoverTablesAndColumnsScenario GetScenario()
        {
            return new DiscoverTablesAndColumnsScenario(Setup.SqlServerConnectionString);
        }
    }
}
