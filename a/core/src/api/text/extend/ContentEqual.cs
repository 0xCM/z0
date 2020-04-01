//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;

    partial class XTend
    {
        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static bool ContentEqual(this ReadOnlySpan<char> lhs, ReadOnlySpan<char> rhs)        
             => lhs.CompareTo(rhs, StringComparison.InvariantCulture) == 0;

        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static bool ContentEqual(this Span<char> lhs, ReadOnlySpan<char> rhs)        
             => lhs.ReadOnly().ContentEqual(rhs);

        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static bool ContentEqual(this Span<char> lhs, Span<char> rhs)        
             => lhs.ReadOnly().ContentEqual(rhs);
    }
}