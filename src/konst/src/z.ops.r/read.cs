//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;
    using static System.Runtime.InteropServices.MemoryMarshal;

    partial struct z
    {
        /// <summary>
        /// Interprets a readonly generic reference as a readonly uint8 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly byte read<T>(W8 w, in T src)
            => ref As<T,byte>(ref AsRef(in src));

        /// <summary>
        /// Interprets a readonly generic reference as a readonly uint16 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly ushort read<T>(W16 w, in T src)
            => ref As<T,ushort>(ref AsRef(in src));

        /// <summary>
        /// Interprets a readonly generic reference as a readonly uint32 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly uint read<T>(W32 w, in T src)
            => ref As<T,uint>(ref AsRef(in src));

        /// <summary>
        /// Interprets a readonly generic reference as a readonly uint64 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly ulong read<T>(W64 w, in T src)
            => ref As<T,ulong>(ref AsRef(in src));

        /// <summary>
        /// Reads a T-cell from a bytespan
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target type</typeparam>

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T read<T>(ReadOnlySpan<byte> src)
            where T : struct
                => Read<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read2<T>(ReadOnlySpan<byte> src)
            => ref @as<byte,T>(first(src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T read2<T>(Span<byte> src)
            => ref @as<byte,T>(first(src));

        /// <summary>
        /// Deposits a source value, identified by pointer and offset, into a target reference
        /// </summary>
        /// <param name="pSrc">The data source</param>
        /// <param name="offset">The value offset</param>
        /// <param name="dst">The receiving reference</param>
        /// <typeparam name="T">The value type</typeparam>
        /// <remarks>u8:  movsxd rax,edx -> movzx eax,byte ptr [rcx+rax] -> mov [r8],al -> mov rax,r8 </remarks>
        /// <remarks>u16: movsxd rax,edx -> movzx eax,word ptr [rcx+rax*2] -> mov [r8],ax -> mov rax,r8 </remarks>
        /// <remarks>u32: movsxd rax,edx -> mov eax,[rcx+rax*4] -> mov [r8],eax -> mov rax,r8 </remarks>
        /// <remarks>u64: movsxd rax,edx -> mov rax,[rcx+rax*8] -> mov [r8],rax -> mov rax,r8 </remarks>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public unsafe static ref T read<T>(T* pSrc, int offset, ref T dst)
            where T : unmanaged
        {
            dst = *(pSrc + offset);
            return ref dst;
        }

        /// <summary>
        /// Deposits a range of source values into a target reference
        /// </summary>
        /// <param name="pSrc">The data source</param>
        /// <param name="offset">The value offset</param>
        /// <param name="dst">The receiving reference</param>
        /// <param name="count">The number of values to extract/deposit</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe void read<T>(T* pSrc, int offset, ref T dst, int count)
            where T : unmanaged
        {
            var last = offset + count;
            for(var i=offset; i<last; i++)
                read(pSrc, i, ref add(dst, i));
        }

        /// <summary>
        /// Reads a T-value from an S-source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<S,T>(in S src)
            => ref As<S,T>(ref edit(src));

        /// <summary>
        /// Reads a T-value from an S-source after skipping a specified count of S-elements
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The number of S-cells to skip</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<S,T>(in S src, int offset)
            => ref read<S,T>(Add(ref edit(src), offset));

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in byte src)
            => ref read<byte,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in sbyte src)
            => ref read<sbyte,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in short src)
            => ref read<short,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in ushort src)
            => ref read<ushort,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in int src)
            => ref read<int,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in uint src)
            => ref read<uint,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in long src)
            => ref read<long,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in ulong src)
            => ref read<ulong,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in float src)
            => ref read<float,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in double src)
            => ref read<double,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in bool src)
            => ref read<bool,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in char src)
            => ref read<char,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in decimal src)
            => ref read<decimal,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in byte src, int offset)
            => ref read<byte,T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in sbyte src, int offset)
            => ref read<sbyte,T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in short src, int offset)
            => ref read<short,T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in ushort src, int offset)
            => ref read<ushort,T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in int src, int offset)
            => ref read<int,T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in uint src, int offset)
            => ref read<uint,T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in long src, int offset)
            => ref read<long,T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in ulong src, int offset)
            => ref read<ulong,T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in float src, int offset)
            => ref read<float,T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in double src, int offset)
            => ref read<double,T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in bool src, int offset)
            => ref read<bool,T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in char src, int offset)
            => ref read<char,T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in decimal src, int offset)
            => ref read<decimal,T>(src, offset);
    }
}