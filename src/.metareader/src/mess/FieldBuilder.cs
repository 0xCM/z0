//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;

    using Z0.MS;

    public class FieldBuilder : IFieldData, IDisposable
    {
        IFieldHelpers? _helpers;

        FieldData _fieldData;

        public IFieldHelpers Helpers => _helpers!;

        public ClrMdTypeCode ElementType
            => (ClrMdTypeCode)_fieldData.ElementType;

        public int Token => (int)_fieldData.FieldToken;

        public int Offset => (int)_fieldData.Offset;

        public ulong TypeMethodTable
            => _fieldData.TypeMethodTable;

        public Dac.DacObjectPool<FieldBuilder>? Owner { get; set; }

        public ulong NextField => _fieldData.NextField;

        public bool IsContextLocal
            => _fieldData.IsContextLocal != 0;

        public bool IsStatic
            => _fieldData.IsStatic != 0;

        public bool IsThreadLocal
            => _fieldData.IsThreadLocal != 0;

        internal bool Init(SOSDac sos, ulong fieldDesc, IFieldHelpers helpers)
        {
            _helpers = helpers;
            return sos.GetFieldData(fieldDesc, out _fieldData);
        }

        public void Dispose()
        {
            _helpers = null;
            var owner = Owner;
            Owner = null;
            owner?.Return(this);
        }
    }
}