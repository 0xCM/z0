//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct FunctioFn<D,B>
    {
        public D Declaration {get;}

        public B Body {get;}
    }
}