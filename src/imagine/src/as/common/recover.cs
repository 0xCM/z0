//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial struct As
    {
        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        /// <remarks>
        /// width[T] = 8: mov rax,[rdx] => [rcx],rax => mov dword ptr [rcx+8],1 => mov rax,rcx 
        /// width[T] = 16: mov rax,[rdx] => [rcx],rax => mov dword ptr [rcx+8],2 => mov rax,rcx 
        /// width[T] = 32: mov rax,[rdx] => [rcx],rax => mov dword ptr [rcx+8],4 => mov rax,rcx 
        /// width[T] = 64: mov rax,[rdx] => [rcx],rax => mov dword ptr [rcx+8],8 => mov rax,rcx 
        /// </remarks>
        [MethodImpl(Inline), Recover, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<sbyte> src)
            where T : struct
                => core.recover<sbyte,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        /// <remarks>
        /// Using the system-supplid cast function:
        /// 0000h sub rsp,28h             
        /// 0004h nop                     
        /// 0005h mov rax,[rcx]           
        /// 0008h mov ecx,[rcx+8]         
        /// 000bh cmp ecx,1               
        /// 000eh jl short 0018h          
        /// 0010h movzx eax,byte ptr [rax]
        /// 0013h add rsp,28h             
        /// 0017h ret                     
        /// 0018h mov ecx,28h             
        /// </remarks>
        [MethodImpl(Inline), Recover, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<byte> src)
            where T : struct
                => core.recover<byte,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Recover, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<short> src)
            where T : struct
                => core.recover<short,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Recover, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<ushort> src)
            where T : struct
                => core.recover<ushort,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Recover, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<uint> src)
            where T : struct
                => core.recover<uint,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Recover, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<int> src)
            where T : struct
                 => core.recover<int,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Recover, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<long> src)
            where T : struct
                 => recover<long,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Recover, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<ulong> src)
            where T : struct
                 => recover<ulong,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Recover, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<float> src)
            where T : struct
                => recover<float,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Recover, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<double> src)
            where T : struct
                => recover<double,T>(src); 

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Recover, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<decimal> src)
            where T : struct
                => recover<decimal,T>(src);      

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Recover, Closures(UnsignedInts)]
        public static Span<T> recover<T>(Span<byte> src)
            where T : struct
                => recover<byte,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Recover, Closures(UnsignedInts)]
        public static Span<T> recover<T>(Span<uint> src)
            where T : struct
                => recover<uint,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Recover, Closures(UnsignedInts)]
        public static Span<T> recover<T>(Span<sbyte> src)
            where T : struct
                => recover<sbyte,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Recover, Closures(UnsignedInts)]
        public static Span<T> recover<T>(Span<short> src)
            where T : struct
                => recover<short,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Recover, Closures(UnsignedInts)]
        public static Span<T> recover<T>(Span<ushort> src)
            where T : struct
                => recover<ushort,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Recover, Closures(UnsignedInts)]
        public static Span<T> recover<T>(Span<int> src)
            where T : struct
                => recover<int,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Recover, Closures(UnsignedInts)]
        public static Span<T> recover<T>(Span<long> src)
            where T : struct
                => recover<long,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Recover, Closures(UnsignedInts)]
        public static Span<T> recover<T>(Span<ulong> src)
            where T : struct
                 => recover<ulong,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Recover, Closures(UnsignedInts)]
        public static Span<T> recover<T>(Span<float> src)
            where T : struct
                 => recover<float,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Recover, Closures(UnsignedInts)]
        public static Span<T> recover<T>(Span<double> src)
            where T : struct
                 => recover<double,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Recover, Closures(UnsignedInts)]
        public static Span<T> recover<T>(Span<decimal> src)
            where T : struct
                 => recover<decimal,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> recover<S,T>(Span<S> src)
            => cover(@as<S,T>(ref first(src)), size<T>()/size<S>());

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> recover<S,T>(ReadOnlySpan<S> src)
            => cover(@as<S,T>(ref edit(first(src))), size<T>()/size<S>());

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> recover<S,T>(ReadOnlySpan<S> src, out ReadOnlySpan<S> rem)
            where T : struct
            where S : struct
        {    
            var z = size<T>();
            var n = (uint)src.Length;
            var q = n/z;            
            var r = n%z;
            var dst = recover<S,T>(slice(src, 0, q));            
            rem = r != 0 ? slice(src,q) : EmptySpan<S>();
            return dst;
        }            

        [MethodImpl(Inline)]
        public static Span<T> recover<S,T>(Span<S> src, out Span<S> rem)
            where T : struct
            where S : struct
        {    
            var z = size<T>();
            var n = (uint)src.Length;
            var q = n/z;            
            var r = n%z;
            var dst = recover<S,T>(slice(src,0, q));            
            rem = r != 0 ? slice(src,q) : EmptySpan<S>();
            return dst;
        }            

    }
}