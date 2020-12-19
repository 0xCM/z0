//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct RecordFieldValues<T> : IRecordFieldValues<T>
        where T : struct
    {
        public T Source {get;}

        public RecordFields Fields {get;}

        public IndexedSeq<RecordFieldValue> Values {get;}

        [MethodImpl(Inline)]
        public RecordFieldValues(T source, RecordFields fields, RecordFieldValue[] values)
        {
            Source = source;
            Fields = fields;
            Values = values;
        }

        [MethodImpl(Inline)]
        public ref RecordFieldValue Value(ushort field)
            => ref Values[field];

        public ref RecordFieldValue this[ushort index]
        {
            [MethodImpl(Inline)]
            get => ref Values[index];
        }
    }
}