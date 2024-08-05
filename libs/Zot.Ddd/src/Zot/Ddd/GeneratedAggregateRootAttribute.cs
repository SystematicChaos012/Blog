namespace Zot.Ddd;

/// <summary>Instructs the Zot.Ddd source generator to generate methods and properties for an aggregate root.</summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public sealed class GeneratedAggregateRootAttribute : Attribute;