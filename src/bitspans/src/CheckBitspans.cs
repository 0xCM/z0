//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;
    using api = ClaimValidator;

    public readonly struct CheckBitSpans : IClaimValidator
    {
        /// <summary>
        /// Asserts the equality of two bitspans
        /// </summary>
        /// <param name="a">The left bitspan</param>
        /// <param name="b">The right bitspan</param>
        [MethodImpl(Inline)]
        public static void eq(in BitSpan32 a, in BitSpan32 b, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.require(a==b, ClaimKind.Eq);

        /// <summary>
        /// Asserts the equality of two bitspans
        /// </summary>
        /// <param name="a">The left bitspan</param>
        /// <param name="b">The right bitspan</param>
        [MethodImpl(Inline)]
        public static void eq(in BitSpan a, in BitSpan b, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.require(a==b, ClaimKind.Eq);
    }
}