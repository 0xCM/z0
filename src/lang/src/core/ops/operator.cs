//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct lang
    {
        [MethodImpl(Inline), Op]
        public static IntrinsicOperator @operator(Identifier name, Name notation, OperatorKind kind)
            => new IntrinsicOperator(name, notation, kind);
    }
}