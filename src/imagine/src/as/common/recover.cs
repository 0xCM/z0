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
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<sbyte> src)
            where T : unmanaged
                => recover<sbyte,T>(src);

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
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<byte> src)
            where T : unmanaged
                => recover<byte,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<short> src)
            where T : unmanaged
                => recover<short,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<ushort> src)
            where T : unmanaged
                => recover<ushort,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<uint> src)
            where T : unmanaged
                => recover<uint,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<int> src)
            where T : unmanaged
                 => recover<int,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<long> src)
            where T : unmanaged
                 => recover<long,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<ulong> src)
            where T : unmanaged
                 => recover<ulong,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<float> src)
            where T : unmanaged
                => recover<float,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<double> src)
            where T : unmanaged
                => recover<double,T>(src); 

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<decimal> src)
            where T : unmanaged
                => recover<decimal,T>(src);      

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> generic<T>(Span<byte> src)
            where T : unmanaged
                => recover<byte,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> generic<T>(Span<uint> src)
            where T : unmanaged
                => recover<uint,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> generic<T>(Span<sbyte> src)
            where T : unmanaged
                => recover<sbyte,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> generic<T>(Span<short> src)
            where T : unmanaged
                => recover<short,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> generic<T>(Span<ushort> src)
            where T : unmanaged
                => recover<ushort,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> generic<T>(Span<int> src)
            where T : unmanaged
                => recover<int,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> generic<T>(Span<long> src)
            where T : unmanaged
                => recover<long,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> generic<T>(Span<ulong> src)
            where T : unmanaged
                 => recover<ulong,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> generic<T>(Span<float> src)
            where T : unmanaged
                 => recover<float,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> generic<T>(Span<double> src)
            where T : unmanaged
                 => recover<double,T>(src);

        /// <summary>
        /// Presents a source span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target span cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> generic<T>(Span<decimal> src)
            where T : unmanaged
                 => recover<decimal,T>(src);
    }
}