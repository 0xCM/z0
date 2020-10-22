//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XTend
    {
        /// <summary>
        /// Determines the numeric arity of a classified operator
        /// </summary>
        /// <param name="src">The operator class</param>
        public static int ArityValue(this ApiOperatorClass src)
            => IdentityReflector.ArityValue(src);
    }
}