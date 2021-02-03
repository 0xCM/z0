//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CallSite
    {
        public Call Call {get;}

        public Var Receiver {get;}

        [MethodImpl(Inline)]
        public CallSite(Call call, Var receiver)
        {
            Call = call;
            Receiver = receiver;
        }
    }
}