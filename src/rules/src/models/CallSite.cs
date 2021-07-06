//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Lang;

    using static Root;

    partial struct Rules
    {
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
}