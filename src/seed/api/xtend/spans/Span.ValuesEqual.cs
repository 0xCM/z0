//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Evaluates whether two spans have identical content
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <typeparam name="T">The value type</typeparam>
        public static bool ValuesEqual<T>(this ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged, IEquatable<T>
        {
            if(lhs.Length != rhs.Length)
                return false;
            
            for(var i=0; i<lhs.Length; i++)
                if(!lhs[i].Equals(rhs[i]))
                    return false;
            return true;
        }

        /// <summary>
        /// Evaluates whether two spans have identical content
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static bool ValuesEqual<T>(this Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged, IEquatable<T>
                => lhs.ReadOnly().ValuesEqual(rhs);        
    }
}