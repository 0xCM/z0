//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct CallSite
    {
        public ICall Call {get;}

        public Var Receiver {get;}

        [MethodImpl(Inline)]
        public CallSite(ICall call, Var receiver)
        {
            Call = call;
            Receiver = receiver;
        }
    }
}