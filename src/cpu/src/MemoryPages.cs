//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public unsafe readonly struct MemoryPages
    {
        [MethodImpl(Inline), Op]
        public static void ReadLo(byte* pSrc, ref PageBlock dst)
        {
            var pData = pSrc;
            var offset = z16;
            read2048(ref pData, ref dst, ref offset);
        }

        [MethodImpl(Inline), Op]
        public static void ReadHi(byte* pSrc, ref PageBlock dst)
        {
            const ushort Half = Root.PageSize/2;
            var pData = pSrc + Half;
            var offset = Half;
            read2048(ref pData, ref dst, ref offset);
        }

        [MethodImpl(Inline), Op]
        static void read32(ref byte* pSrc, ref PageBlock dst, ref ushort offset)
        {
            ref var target = ref u8(dst);
            cpu.vstore(cpu.vload(w256, pSrc), ref target, (int)offset);
            pSrc +=32;
            offset+= 32;
        }

        [MethodImpl(Inline), Op]
        static void read64(ref byte* pSrc, ref PageBlock dst, ref ushort offset)
        {
            read32(ref pSrc, ref dst, ref offset);
            read32(ref pSrc, ref dst, ref offset);
        }

        [MethodImpl(Inline), Op]
        static void read128(ref byte* pSrc, ref PageBlock dst, ref ushort offset)
        {
            read64(ref pSrc, ref dst, ref offset);
            read64(ref pSrc, ref dst, ref offset);
        }

        [MethodImpl(Inline), Op]
        static void read256(ref byte* pSrc, ref PageBlock dst, ref ushort offset)
        {
            read128(ref pSrc, ref dst, ref offset);
            read128(ref pSrc, ref dst, ref offset);
        }

        [MethodImpl(Inline), Op]
        static void read512(ref byte* pSrc, ref PageBlock dst, ref ushort offset)
        {
            read256(ref pSrc, ref dst, ref offset);
            read256(ref pSrc, ref dst, ref offset);
        }

        [MethodImpl(Inline), Op]
        static void read1024(ref byte* pSrc, ref PageBlock dst, ref ushort offset)
        {
            read512(ref pSrc, ref dst, ref offset);
            read512(ref pSrc, ref dst, ref offset);
        }

        [MethodImpl(Inline), Op]
        static void read2048(ref byte* pSrc, ref PageBlock dst, ref ushort offset)
        {
            read1024(ref pSrc, ref dst, ref offset);
            read1024(ref pSrc, ref dst, ref offset);
        }
    }
}