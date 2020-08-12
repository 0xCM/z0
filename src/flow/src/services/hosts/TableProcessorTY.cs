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

    public readonly struct TableProcessor<T,Y> : ITableProcessor<TableProcessor<T,Y>,T,Y>        
        where T : struct, ITable
    {       
        public IWfContext Wf {get;}
        
        readonly ProcessTable<T,Y> Fx;         
        
        public TableProcessor(IWfContext wf, ProcessTable<T,Y> f)
        {
            Wf = wf;
            Fx = f;
        }
        
        [MethodImpl(Inline)]
        public Y Process(in T x)
            => Fx(x);
    }
}