//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Identifies and describes a method that, whithin some useful scope, is unique
    /// </summary>
    public static class MethodSigX
    {
        /// <summary>
        /// Derives a signature from reflected method metadata
        /// </summary>
        /// <param name="src">The source method</param>
        [MethodImpl(Inline)]
        public static MethodSig Signature(this MethodInfo src)
            => MethodSig.Define(src);
    }
}
