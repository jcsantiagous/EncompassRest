using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class TrustAccount : IDirty
    {
        private DirtyValue<decimal?> _balance;
        public decimal? Balance { get { return _balance; } set { _balance = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _total1;
        public decimal? Total1 { get { return _total1; } set { _total1 = value; } }
        private DirtyValue<decimal?> _total2;
        public decimal? Total2 { get { return _total2; } set { _total2 = value; } }
        private DirtyList<TrustAccountItem> _trustAccountItems;
        public IList<TrustAccountItem> TrustAccountItems { get { var v = _trustAccountItems; return v ?? Interlocked.CompareExchange(ref _trustAccountItems, (v = new DirtyList<TrustAccountItem>()), null) ?? v; } set { _trustAccountItems = new DirtyList<TrustAccountItem>(value); } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _balance.Dirty
                    || _id.Dirty
                    || _total1.Dirty
                    || _total2.Dirty
                    || _trustAccountItems?.Dirty == true;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _balance.Dirty = value;
                _id.Dirty = value;
                _total1.Dirty = value;
                _total2.Dirty = value;
                if (_trustAccountItems != null) _trustAccountItems.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}