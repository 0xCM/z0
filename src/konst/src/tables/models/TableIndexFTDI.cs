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
    
    public readonly struct TableIndex<F,T,D,I> : ITableIndex<F,T,D,I>
        where F : unmanaged, Enum
        where D : unmanaged, Enum
        where T : struct, ITable<F,T,D>
        where I : unmanaged
    {
        readonly TableContent<F,T,D> Data;
        
        [MethodImpl(Inline)]
        public TableIndex(TableContent<F,T,D> data)
            => Data = data;
        
        public ReadOnlySpan<T> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }      

        public Span<T> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }      

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

        public ref T this[I index]
        {
            [MethodImpl(Inline)]
            get => ref Data[uint64(index)];
        }
    }
}