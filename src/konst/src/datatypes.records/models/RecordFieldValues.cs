//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public struct RecordFieldValues : IRecordFieldValues
    {
        public object Source {get;}

        public RecordFields Fields {get;}

        public IndexedSeq<RecordFieldValue> Values {get;}

        [MethodImpl(Inline)]
        public RecordFieldValues(object src, RecordFields fields, RecordFieldValue[] values)
        {
            Source = src;
            Fields = fields;
            Values = values;
        }

        [MethodImpl(Inline)]
        public ref RecordFieldValue Value(ushort index)
            => ref Values[index];

        public ref RecordFieldValue this[ushort index]
        {
            [MethodImpl(Inline)]
            get => ref Value(index);
        }
    }
}