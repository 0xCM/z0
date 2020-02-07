//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    readonly struct AmsEmissionSink : IAsmEmissionSink
    {
        readonly Action<AsmEmissionGroup> Receiver;        
                
        [MethodImpl(Inline)]
        public static IAsmEmissionSink Create(Action<AsmEmissionGroup> receiver)
            => new AmsEmissionSink(receiver);
        
        [MethodImpl(Inline)]
        AmsEmissionSink(Action<AsmEmissionGroup> receiver)
            => Receiver = receiver;
        
        [MethodImpl(Inline)]
        public void Accept(in AsmEmissionGroup src)
            => Receiver(src);
    }

}