//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct RecordFieldValue : IRecordFieldValue
    {
        public ushort FieldIndex {get;}

        public object FieldValue {get;}

        [MethodImpl(Inline)]
        public RecordFieldValue(ushort index, object value)
        {
            FieldIndex = index;
            FieldValue = value;
        }

        public static implicit operator RecordFieldValue((ushort index, object value) src)
            => new RecordFieldValue(src.index, src.value);
    }
}