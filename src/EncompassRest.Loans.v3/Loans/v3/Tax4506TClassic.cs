namespace EncompassRest.Loans.v3;

/// <summary>
/// Tax4506TClassic
/// </summary>
public sealed partial class Tax4506TClassic : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// IRS4506 T Record - Last Updated History Record [IR0099]
    /// </summary>
    public int? LastUpdatedHistory { get => GetValue<int?>(); set => SetValue(value); }
}