//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Reads a T-cell from a bytespan
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target type</typeparam>

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T read<T>(ReadOnlySpan<byte> src)
            where T : struct
                => memory.read<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read2<T>(ReadOnlySpan<byte> src)
            => ref memory.read2<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T read2<T>(Span<byte> src)
            => ref memory.read2<T>(src);

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
                => ref memory.read(pSrc, offset, ref dst);

        [MethodImpl(Inline)]
        public static unsafe void read<T>(T* pSrc, int offset, ref T dst, int count)
            where T : unmanaged
                => memory.read(pSrc, offset, ref dst, count);

        [MethodImpl(Inline)]
        public static ref readonly T read<S,T>(in S src)
            => ref memory.read<S,T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<S,T>(in S src, int offset)
            => ref memory.read<S,T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in byte src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in sbyte src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in short src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in ushort src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in int src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in uint src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in long src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in ulong src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in float src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in double src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in bool src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in char src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in decimal src)
            => ref memory.read<T>(src);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in byte src, int offset)
            => ref memory.read<T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in sbyte src, int offset)
            => ref memory.read<T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in short src, int offset)
            => ref memory.read<T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in ushort src, int offset)
            => ref memory.read<T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in int src, int offset)
            => ref memory.read<T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in uint src, int offset)
            => ref memory.read<T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in long src, int offset)
            => ref memory.read<T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in ulong src, int offset)
            => ref memory.read<T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in float src, int offset)
            => ref memory.read<T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in double src, int offset)
            => ref memory.read<T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in bool src, int offset)
            => ref memory.read<T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in char src, int offset)
            => ref memory.read<T>(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in decimal src, int offset)
            => ref memory.read<T>(src, offset);
    }
}