//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XKinds
    {
        /// <summary>
        /// Determines the numeric arity of a classified operator
        /// </summary>
        /// <param name="src">The operator class</param>
        [MethodImpl(Inline), Op]
        public static int ArityValue(this ApiOperatorKind src)
            => IdentityReflector.ArityValue(src);
    }
}