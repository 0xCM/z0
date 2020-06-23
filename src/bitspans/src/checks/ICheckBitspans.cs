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

    public readonly struct CheckBitSpans : ICheckBitSpans
    {
        public static ICheckBitSpans Checker => default(CheckBitSpans);
    }
    
    public interface ICheckBitSpans : TValidator
    {
        /// <summary>
        /// Asserts the equality of two bitspans
        /// </summary>
        /// <param name="a">The left bitspan</param>
        /// <param name="b">The right bitspan</param>
        [MethodImpl(Inline)]
        void eq(in BitSpan a, in BitSpan b, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Require(a==b, ClaimKind.Eq);
    }
}