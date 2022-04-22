using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Gfe2010Fee
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(Gfe2010FeeIndex) + "," + nameof(Gfe2010FeeParentType) + "," + nameof(Gfe2010FeeType))]
public sealed partial class Gfe2010Fee : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Gfe2010Fee AdditionalAmount
    /// </summary>
    public decimal? AdditionalAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee Amount
    /// </summary>
    public decimal? Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee AprIndicator
    /// </summary>
    public bool? AprIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee BorPaidAmount
    /// </summary>
    public decimal? BorPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee BorrowerAmountPaid2015
    /// </summary>
    public decimal? BorrowerAmountPaid2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee BorrowerCanShopForIndicator2015
    /// </summary>
    public bool? BorrowerCanShopForIndicator2015 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee BorrowerDidShopForIndicator2015
    /// </summary>
    public bool? BorrowerDidShopForIndicator2015 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee BorrowerFinanced2015
    /// </summary>
    public decimal? BorrowerFinanced2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee BorrowerPAC2015
    /// </summary>
    public decimal? BorrowerPAC2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee BorrowerPOC2015
    /// </summary>
    public decimal? BorrowerPOC2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee BorrowerPTC2015
    /// </summary>
    public decimal? BorrowerPTC2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee BorrowerSelectIndicator
    /// </summary>
    public bool? BorrowerSelectIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee BrokerAmountPaid2015
    /// </summary>
    public decimal? BrokerAmountPaid2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee BrokerPAC2015
    /// </summary>
    public decimal? BrokerPAC2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee BrokerPOC2015
    /// </summary>
    public decimal? BrokerPOC2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee CollectedPostConsummationIndicator2015
    /// </summary>
    public bool? CollectedPostConsummationIndicator2015 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee EscrowedIndicator2015
    /// </summary>
    public bool? EscrowedIndicator2015 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee FinancedIndicator
    /// </summary>
    public bool? FinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee Gfe2010FeeIndex
    /// </summary>
    public int? Gfe2010FeeIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee Gfe2010FeeParentType
    /// </summary>
    public StringEnumValue<Gfe2010FeeParentType> Gfe2010FeeParentType { get => GetValue<StringEnumValue<Gfe2010FeeParentType>>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee Gfe2010FeeType
    /// </summary>
    public StringEnumValue<Gfe2010FeeType> Gfe2010FeeType { get => GetValue<StringEnumValue<Gfe2010FeeType>>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee GfeAmount
    /// </summary>
    public decimal? GfeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee InsuranceIndicator2015
    /// </summary>
    public bool? InsuranceIndicator2015 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee LastDisclosedClosingDisclosure2015
    /// </summary>
    public decimal? LastDisclosedClosingDisclosure2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee LastDisclosedLoanEstimate2015
    /// </summary>
    public int? LastDisclosedLoanEstimate2015 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee LenderAmountPaid2015
    /// </summary>
    public decimal? LenderAmountPaid2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee LenderPAC2015
    /// </summary>
    public decimal? LenderPAC2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee LenderPOC2015
    /// </summary>
    public decimal? LenderPOC2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee MonthlyPayment
    /// </summary>
    public decimal? MonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee NumberOfMonths
    /// </summary>
    public int? NumberOfMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee OptionalIndicator2015
    /// </summary>
    public bool? OptionalIndicator2015 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee OtherAmountPaid2015
    /// </summary>
    public decimal? OtherAmountPaid2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee OtherPAC2015
    /// </summary>
    public decimal? OtherPAC2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee OtherPOC2015
    /// </summary>
    public decimal? OtherPOC2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee PaidByType
    /// </summary>
    public StringEnumValue<PaidBy> PaidByType { get => GetValue<StringEnumValue<PaidBy>>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee PaidToName
    /// </summary>
    public string? PaidToName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee PocPtcIndicator
    /// </summary>
    public bool? PocPtcIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee PropertyIndicator2015
    /// </summary>
    public bool? PropertyIndicator2015 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee PtbType
    /// </summary>
    public StringEnumValue<PTB> PtbType { get => GetValue<StringEnumValue<PTB>>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee Rate
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Rate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee RetainedAmount2015 [NEWHUD2.X2219], [NEWHUD2.X2318]
    /// </summary>
    public decimal? RetainedAmount2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee Sec32PointsAndFees2015
    /// </summary>
    public decimal? Sec32PointsAndFees2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee SellerAmountPaid2015
    /// </summary>
    public decimal? SellerAmountPaid2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee SellerCreditIndicator2015
    /// </summary>
    public bool? SellerCreditIndicator2015 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee SellerObligatedAmount2015
    /// </summary>
    public decimal? SellerObligatedAmount2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee SellerObligatedIndicator2015
    /// </summary>
    public bool? SellerObligatedIndicator2015 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee SellerPAC2015
    /// </summary>
    public decimal? SellerPAC2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee SellerPOC2015
    /// </summary>
    public decimal? SellerPOC2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee SelPaidAmount
    /// </summary>
    public decimal? SelPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee SimultaneousIssuanceIndicator2015 [NEWHUD2.X4441], [NEWHUD2.X4443]
    /// </summary>
    public bool? SimultaneousIssuanceIndicator2015 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee TaxesIndicator2015
    /// </summary>
    public bool? TaxesIndicator2015 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee TitleServiceSelectIndicator
    /// </summary>
    public bool? TitleServiceSelectIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee TotalFeeAmount2015
    /// </summary>
    public decimal? TotalFeeAmount2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee TotalFeePercentage2015
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? TotalFeePercentage2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee TotalPaidByBLO2015
    /// </summary>
    public decimal? TotalPaidByBLO2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee UndiscountedInsurance2015 [NEWHUD2.X4442], [NEWHUD2.X4444]
    /// </summary>
    public decimal? UndiscountedInsurance2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee WholePoc
    /// </summary>
    public decimal? WholePoc { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Fee WholePocPaidByType
    /// </summary>
    public StringEnumValue<WholePocPaidByType> WholePocPaidByType { get => GetValue<StringEnumValue<WholePocPaidByType>>(); set => SetValue(value); }
}