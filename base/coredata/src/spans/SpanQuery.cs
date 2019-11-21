//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    using static zfunc;

    /// <summary>
    /// Defines various methods that extract/interrogate span content
    /// </summary>
    partial class SpanExtend
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
        /// Returns a readonly reference to the first element of a nonempty span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T First<T>(this ReadOnlySpan<T> src)
        {
            if(src.IsEmpty)
                ThrowEmptySpanError();
            return ref MemoryMarshal.GetReference(src);
        }

        /// <summary>
        /// Returns a readonly reference to the last element of a nonempty span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T Last<T>(this ReadOnlySpan<T> src)
        {
            if(src.IsEmpty)
                ThrowEmptySpanError();
            return ref src[src.Length - 1];
        }

        /// <summary>
        /// Determines whether any elements of a span satisfy a supplied predicate
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The predicate</param>
        /// <typeparam name="T">The element type</typeparam>
        public static bool Any<T>(this ReadOnlySpan<T> src, Func<T,bool> f)
        {
            var it = src.GetEnumerator();
            while(it.MoveNext())
                if(f(it.Current))
                    return true;
            return false;
        }

        /// <summary>
        /// Determines whether any elements of a span satisfy a supplied predicate
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The predicate</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static bool Any<T>(this Span<T> src, Func<T,bool> f)
             where T : unmanaged
                => src.ReadOnly().Any(f);

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

        public static T Reduce<T>(this ReadOnlySpan<T> src, Func<T,T,T> f)
        {
            if(src.IsEmpty)
                ThrowEmptySpanError();
            else if(src.Length == 1)
                return MemoryMarshal.GetReference(src);
            
            var x = src[0];
            for(var i=1; i<src.Length; i++)
                x = f(x,src[i]);
            return x;            
        }


        [MethodImpl(Inline)]
        public static T Reduce<T>(this Span<T> src, Func<T,T,T> f)
            => src.ReadOnly().Reduce(f);        

        static void ThrowEmptySpanError()
            => throw new Exception($"The span is empty");

        static Exception unsupported<T>()
            => new Exception($"The type {typeof(T).Name} is unsupported");

    }
}