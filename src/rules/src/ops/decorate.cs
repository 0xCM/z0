//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct RuleModels
    {
        [MethodImpl(Inline), Op]
        public static VarDecoration decorate(VarName var, VarDecorator decorator)
            => var.Decorate(decorator);
    }
}