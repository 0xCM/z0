//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;
    using static nfunc;

    public static partial class SpanExtend
    {
        /// <summary>
        /// Fills a span of natural length with streamed elements
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="N">The span length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static void StreamTo<N,T>(this IEnumerable<T> src, NatSpan<N,T> dst, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Take(nati<N>()).StreamTo(dst.Data);

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

        /// <summary>
        /// Fills a span with a supplied valuie
        /// </summary>
        /// <param name="src">The span to manipulate</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <returns>The manipulated span</returns>
        [MethodImpl(Inline)]
        public static Span<T> FillWith<T>(this Span<T> src, T value)
        {
            src.Fill(value);
            return src;
        }

        /// <summary>
        /// Overwrites span content with the default/zero value
        /// </summary>
        /// <param name="src">The span to manipulate</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <returns>The manipulated span</returns>
        [MethodImpl(Inline)]
        public static Span<T> ZeroFill<T>(this Span<T> src)
            where T : unmanaged
        {
            src.Fill(default(T));
            return src;
        }
            
        /// <summary>
        /// If the length of a source span is less than a specified length, a new span of the desired length
        /// is allocated and then filled with the source span content; otherwise, the source span is returned
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="minlen">The desired minimum length</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Extend<T>(this Span<T> src, int minlen)
        {
            if(src.Length >= minlen)
                return src;
            else
            {
                Span<T> dst = new T[minlen];
                src.CopyTo(dst); 
                return dst;               
            }
        }
        
        [MethodImpl(Inline)]
        public static Span<T> ExtendSlice<T>(this Span<T> src, int offset, int slicelen)
        {
            var available = src.Length - offset;            
            if(available <= slicelen)
                return src.Slice(offset,slicelen);
            else
            {
                Span<T> dst = new T[slicelen];
                if(available <= 0)
                    return dst;

                src.Slice(offset).CopyTo(dst);
                    return dst;
            }                        
        }

        /// <summary>
        /// Produces a reversed span from a readonly span
        /// </summary>
        /// <param name="src">The soruce span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Reverse<T>(this ReadOnlySpan<T> src) 
        {       
            var dst = src.ToSpan();
            dst.Reverse();
            return dst;
        }

        /// <summary>
        /// Clones the source span into a new span
        /// </summary>
        /// <param name="src">The span to replicate</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <returns>Returns the replicated span</returns>
        [MethodImpl(NotInline)]
        public static Span<T> Replicate<T>(this ReadOnlySpan<T> src, bool structureOnly = false)
        {
            Span<T> dst = new T[src.Length];
            if(!structureOnly)
                src.CopyTo(dst);
            return dst;
        }

        /// <summary>
        /// Clones the source span into a new span
        /// </summary>
        /// <param name="src">The span to replicate</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <returns>Returns the replicated span</returns>
        [MethodImpl(Inline)]
        public static Span<T> Replicate<T>(this Span<T> src, bool structureOnly)
            => src.ReadOnly().Replicate(structureOnly);

        /// <summary>
        /// Clones the source span into a new span
        /// </summary>
        /// <param name="src">The span to replicate</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <returns>Returns the replicated span</returns>
        [MethodImpl(Inline)]
        public static Span<T> Replicate<T>(this Span<T> src)
            => src.ReadOnly().Replicate();

        /// <summary>
        /// Projects a source span to target span via a supplied transformation
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="f">The transformation</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static Span<T> Map<S,T>(this ReadOnlySpan<S> src, Func<S, T> f)
        {
            Span<T> dst = new T[src.Length];
            for(var i= 0; i<src.Length; i++)
                dst[i] = f(src[i]);
            return dst;
        }

        /// <summary>
        /// Projects a source span to target span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The projector</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Map<S,T>(this Span<S> src, Func<S, T> f)
            => src.ReadOnly().Map(f);

        /// <summary>
        /// Projects a range of elements from a source span to a target span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The source offset</param>
        /// <param name="length">The length of the segment to project</param>
        /// <param name="f">The projector</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static Span<T> MapRange<S,T>(this ReadOnlySpan<S> src, int offset, int length, Func<S, T> f)
        {
            Span<T> dst = new T[length];
            for (int i = offset; i < length; i++)
                dst[i] = f(src[i]);
            return dst;
        }

        /// <summary>
        /// Projects a range of elements from a source span to a target span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The source offset</param>
        /// <param name="length">The length of the segment to project</param>
        /// <param name="f">The projector</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> MapRange<S,T>(this Span<S> src, int offset, int length, Func<S, T> f)
            => src.ReadOnly().MapRange(offset,length, f);
    }
}