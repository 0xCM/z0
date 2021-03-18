//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    /// <summary>
    /// Defines a canonical table sink predicated on a process function
    /// </summary>
    public readonly struct WfSink<T> : IWfSink<WfSink<T>,T>
    {
        public IWfShell Wf {get;}

        readonly Receiver<T> Fx;

        [MethodImpl(Inline)]
        public WfSink(IWfShell wf, Receiver<T> f)
        {
            Wf = wf;
            Fx = f;
        }

        [MethodImpl(Inline)]
        public void Deposit(T x)
            => Fx(x);

        [MethodImpl(Inline)]
        public void Deposit(ReadOnlySpan<T> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                 Fx(skip(src,i));
        }
    }
}