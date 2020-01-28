//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    /// <summary>
    /// Defines embedded data resource identifiers
    /// </summary>
    public readonly struct ResourceIdentity
    {
        /// <summary>
        /// Defines a canonical data resource identifier
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public static string define(string basename, ITypeNat w, NumericKind kind)
            => $"{basename}{w}x{primalsig(kind)}";

        /// <summary>
        /// Defines a canonical data resource identifier
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]
        public static string define(string basename, ITypeNat w1, ITypeNat w2, NumericKind kind)
            => $"{basename}{w1}x{w2}x{primalsig(kind)}";
    }

}