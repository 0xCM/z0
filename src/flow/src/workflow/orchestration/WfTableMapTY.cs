//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Data;
    
    using static ProcessFx;

    using static Konst;
    using static z;

    public readonly struct WfTableMap<T,Y> : ITableMap<WfTableMap<T,Y>,T,Y>        
        where T : struct, ITable
    {       
        public IWfContext Wf {get;}
        
        readonly MapTable<T,Y> Fx;         
        
        public WfTableMap(IWfContext wf, MapTable<T,Y> f)
        {
            Wf = wf;
            Fx = f;
        }
        
        [MethodImpl(Inline)]
        public Y Map(in T x)
            => Fx(x);
    }
}