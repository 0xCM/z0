//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RP
    {
        [Op]
        public static string assign(object lhs, object rhs, bool spaced = true)
            => string.Format(spaced ? RP.SpacedAssign : RP.Assign, lhs, rhs);
    }
}