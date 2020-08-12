//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct WfRunner : IWfRunner
    {
        readonly Action<string[]> Handler;        
        
        [MethodImpl(Inline)]
        public WfRunner(Action<string[]> handler)
        {
            Handler = handler;
        }

        [MethodImpl(Inline)]
        public void Run(params string[] args)        
            => Handler(args);
    }

    public readonly struct WfRunner<T,K> : IWfRunner<T,K>
        where T : struct, IWfStep<T,K>
        where K : unmanaged, Enum
    {
        readonly Action<string[]> Handler;        
        
        [MethodImpl(Inline)]
        public WfRunner(Action<string[]> handler)
        {
            Handler = handler;
        }

        [MethodImpl(Inline)]
        public void Run(params string[] args)        
            => Handler(args);
    }
}