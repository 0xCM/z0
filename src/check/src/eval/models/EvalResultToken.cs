//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [SymbolSource]
    public enum EvalResultToken : byte
    {
        None,

        [Symbol("==")]
        Eq,

        [Symbol("!=")]
        NEq,

        [Symbol("<")]
        Lt,

        [Symbol("<=")]
        LtEq,

        [Symbol(">")]
        Gt,

        [Symbol(">=")]
        GtEq
    }

}