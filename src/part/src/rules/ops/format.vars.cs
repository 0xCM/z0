//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Rules
    {
        [Op]
        public static string format(IVar var)
            => string.Format("{0}:{1}",format(var.Symbol), var.Value);

        [Op]
        public static string format(VarContextKind vck, IVar var)
            => string.Format("{0}:{1}",format(vck, var.Symbol), var.Value);
    }
}