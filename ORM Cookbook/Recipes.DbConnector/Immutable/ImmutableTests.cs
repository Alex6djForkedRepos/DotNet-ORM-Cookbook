﻿using Recipes.DbConnector.Models;
using Recipes.Immutable;

namespace Recipes.DbConnector.Immutable;

[TestClass]
public class ImmutableTests : ImmutableTests<ReadOnlyEmployeeClassification>
{
    protected override ReadOnlyEmployeeClassification CreateWithValues(string name, bool isExempt, bool isEmployee)
    {
        return new ReadOnlyEmployeeClassification(0, name, isExempt, isEmployee);
    }

    protected override IImmutableScenario<ReadOnlyEmployeeClassification> GetScenario()
    {
        return new ImmutableScenario(Setup.SqlServerConnectionString);
    }

    protected override ReadOnlyEmployeeClassification UpdateWithValues(ReadOnlyEmployeeClassification original, string name, bool isExempt, bool isEmployee)
    {
        if (original == null)
            throw new ArgumentNullException(nameof(original), $"{nameof(original)} is null.");

        return new ReadOnlyEmployeeClassification(original.EmployeeClassificationKey, name, isExempt, isEmployee);
    }
}