//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    /// <summary>
    /// Defines various methods that extract/interrogate span content
    /// </summary>
    public static class SpanQuery
    {
        /// <summary>
        /// Returns a reference to the first element of a nonempty span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T First<T>(this Span<T> src)
        {
            if(src.IsEmpty)
                ThrowEmptySpanError();
            return ref MemoryMarshal.GetReference(src);
        }

        /// <summary>
        /// Returns a reference to the last element of a nonempty span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T Last<T>(this Span<T> src)
        {
            if(src.IsEmpty)
                ThrowEmptySpanError();
            return ref src[src.Length - 1];
        }

        /// <summary>
        /// Counts the number of values in the source that satisfy the predicate
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The predicate to evaluate over each element</param>
        /// <typeparam name="T">The element type</typeparam>
        public static int Count<T>(this ReadOnlySpan<T> src, Func<T,bool> f)
             where T : unmanaged
        {
            int count = 0;
            for(var i=0; i< src.Length; i++)
                if(f(src[i]))
                    count++;
            return count;
        }

        /// <summary>
        /// Counts the number of values in the source that satisfy the predicate
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The predicate to evaluate over each element</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static int Count<T>(this Span<T> src, Func<T,bool> f)
             where T : unmanaged
             => src.ReadOnly().Count(f);

        /// <summary>
        /// Determines whether all of the elements of a source span satisfy a supplied predicate
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The predicate</param>
        /// <typeparam name="T">The element type</typeparam>
        public static bool All<T>(this ReadOnlySpan<T> src, Func<T,bool> f)
             where T : unmanaged
        {
            var it = src.GetEnumerator();
            while(it.MoveNext())
                if(!f(it.Current))
                    return false;
            return true;
        }

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
            for(var i=0; i< lhs.Length; i++)
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

        static void ThrowEmptySpanError()
            => throw new Exception($"The span is empty");
    }
}