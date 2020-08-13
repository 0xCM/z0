//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct AsmTableSinks<T>
        where T : struct, ITable<T>
    {
        readonly WfTableSink<T>[] Data;

        [MethodImpl(Inline)]
        public static implicit operator AsmTableSinks<T>(WfTableSink<T>[] src)
            => new AsmTableSinks<T>(src);

        [MethodImpl(Inline)]
        public AsmTableSinks(params WfTableSink<T>[] src)
            => Data = src;
        
        public CellCount Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ReadOnlySpan<WfTableSink<T>> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<WfTableSink<T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref WfTableSink<T> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref z.seek(Edit, index);
        }

        public ref WfTableSink<T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref z.seek(Edit, (uint)index);
        }
    }
}