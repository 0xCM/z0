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

    public readonly struct WfTableMaps<D,S,T,Y>
        where D : unmanaged, Enum
        where T : struct, ITable
        where S : unmanaged
    {
        readonly WfTableMap<D,S,T,Y>[]  Data;

        [MethodImpl(Inline)]
        public static implicit operator WfTableMaps<D,S,T,Y>(WfTableMap<D,S,T,Y>[] src)
            => new WfTableMaps<D,S,T,Y>(src);
        
        [MethodImpl(Inline)]
        public WfTableMaps(WfTableMap<D,S,T,Y>[] src)
        {
            Data = src;
        }
    
        public CellCount Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ReadOnlySpan<WfTableMap<D,S,T,Y>> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<WfTableMap<D,S,T,Y>> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }
       
    }
}