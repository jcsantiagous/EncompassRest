using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// FreddieServiceLqaLog
/// </summary>
public sealed partial class FreddieServiceLqaLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// FreddieServiceLqaLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// FreddieServiceLqaLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// FreddieServiceLqaLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FreddieServiceLqaLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// FreddieServiceLqaLog Details
    /// </summary>
    public string? Details { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FreddieServiceLqaLog FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// FreddieServiceLqaLog Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FreddieServiceLqaLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FreddieServiceLqaLog IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// FreddieServiceLqaLog LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// FreddieServiceLqaLog Name
    /// </summary>
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FreddieServiceLqaLog Result
    /// </summary>
    public string? Result { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FreddieServiceLqaLog ShowAlert
    /// </summary>
    public bool? ShowAlert { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// FreddieServiceLqaLog SystemId
    /// </summary>
    public string? SystemId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FreddieServiceLqaLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }
}