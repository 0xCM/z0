//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Data;
    
    using static Konst;
    using static z;

    public readonly struct TableProcessors<D,S,T,Y>
        where D : unmanaged, Enum
        where T : struct, ITable
        where S : unmanaged
    {
        readonly TableProcessor<D,S,T,Y>[]  Data;

        [MethodImpl(Inline)]
        public static implicit operator TableProcessors<D,S,T,Y>(TableProcessor<D,S,T,Y>[] src)
            => new TableProcessors<D,S,T,Y>(src);
        
        [MethodImpl(Inline)]
        public TableProcessors(TableProcessor<D,S,T,Y>[] src)
        {
            Data = src;
        }
    
        public CellCount Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ReadOnlySpan<TableProcessor<D,S,T,Y>> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<TableProcessor<D,S,T,Y>> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }
       
    }
}