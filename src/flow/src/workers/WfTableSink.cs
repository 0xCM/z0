//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static ProcessFx;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines a canonical table sink predicated on a process function
    /// </summary>
    public readonly struct WfTableSink<T> : ITableSink<WfTableSink<T>,T>        
        where T : struct, ITable<T>
    {       
        public IWfContext Wf {get;}
        
        readonly Receive<T> Fx;         
        
        [MethodImpl(Inline)]
        public WfTableSink(IWfContext wf, Receive<T> f)
        {
            Wf = wf;
            Fx = f;
        }
        
        [MethodImpl(Inline)]
        public void Deposit(in T x)
            => Fx(x);

        [MethodImpl(Inline)]
        public void Deposit(ReadOnlySpan<T> src)
        {
            var count = src.Length;
            ref readonly var table = ref first(src);
            for(var i=0; i<count; i++)
                 Fx(skip(table,i));
        }
    }
}