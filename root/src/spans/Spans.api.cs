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
        public static Span<T> edit<T>(ref T src, int count)
            => MemoryMarshal.CreateSpan(ref src, count);

        /// <summary>
        /// Covers a memory segment with a generic span
        /// </summary>
        /// <param name="pSrc">The memory source</param>
        /// <param name="size">The number of bytes to cover</param>
        /// <typeparam name="T">The span cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Span<T> cover<T>(T* pSrc, ByteSize size)
            where T : unmanaged
                => new Span<T>(pSrc, size);

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
        public static Span<byte> s8u<T>(Span<T> src)
            where T : unmanaged
                => cast<T,byte>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a span of signed bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<sbyte> s8i<T>(Span<T> src)
            where T : unmanaged
                => cast<T,sbyte>(src);

        /// <summary>
        /// Presents a span of generic values as a span of signed 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<short> s16i<T>(Span<T> src)
            where T : unmanaged        
                => cast<T,short>(src);

        /// <summary>
        /// Presents a span of generic values as a span of unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<ushort> s16u<T>(Span<T> src)
            where T : unmanaged        
                => cast<T,ushort>(src);

        /// <summary>
        /// Presents a span of generic values as a span of signed 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<int> s32i<T>(Span<T> src)
            where T : unmanaged        
                => cast<T,int>(src);

        /// <summary>
        /// Presents a span of generic values as a span of unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<uint> s32u<T>(Span<T> src)
            where T : unmanaged        
                => cast<T,uint>(src);

        /// <summary>
        /// Presents a span of generic values as a span of 64-bit signed integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<long> s64i<T>(Span<T> src)
            where T : unmanaged        
                => cast<T,long>(src);

        /// <summary>
        /// Presents a span of generic values as a span of 64-bit unsigned integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<ulong> s64u<T>(Span<T> src)
            where T : unmanaged        
                => cast<T,ulong>(src);

        /// <summary>
        /// Presents a span of generic values as a span of 32-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<float> s32f<T>(Span<T> src)
            where T : unmanaged        
                => cast<T,float>(src);

        /// <summary>
        /// Presents a span of generic values as a span of 64-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<double> s64f<T>(Span<T> src)
            where T : unmanaged        
                => cast<T,double>(src);

        /// <summary>
        /// Presents a readonly span ofgeneric values as a readonly span of signed bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<sbyte> s8i<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => cast<T,sbyte>(src);

        /// <summary>
        /// Presents a readonly span ofgeneric values as a readonly span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> s8u<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => MemoryMarshal.AsBytes(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of signed 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<short> s16i<T>(ReadOnlySpan<T> src)
            where T : unmanaged        
                => cast<T,short>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<ushort> s16u<T>(ReadOnlySpan<T> src)
            where T : unmanaged        
                => cast<T,ushort>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of signed 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<int> s32i<T>(ReadOnlySpan<T> src)
            where T : unmanaged        
                => cast<T,int>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<uint> s32u<T>(ReadOnlySpan<T> src)
            where T : unmanaged        
                => cast<T,uint>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of 64-bit signed integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<long> s64i<T>(ReadOnlySpan<T> src)
            where T : unmanaged        
                => cast<T,long>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of 64-bit unsigned integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<ulong> s64u<T>(ReadOnlySpan<T> src)
            where T : unmanaged        
                => cast<T,ulong>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of 32-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<float> s32f<T>(ReadOnlySpan<T> src)
            where T : unmanaged        
                => cast<T,float>(src);

        /// <summary>
        /// Presents a readonly readonly span of generic values as a readonly readonly span of 64-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<double> s64f<T>(ReadOnlySpan<T> src)
            where T : unmanaged        
                => cast<T,double>(src);        

        [MethodImpl(Inline)]
        public static ReadOnlySpan<sbyte> s8i<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => cast<T,sbyte>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> s8u<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => cast<T,byte>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<short> s16i<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => cast<T,short>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<ushort> s16u<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => cast<T,ushort>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<int> s32i<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => cast<T,int>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<uint> s32u<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => cast<T,uint>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<long> s64i<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => cast<T,long>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<ulong> s64u<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => cast<T,ulong>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<float> s32f<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => cast<T,float>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<double> s64f<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => cast<T,double>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> from<T>(in ReadOnlyMemory<sbyte> src)
            where T : unmanaged
                => cast<sbyte,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> from<T>(in ReadOnlyMemory<byte> src)
            where T : unmanaged
                => cast<byte,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> from<T>(in ReadOnlyMemory<short> src)
            where T : unmanaged
                => cast<short,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> from<T>(in ReadOnlyMemory<ushort> src)
            where T : unmanaged
                => cast<ushort,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> from<T>(in ReadOnlyMemory<int> src)
            where T : unmanaged
                => cast<int,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> from<T>(in ReadOnlyMemory<uint> src)
            where T : unmanaged
                => cast<uint,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<long> src)
            where T : unmanaged
                => cast<long,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> from<T>(in ReadOnlyMemory<ulong> src)
            where T : unmanaged
                => cast<ulong,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> from<T>(in ReadOnlyMemory<float> src)
            where T : unmanaged
                => cast<float,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<double> src)
            where T : unmanaged
                => cast<double,T>(src.Span);                 

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
            where F : IBinaryPredicate<T>
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
            where F : IUnaryPredicate<T>
        {
            var count = dst.Length;
            ref readonly var input = ref head(src);
            ref var target = ref head(dst);

            for(var i=0; i<count; i++)
                seek(ref target, i) = f.Invoke(skip(in input, i));
            return dst;
        }

        public static Span<T> Fuse<T>(this Span<T> xs, Span<T> ys, Func<T,T,T> f)
        {        
            var len = Checks.length(xs,ys);
            ref var xh = ref head(xs);
            ref var yh = ref head(ys);        
            for(var i = 0; i < len ; i++)
                seek(ref xh, i) = f(skip(in xh,i), skip(in yh, i));
            return xs;
        }     

        /// <summary>
        /// Inovkes an action for each element in a source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The receiver</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void iter<T>(ReadOnlySpan<T> src, Action<T> f)
        {
            ref readonly var input = ref head(src);
            int count = src.Length;

            for(var i=0; i<count; i++)
                f(skip(input,i));
        }

        /// <summary>
        /// Inovkes an action for each pair of elements in source spans of equal length
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The receiver</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void iter<T>(ReadOnlySpan<T> first, ReadOnlySpan<T> second, Action<T,T> f)
        {
            var count = Checks.length(first,second);
            ref readonly var x = ref head(first);
            ref readonly var y = ref head(second);
            
            for(var i=0; i<count; i++)
                f(skip(x,i),skip(y,i));
        }

        /// <summary>
        /// Inovkes an action for each pair of elements in source spans of equal length
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The receiver</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void iter<T>(Span<T> first, Span<T> second, Action<T,T> f)
            => iter(first.ReadOnly(), second.ReadOnly(),f);

        /// <summary>
        /// Inovkes an action for each element in a source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The receiver</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void iteri<T>(ReadOnlySpan<T> src, Action<int,T> f)
        {
            ref readonly var input = ref head(src);
            int count = src.Length;

            for(var i=0; i<count; i++)
                f(i,skip(input,i));
        }

        /// <summary>
        /// Maps the elements of a source span to a target span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The mapping function</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> map<S,T>(ReadOnlySpan<S> src, Func<S,T> f, Span<T> dst)
        {
            ref readonly var input = ref head(src);
            ref var output = ref head(dst);
            int count = src.Length;
            
            for(var i=0; i<count; i++)
                seek(ref output, i)= f(skip(in input, i));
            
            return dst;
        }

        /// <summary>
        /// Maps the elements of a source span to a target span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The mapping function</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> mapi<S,T>(ReadOnlySpan<S> src, Func<int,S,T> f, Span<T> dst)
        {
            ref readonly var input = ref head(src);
            ref var output = ref head(dst);
            int count = src.Length;
            
            for(var i=0; i<count; i++)
                seek(ref output, i)= f(i,skip(in input, i));
            
            return dst;
        }
    }    
}