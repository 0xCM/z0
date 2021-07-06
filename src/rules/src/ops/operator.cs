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
        [MethodImpl(Inline), Op]
        public static IntrinsicOperator @operator(string name, string notation, OperatorKind kind)
            => new IntrinsicOperator(name, notation, kind);
    }
}