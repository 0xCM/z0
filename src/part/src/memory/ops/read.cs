//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct memory
    {
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

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static byte read8<T>(in T src)
            => u8(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ushort read16<T>(in T src)
        {
            if(size<T>() >= 16)
                return u16(src);
            else
                return u8(src);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint read32<T>(in T src)
        {
            if(size<T>() >= 32)
                return u32(src);
            else  if(size<T>() >= 16)
                return u16(src);
            else
                return u8(src);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ulong read64<T>(in T src)
        {
            if(size<T>() >= 64)
                return u64(src);
            else  if(size<T>() >= 32)
                return u32(src);
            else  if(size<T>() >= 16)
                return u16(src);
            else
                return u8(src);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref byte read<T>(in T src, ref byte dst)
        {
            dst = read8(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ushort read<T>(in T src, ref ushort dst)
        {
            dst = read16(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint read<T>(in T src, ref uint dst)
        {
            dst = read32(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ulong read<T>(in T src, ref ulong dst)
        {
            dst = read64(src);
            return ref dst;
        }
    }
}