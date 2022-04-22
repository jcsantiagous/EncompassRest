using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ServicingDisclosure
/// </summary>
public sealed partial class ServicingDisclosure : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Disclosure 3B % 1 [RESPA.X23]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? DisclosurePercent1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure 3B % 2 [RESPA.X25]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? DisclosurePercent2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure 3B % 3 [RESPA.X27]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? DisclosurePercent3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure 3B Yr 1 [RESPA.X22]
    /// </summary>
    public string? DisclosureYear1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure 3B Yr 2 [RESPA.X24]
    /// </summary>
    public string? DisclosureYear2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure 3B Yr 3 [RESPA.X26]
    /// </summary>
    public string? DisclosureYear3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure 2 51-75% [RESPA.X16]
    /// </summary>
    public bool? FiftyOneTo75Indicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure 2 76-100% [RESPA.X17]
    /// </summary>
    public bool? SeventySixTo100Indicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure 2 This Estimate Does/Does Not [RESPA.X8]
    /// </summary>
    public StringEnumValue<DoesOrDoesNot2> ThisEstimateType { get => GetValue<StringEnumValue<DoesOrDoesNot2>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure This Information Does/Does Not Include [RESPA.X18]
    /// </summary>
    public StringEnumValue<DoesOrDoesNot2> ThisInformationType { get => GetValue<StringEnumValue<DoesOrDoesNot2>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure 3B This Is Our Record [RESPA.X21]
    /// </summary>
    public bool? ThisIsOurRecordOfTransferIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure 2 26-50% [RESPA.X15]
    /// </summary>
    public bool? TwentySixTo50Indicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure 1A Will/Will Not/Haven't Decided [RESPA.X2]
    /// </summary>
    public StringEnumValue<WeAreAbleType> WeAreAbleType { get => GetValue<StringEnumValue<WeAreAbleType>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure We Do Not Intend to Sell The Servicing of The Loan [RESPA.X28]
    /// </summary>
    public bool? WeDoNotSellMortgageLoansIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure 1B We Do Not Service [RESPA.X6]
    /// </summary>
    public bool? WeDoNotServiceMortgageLoansIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure 1B And We Have Not Serviced [RESPA.X7]
    /// </summary>
    public bool? WeHaveNotServicedMortgageLoansIn3YrsIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure 3A We Have Previously [RESPA.X20]
    /// </summary>
    public bool? WeHavePreviouslyAssignedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure 1A We May Assign [RESPA.X1]
    /// </summary>
    public bool? WeMayAssignIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure 2 0-25% [RESPA.X14]
    /// </summary>
    public bool? ZeroTo25Indicator { get => GetValue<bool?>(); set => SetValue(value); }
}