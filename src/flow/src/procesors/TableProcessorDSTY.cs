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

    public readonly struct TableProcessor<D,S,T,Y> : ITableProcessor<TableProcessor<D,S,T,Y>, D,S,T,Y>
        where D : unmanaged, Enum
        where T : struct, ITable
        where S : unmanaged
    {
        public Selector<D,S> Id {get;}

        [MethodImpl(Inline)]
        public TableProcessor(Selector<D,S> id)
        {
            Id = id;
        }
                
        [MethodImpl(Inline)]
        public Y Process(in T x)
        {
            return default;
        }    
    }
}