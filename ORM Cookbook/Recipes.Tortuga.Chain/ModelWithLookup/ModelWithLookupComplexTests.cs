﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recipes.ModelWithLookup;

namespace Recipes.Chain.ModelWithLookup
{
    [TestClass]
    public class ModelWithLookupComplexTests : ModelWithLookupComplexTests<EmployeeComplex>
    {
        protected override IModelWithLookupComplexScenario<EmployeeComplex> GetScenario()
        {
            return new ModelWithLookupComplexScenario(Setup.PrimaryDataSource);
        }
    }
}
