//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class XTend
    {
        /// <summary>
        /// Evaluates whether two spans have identical content
        /// </summary>
        /// <param name="a">The left span</param>
        /// <param name="b">The right span</param>
        /// <typeparam name="T">The value type</typeparam>
        [Op, Closures(Closure)]
        public static bool ValuesEqual<T>(this ReadOnlySpan<T> a, ReadOnlySpan<T> b)
            where T : unmanaged, IEquatable<T>
        {
            var count = a.Length;
            if(count != b.Length)
                return false;

            for(var i=0; i<count; i++)
                if(!a[i].Equals(b[i]))
                    return false;
            return true;
        }

        /// <summary>
        /// Evaluates whether two spans have identical content
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <typeparam name="T">The value type</typeparam>
        [Op, Closures(Closure)]
        public static bool ValuesEqual<T>(this Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged, IEquatable<T>
                => lhs.ReadOnly().ValuesEqual(rhs);
    }
}