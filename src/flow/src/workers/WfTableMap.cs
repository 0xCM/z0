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
    using static ProcessFx;

    using static z;

    public readonly struct WfTableMap<D,S,T,Y> : ITableMap<WfTableMap<D,S,T,Y>, D,S,T,Y>
        where D : unmanaged, Enum
        where T : struct, ITable
        where S : unmanaged
    {
        public IWfContext Wf {get;}
        public Selector<D,S> Id {get;}
    
        readonly MapTable<T,Y> Fx;

        [MethodImpl(Inline)]
        public WfTableMap(IWfContext wf, MapTable<T,Y> f, Selector<D,S> id)
        {
            Wf = wf;
            Id = id;
            Fx = f;
        }
                
        [MethodImpl(Inline)]
        public Y Map(in T x)
            => Fx(x);
    }
}