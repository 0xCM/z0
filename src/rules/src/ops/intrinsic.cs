//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RuleModels
    {
        [MethodImpl(Inline), Op]
        public static IntrinsicOperator intrinsic(string name, string notation, OperatorKind kind)
            => new IntrinsicOperator(name, notation, kind);
    }
}