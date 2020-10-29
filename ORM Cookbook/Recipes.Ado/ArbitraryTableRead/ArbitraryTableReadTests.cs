﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recipes.ArbitraryTableRead;
using System.Data;

namespace Recipes.Ado.ArbitraryTableRead
{
    [TestClass]
    public class ArbitraryTableReadTests : ArbitraryTableReadTests<DataTable>
    {
        protected override IArbitraryTableReadScenario<DataTable> GetScenario()
        {
            return new ArbitraryTableReadScenario(Setup.SqlServerConnectionString);
        }
    }
}
