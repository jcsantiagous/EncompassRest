using System;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ClosingDisclosure1
/// </summary>
public sealed partial class ClosingDisclosure1 : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Closing Disclosure - CD Date Issued [CD1.X1]
    /// </summary>
    public DateTime? CdDateIssued { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Changed Circumstance [CD1.X64]
    /// </summary>
    public string? ChangedCircumstance { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CD Changed Circumstance Chkbx [CD1.X61]
    /// </summary>
    public bool? ChangedCircumstanceFlag { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// CD Changed Circumstance Rcvd Date [CD1.X62]
    /// </summary>
    public DateTime? ChangesReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Comments [CD1.X65]
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Disclosure By [CD1.X48]
    /// </summary>
    public string? DisclosureBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Disclosure Comments [CD1.X50]
    /// </summary>
    public string? DisclosureComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Last CD Sent Date [CD1.X47]
    /// </summary>
    public DateTime? DisclosureLastSentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Disclosure Received Date [CD1.X51]
    /// </summary>
    public DateTime? DisclosureReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Disclosure Sent Method [CD1.X49]
    /// </summary>
    public string? DisclosureSentMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Document GUID of the final executed copy of the alternate CD [UCD.X3]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DocumentGuidFinalExecutedCopyofAlternateCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Document GUID of the final executed copy of the seller CD [UCD.X5]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DocumentGuidFinalExecutedCopyofSellerCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Document GUID of the final executed copy of the standard CD [UCD.X1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DocumentGuidFinalExecutedCopyofStandardCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Estimated Taxes, Insurance and Assessments [CD1.X3]
    /// </summary>
    public decimal? EstimatedTaxesInsuranceAssessments { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - In Escrow Homeowner Insurance [CD1.X5]
    /// </summary>
    public string? InEscrowHomeownerInsurance { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - In Escrow Other [CD1.X6]
    /// </summary>
    public string? InEscrowOther { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - In Escrow Property Taxes [CD1.X4]
    /// </summary>
    public string? InEscrowPropertyTaxes { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Initial CD Received Date [CD1.X73]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? InitialReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - MIC Reference [CD1.X71]
    /// </summary>
    public string? MicReference { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Not a Natural Person (legal entity) Flag [CD1.X72]
    /// </summary>
    public bool? NotNaturalPersonFlag { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 1 - Estimated Escrow Amount [CD1.X12]
    /// </summary>
    public decimal? Ppc1EstimatedEscrowAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 1 - Estimated Escrow Amount UI Value [CD1.XD12]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc1EstimatedEscrowAmountUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 1 - Interest Only [CD1.X10]
    /// </summary>
    public bool? Ppc1InterestOnly { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 1 - Maximum Monthly Payment [CD1.X14]
    /// </summary>
    public decimal? Ppc1MaximumMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 1-Maximum Monthly Payment UI Value [CD1.XD14]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc1MaximumMonthlyPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 1 - Maximum Principal and Interest Payment [CD1.X9]
    /// </summary>
    public decimal? Ppc1MaximumPiPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 1-Maximum Principal and Interest Payment UI Value [CD1.XD9]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc1MaximumPiPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 1 - Mortgage Insurance Amount [CD1.X11]
    /// </summary>
    public decimal? Ppc1MiAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 1 - Mortgage Insurance Amount UI Value [CD1.XD11]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc1MiAmountUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 1 - Minimum Monthly Payment [CD1.X13]
    /// </summary>
    public decimal? Ppc1MinimumMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 1-Minimum Monthly Payment UI Value [CD1.XD13]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc1MinimumMonthlyPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 1 - Minimum Principal and Interest Payment [CD1.X8]
    /// </summary>
    public decimal? Ppc1MinimumPiPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 1-Minimum Principal and Interest Payment UI Value [CD1.XD8]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc1MinimumPiPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 1 - Year [CD1.X7]
    /// </summary>
    public int? Ppc1Year { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 2 - Estimated Escrow Amount [CD1.X21]
    /// </summary>
    public decimal? Ppc2EstimatedEscrowAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 2 - Estimated Escrow Amount UI Value [CD1.XD21]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc2EstimatedEscrowAmountUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 2 - Interest Only [CD1.X19]
    /// </summary>
    public bool? Ppc2InterestOnly { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 2 - Maximum Monthly Payment [CD1.X23]
    /// </summary>
    public decimal? Ppc2MaximumMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 2-Maximum Monthly Payment UI Value [CD1.XD23]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc2MaximumMonthlyPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 2 - Maximum Principal and Interest Payment [CD1.X18]
    /// </summary>
    public decimal? Ppc2MaximumPiPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 2-Maximum Principal and Interest Payment UI Value [CD1.XD18]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc2MaximumPiPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 2 - Mortgage Insurance Amount [CD1.X20]
    /// </summary>
    public decimal? Ppc2MiAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 2 - Mortgage Insurance Amount UI Value [CD1.XD20]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc2MiAmountUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 2 - Minimum Monthly Payment [CD1.X22]
    /// </summary>
    public decimal? Ppc2MinimumMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 2-Minimum Monthly Payment UI Value [CD1.XD22]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc2MinimumMonthlyPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 2 - Minimum Principal and Interest Payment [CD1.X17]
    /// </summary>
    public decimal? Ppc2MinimumPiPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 2-Minimum Principal and Interest Payment UI Value [CD1.XD17]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc2MinimumPiPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 2 - Year From [CD1.X15]
    /// </summary>
    public int? Ppc2YearFrom { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 2 - Year To [CD1.X16]
    /// </summary>
    public int? Ppc2YearTo { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 3 - Estimated Escrow Amount [CD1.X30]
    /// </summary>
    public decimal? Ppc3EstimatedEscrowAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 3 - Estimated Escrow Amount UI Value [CD1.XD30]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc3EstimatedEscrowAmountUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 3 - Interest Only [CD1.X28]
    /// </summary>
    public bool? Ppc3InterestOnly { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 3 - Maximum Monthly Payment [CD1.X32]
    /// </summary>
    public decimal? Ppc3MaximumMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 3-Maximum Monthly Payment UI Value [CD1.XD32]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc3MaximumMonthlyPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 3 - Maximum Principal and Interest Payment [CD1.X27]
    /// </summary>
    public decimal? Ppc3MaximumPiPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 3-Maximum Principal and Interest Payment UI Value [CD1.XD27]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc3MaximumPiPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 3 - Mortgage Insurance Amount [CD1.X29]
    /// </summary>
    public decimal? Ppc3MiAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 3 - Mortgage Insurance Amount UI Value [CD1.XD29]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc3MiAmountUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 3 - Minimum Monthly Payment [CD1.X31]
    /// </summary>
    public decimal? Ppc3MinimumMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 3-Minimum Monthly Payment UI Value [CD1.XD31]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc3MinimumMonthlyPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 3 - Minimum Principal and Interest Payment [CD1.X26]
    /// </summary>
    public decimal? Ppc3MinimumPiPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 3-Minimum Principal and Interest Payment UI Value [CD1.XD26]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc3MinimumPiPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 3 - Year From [CD1.X24]
    /// </summary>
    public int? Ppc3YearFrom { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 3 - Year To [CD1.X25]
    /// </summary>
    public int? Ppc3YearTo { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 4 - Estimated Escrow Amount [CD1.X39]
    /// </summary>
    public decimal? Ppc4EstimatedEscrowAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 4 - Estimated Escrow Amount UI Value [CD1.XD39]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc4EstimatedEscrowAmountUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 4 - Interest Only [CD1.X37]
    /// </summary>
    public bool? Ppc4InterestOnly { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 4 - Maximum Monthly Payment [CD1.X41]
    /// </summary>
    public decimal? Ppc4MaximumMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 4-Maximum Monthly Payment UI Vavlue [CD1.XD41]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc4MaximumMonthlyPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 4 - Maximum Principal and Interest Payment [CD1.X36]
    /// </summary>
    public decimal? Ppc4MaximumPiPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 4-Maximum Principal and Interest Payment UI Value [CD1.XD36]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc4MaximumPiPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 4 - Mortgage Insurance Amount [CD1.X38]
    /// </summary>
    public decimal? Ppc4MiAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 4 - Mortgage Insurance Amount UI Value [CD1.XD38]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc4MiAmountUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 4 - Minimum Monthly Payment [CD1.X40]
    /// </summary>
    public decimal? Ppc4MinimumMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 4-Minimum Monthly Payment UI Value [CD1.XD40]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc4MinimumMonthlyPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 4 - Minimum Principal and Interest Payment [CD1.X35]
    /// </summary>
    public decimal? Ppc4MinimumPiPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 4-Minimum Principal and Interest Payment UI Value [CD1.XD35]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc4MinimumPiPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 4 - Year From [CD1.X33]
    /// </summary>
    public int? Ppc4YearFrom { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 4 - Year To [CD1.X34]
    /// </summary>
    public int? Ppc4YearTo { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Estimated Escrow Indicator [CD1.X43]
    /// </summary>
    public bool? PpcEstimatedEscrowIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Mortgage Insurance Indicator [CD1.X42]
    /// </summary>
    public bool? PpcMortgageInsuranceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 1 - Range Payment Indicator [CD1.XD1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? RangePaymentIndicatorC1 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 2 - Range Payment Indicator [CD1.XD2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? RangePaymentIndicatorC2 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 3 - Range Payment Indicator [CD1.XD3]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? RangePaymentIndicatorC3 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 4 - Range Payment Indicator [CD1.XD4]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? RangePaymentIndicatorC4 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - 24-hour Advanced Preview [CD1.X56]
    /// </summary>
    public bool? ReasonAdvancedReview { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Changed Circumstance - Eligibility [CD1.X68]
    /// </summary>
    public bool? ReasonChangedCircumstanceElg { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Reason Changed Circumstance Flags [CD1.X70]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ReasonChangedCircumstanceFlags { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Change in APR [CD1.X52]
    /// </summary>
    public bool? ReasonChangeInApr { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Change in Loan Product [CD1.X53]
    /// </summary>
    public bool? ReasonChangeInLoanProduct { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Change in Settlement Charges [CD1.X55]
    /// </summary>
    public bool? ReasonChangeSettlementCharges { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Clerical Error Correction [CD1.X58]
    /// </summary>
    public bool? ReasonClericalErrorCorrection { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Interest Rate dependent charges (Rate Lock) [CD1.X67]
    /// </summary>
    public bool? ReasonInterestRatecharges { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Other [CD1.X59]
    /// </summary>
    public bool? ReasonOther { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Other Description [CD1.X60]
    /// </summary>
    public string? ReasonOtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Prepayment Penalty Added [CD1.X54]
    /// </summary>
    public bool? ReasonPrepaymentPenalty { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Revisions requested by the Consumer [CD1.X66]
    /// </summary>
    public bool? ReasonRevisionsReqConsumer { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Tolerance Cure [CD1.X57]
    /// </summary>
    public bool? ReasonToleranceCure { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Revised CD Due Date [CD1.X63]
    /// </summary>
    public DateTime? RevisedCdDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Revised CD Received Date [CD1.X74]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? RevisedReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Seller Names [CD1.X2]
    /// </summary>
    public string? SellerNames { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Signature Type of final executed copy of the alternate CD [UCD.X4]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<FinalSignatureType> SignatureTypeFinalExecutedCopyofAlternateCd { get => GetValue<StringEnumValue<FinalSignatureType>>(); set => SetValue(value); }

    /// <summary>
    ///  Signature Type of final executed copy of the seller CD [UCD.X6]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<FinalSignatureType> SignatureTypeFinalExecutedCopyofSellerCd { get => GetValue<StringEnumValue<FinalSignatureType>>(); set => SetValue(value); }

    /// <summary>
    ///  Signature Type of final executed copy of the standard CD [UCD.X2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<FinalSignatureType> SignatureTypeFinalExecutedCopyofStandardCd { get => GetValue<StringEnumValue<FinalSignatureType>>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure - Total Cash To Close [CD1.X69]
    /// </summary>
    public decimal? TotalCashToClose { get => GetValue<decimal?>(); set => SetValue(value); }
}