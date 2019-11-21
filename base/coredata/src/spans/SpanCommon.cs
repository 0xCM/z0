//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        [MethodImpl(Inline)]
        public static void CopyTo<T>(this Span<T> src, Span<T> dst, int offset)
            => src.CopyTo(dst.Slice(offset));

        [MethodImpl(Inline)]
        public static void CopyTo<T>(this ReadOnlySpan<T> src, Span<T> dst, int offset)
            => src.CopyTo(dst.Slice(offset));

        /// <summary>
        /// Forms a new span by the concatenation [head,tail]
        /// </summary>
        /// <param name="head">The first span</param>
        /// <param name="tail">The second span</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Concat<T>(this ReadOnlySpan<T> head, ReadOnlySpan<T> tail)
        {
            Span<T> dst = new T[head.Length + tail.Length];
            head.CopyTo(dst);
            tail.CopyTo(dst, head.Length);
            return dst;
        }

        /// <summary>
        /// Forms a new span by the concatenation [head,tail]
        /// </summary>
        /// <param name="head">The first span</param>
        /// <param name="tail">The second span</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Concat<T>(this Span<T> head, ReadOnlySpan<T> tail)
            => head.ReadOnly().Concat(tail);

        /// <summary>
        /// Presents a mutable span as a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ReadOnly<T>(this Span<T> src)
            => src;


        /// <summary>
        /// Fills an allocated span from a sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="dst">The target spn</param>
        /// <typeparam name="T">The element type</typeparam>
        public static Span<T> StreamTo<T>(this IEnumerable<T> src, Span<T> dst)
        {
            var i = 0;
            var e = src.GetEnumerator();
            while(e.MoveNext() && i < dst.Length)
                dst[i++] = e.Current;
            return dst;
        }            

        /// <summary>
        /// Fills a span of natural length with streamed elements
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="N">The span length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static void StreamTo<N,T>(this IEnumerable<T> src, NatBlock<N,T> dst, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Take(nati<N>()).StreamTo(dst.Unsized);


        /// <summary>
        /// Creates a new span by interposing a specified element between each element of an existing span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="x">The value to place between each element in the new span</param>
        /// <typeparam name="T">The element type</typeparam>
        public static Span<T> Intersperse<T>(this ReadOnlySpan<T> src, T x)
        {
            Span<T> dst = new T[src.Length*2 - 1];
            for(int i=0, j=0; i<src.Length; i++, j+= 2)
            {
                dst[j] = src[i];                
                if(i != src.Length - 1)
                    dst[j + 1] = x;                    
            }
            return dst;
        }

        /// <summary>
        /// Creates a new span by interposing a specified element between each element of an existing span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="x">The value to place between each element in the new span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static Span<T> Intersperse<T>(this Span<T> src, T x)
            => src.ReadOnly().Intersperse(x);

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
        [MethodImpl(Inline)]
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
        public static Span<T> Replicate<T>(this Span<T> src, bool structureOnly = false)
            => src.ReadOnly().Replicate(structureOnly);

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