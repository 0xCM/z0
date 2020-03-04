//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;    
    using System.Runtime.Intrinsics;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public static class Spans
    {    
        /// <summary>
        /// Loads a span from a memory reference
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="count">The number of source cells to read</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]   
        public static ReadOnlySpan<T> view<T>(in T src, int count)
            => MemoryMarshal.CreateReadOnlySpan(ref Unsafe.AsRef(in src), count);

        /// <summary>
        /// Loads a span from a memory reference
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="count">The number of source cells to read</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<T> manipulate<T>(ref T src, int count)
            => MemoryMarshal.CreateSpan(ref src, count);

        /// <summary>
        /// Allocates a span
        /// </summary>
        /// <param name="length">The number cells to allocate</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(NotInline)]
        public static Span<T> alloc<T>(int length, T t = default)
            => new Span<T>(new T[length]);

        /// <summary>
        /// Allocates a span
        /// </summary>
        /// <param name="length">The number cells to allocate</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(NotInline)]
        public static Span<T> alloc<T>(ushort length, T t = default)
            => new Span<T>(new T[length]);

        /// <summary>
        /// Allocates a span
        /// </summary>
        /// <param name="length">The number cells to allocate</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(NotInline)]
        public static Span<T> alloc<T>(byte length, T t = default)
            => new Span<T>(new T[length]);

        [MethodImpl(Inline)]
        public static unsafe Span<T> span<T>(T* pSrc, int length)
            where T : unmanaged
                => new Span<T>(pSrc, length);

        /// <summary>
        /// Constructs a span from a parameter array
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> span<T>(params T[] src)
            => src;
        /// <summary>
        /// Reimagines a readonly span of one element type as a readonly span of another element type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> cast<S,T>(ReadOnlySpan<S> src)                
            where S : unmanaged
            where T : unmanaged
                => MemoryMarshal.Cast<S,T>(src);

        /// <summary>
        /// Reimagines a span of one element type as a span of another element type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> cast<S,T>(Span<S> src)                
            where S : unmanaged
            where T : unmanaged
                => MemoryMarshal.Cast<S,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<byte> src, int offset, int length)
            where T : unmanaged
                => MemoryMarshal.Cast<byte,T>(src.Slice(offset, length * Unsafe.SizeOf<T>()));

        [MethodImpl(Inline)]
        public static Span<T> cast<T>(Span<byte> src, int offset, int length)
            where T : unmanaged
                => MemoryMarshal.Cast<byte,T>(src.Slice(offset, length * Unsafe.SizeOf<T>()));
        
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<byte> src)
            where T : unmanaged
                => cast<T>(src, 0, src.Length/Unsafe.SizeOf<T>());

        [MethodImpl(Inline)]
        public static Span<T> cast<T>(Span<byte> src)
            where T : unmanaged        
                => cast<T>(src, 0, src.Length/Unsafe.SizeOf<T>());

        [MethodImpl(Inline)]
        public static Span<T> cast<T>(Span<byte> src, out Span<byte> rem)
            where T : unmanaged        
        {
            rem = Span<byte>.Empty;
            var tSize = Unsafe.SizeOf<T>();
            var dst = cast<T>(src);
            var q = Math.DivRem(dst.Length, tSize, out int r);
            if(r != 0)
                rem = src.Slice(dst.Length*tSize);
            return dst;
        }            

        /// <summary>
        /// Presents a span of generic values as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        public static Span<byte> bytes<T>(Span<T> src)
            where T : unmanaged
                => MemoryMarshal.AsBytes(src);

        /// <summary>
        /// Presents a span of generic values as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> span8u<T>(Span<T> src)
            where T : unmanaged
                => Spans.cast<T,byte>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a span of signed bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<sbyte> span8i<T>(Span<T> src)
            where T : unmanaged
                => Spans.cast<T,sbyte>(src);

        /// <summary>
        /// Presents a span of generic values as a span of signed 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<short> span16i<T>(Span<T> src)
            where T : unmanaged        
                => Spans.cast<T,short>(src);

        /// <summary>
        /// Presents a span of generic values as a span of unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<ushort> span16u<T>(Span<T> src)
            where T : unmanaged        
                => Spans.cast<T,ushort>(src);

        /// <summary>
        /// Presents a span of generic values as a span of signed 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<int> span32i<T>(Span<T> src)
            where T : unmanaged        
                => Spans.cast<T,int>(src);

        /// <summary>
        /// Presents a span of generic values as a span of unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<uint> span32u<T>(Span<T> src)
            where T : unmanaged        
                => Spans.cast<T,uint>(src);

        /// <summary>
        /// Presents a span of generic values as a span of 64-bit signed integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<long> span64i<T>(Span<T> src)
            where T : unmanaged        
                => Spans.cast<T,long>(src);

        /// <summary>
        /// Presents a span of generic values as a span of 64-bit unsigned integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<ulong> span64u<T>(Span<T> src)
            where T : unmanaged        
                => Spans.cast<T,ulong>(src);

        /// <summary>
        /// Presents a span of generic values as a span of 32-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<float> span32f<T>(Span<T> src)
            where T : unmanaged        
                => Spans.cast<T,float>(src);

        /// <summary>
        /// Presents a span of generic values as a span of 64-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<double> span64f<T>(Span<T> src)
            where T : unmanaged        
                => cast<T,double>(src);

        /// <summary>
        /// Presents a readonly span ofgeneric values as a readonly span of signed bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<sbyte> span8i<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => Spans.cast<T,sbyte>(src);

        /// <summary>
        /// Presents a readonly span ofgeneric values as a readonly span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> span8u<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => MemoryMarshal.AsBytes(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of signed 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<short> span16i<T>(ReadOnlySpan<T> src)
            where T : unmanaged        
                => Spans.cast<T,short>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<ushort> span16u<T>(ReadOnlySpan<T> src)
            where T : unmanaged        
                => Spans.cast<T,ushort>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of signed 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<int> span32i<T>(ReadOnlySpan<T> src)
            where T : unmanaged        
                => Spans.cast<T,int>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<uint> span32u<T>(ReadOnlySpan<T> src)
            where T : unmanaged        
                => Spans.cast<T,uint>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of 64-bit signed integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<long> span64i<T>(ReadOnlySpan<T> src)
            where T : unmanaged        
                => Spans.cast<T,long>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of 64-bit unsigned integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<ulong> span64u<T>(ReadOnlySpan<T> src)
            where T : unmanaged        
                => Spans.cast<T,ulong>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of 32-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<float> span32f<T>(ReadOnlySpan<T> src)
            where T : unmanaged        
                => Spans.cast<T,float>(src);

        /// <summary>
        /// Presents a readonly readonly span of generic values as a readonly readonly span of 64-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<double> span64f<T>(ReadOnlySpan<T> src)
            where T : unmanaged        
                => Spans.cast<T,double>(src);        

        [MethodImpl(Inline)]   
        public static ISet<T> set<T>(ReadOnlySpan<T> src)
        {
            var dst = new HashSet<T>(src.Length);
            for(var i=0; i<src.Length; i++)
                dst.Add(src[i]);
            return dst;
        }

        [MethodImpl(Inline)]   
        public static ISet<T> set<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b)
        {
            var dst = new HashSet<T>(a.Length + b.Length);
            for(var i=0; i<a.Length; i++)
                dst.Add(a[i]);
            for(var i=0; i<b.Length; i++)
                dst.Add(b[i]);
            return dst;     
        }

        /// <summary>
        /// Returns the common length of the operands if they are the same; otherwise, raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static int length<T>(Span<T> lhs, ReadOnlySpan<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.Length == rhs.Length ? lhs.Length : throw errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

        /// <summary>
        /// Returns the common length of the operands if they are the same; otherwise, raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static int length<T>(IReadOnlyList<T> lhs, ReadOnlySpan<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null) 
            => lhs.Count == rhs.Length ? lhs.Count : throw errors.LengthMismatch(lhs.Count, rhs.Length, caller, file, line);

        /// <summary>
        /// Returns the common length of the operands if they are the same; otherwise, raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <typeparam name="T">The element type of the first operand</typeparam>
        /// <typeparam name="S">The element type of the second operand</typeparam>
        [MethodImpl(Inline)]   
        public static int length<S,T>(Span<S> lhs, Span<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.Length == rhs.Length ? lhs.Length : throw errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

        /// <summary>
        /// Returns the common length of the operands if they are the same; otherwise, raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <typeparam name="T">The element type of the first operand</typeparam>
        /// <typeparam name="S">The element type of the second operand</typeparam>
        [MethodImpl(Inline)]   
        public static int length<S,T>(ReadOnlySpan<S> lhs, Span<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.Length == rhs.Length ? lhs.Length : throw errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

        /// <summary>
        /// Returns the common length of the operands if they are the same; otherwise, raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <typeparam name="T">The element type of the first operand</typeparam>
        /// <typeparam name="S">The element type of the second operand</typeparam>
        [MethodImpl(Inline)]   
        public static int length<S,T>(ReadOnlySpan<S> lhs, ReadOnlySpan<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs.Length == rhs.Length ? lhs.Length : throw errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);


        [MethodImpl(Inline)]
        public static Span<T3> apply<F,T0,T1,T2,T3>(F f, ReadOnlySpan<T0> A, ReadOnlySpan<T1> B, ReadOnlySpan<T2> C,  Span<T3> dst)
            where F : ITernaryFunc<T0,T1,T2,T3>
        {
            var count = dst.Length;
            ref readonly var a = ref head(A);
            ref readonly var b = ref head(B);
            ref readonly var c = ref head(C);
            ref var target = ref head(dst);

            for(var i=0; i<count; i++)
                seek(ref target, i) = f.Invoke(skip(in a, i), skip(in b, i), skip(in c, i));
            return dst;
        }        

        [MethodImpl(Inline)]
        public static Span<T2> apply<F,T0,T1,T2>(F f, ReadOnlySpan<T0> lhs, ReadOnlySpan<T1> rhs, Span<T2> dst)
            where F : IBinaryFunc<T0,T1,T2>
        {
            var count = dst.Length;
            ref readonly var lSrc = ref head(lhs);
            ref readonly var rSrc = ref head(rhs);
            ref var target = ref head(dst);

            for(var i=0; i<count; i++)
                seek(ref target, i) = f.Invoke(skip(in lSrc, i), skip(in rSrc, i));
            return dst;
        }        


        [MethodImpl(Inline)]
        public static Span<bit> apply<F,T>(F f, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bit> dst)
            where F : IBinaryPred<T>
        {
            var count = dst.Length;
            ref readonly var lSrc = ref head(lhs);
            ref readonly var rSrc = ref head(rhs);
            ref var target = ref head(dst);

            for(var i=0; i<count; i++)
                seek(ref target, i) = f.Invoke(skip(in lSrc, i), skip(in rSrc, i));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T2> apply<F,T1,T2>(F f, ReadOnlySpan<T1> src, Span<T2> dst)
            where F : IUnaryFunc<T1,T2>
        {
            var count = dst.Length;
            ref readonly var input = ref head(src);
            ref var target = ref head(dst);

            for(var i=0; i<count; i++)
                seek(ref target, i) = f.Invoke(skip(in input, i));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bit> apply<F,T>(F f, ReadOnlySpan<T> src, Span<bit> dst)
            where F : IUnaryPred<T>
        {
            var count = dst.Length;
            ref readonly var input = ref head(src);
            ref var target = ref head(dst);

            for(var i=0; i<count; i++)
                seek(ref target, i) = f.Invoke(skip(in input, i));
            return dst;
        }
    }    
}