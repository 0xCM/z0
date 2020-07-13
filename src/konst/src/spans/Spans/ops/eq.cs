//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    using static z;

    partial class Spans
    {
        [MethodImpl(Inline)]
        public static bool eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : IEquatable<T>
        {
            var count = length(lhs,rhs);
            for(var i=0u; i<count; i++)
                if(!skip(lhs, i).Equals(skip(rhs, i)))
                    return false;
            return true;
        }

        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline), Op]
        public static bool eq(ReadOnlySpan<char> lhs, ReadOnlySpan<char> rhs)  
            => eq<char>(lhs,rhs);

        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        public static bool eq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)  
            => eq<byte>(lhs,rhs);

        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        public static bool eq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)  
            => eq<int>(lhs,rhs);

        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        public static bool eq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)  
            => eq<uint>(lhs,rhs);

        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        public static bool eq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)  
            => eq<ulong>(lhs,rhs);
    }
}