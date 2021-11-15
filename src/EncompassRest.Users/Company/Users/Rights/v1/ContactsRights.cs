using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ContactsRights
    /// </summary>
    public sealed class ContactsRights : DirtyExtensibleObject
    {
        private AccessToContactsTabRights? _accessToContactsTab;

        /// <summary>
        /// ContactsRights AccessToContactsTab
        /// </summary>
        [AllowNull]
        public AccessToContactsTabRights AccessToContactsTab { get => GetField(ref _accessToContactsTab); set => SetField(ref _accessToContactsTab, value); }
    }
}