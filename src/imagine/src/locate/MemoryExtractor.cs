//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static z;
    
    [ApiHost]
    public unsafe readonly struct MemoryExtractor
    {
        const int MaxZeroCount = 10;
        
        public static MemoryExtractor Service => default;

        [MethodImpl(Inline), Op]
        public unsafe int Read(MemoryAddress src, Span<byte> dst, int? count = null)
            => read(src,dst,count);

        [MethodImpl(Inline), Op]
        public static int read(MemoryAddress src, Span<byte> dst, int? count = null)
        {
            var pSrc = src.Pointer<byte>();
            var limit = count ?? dst.Length;
            return read(ref pSrc, limit, dst);
        }

        [MethodImpl(Inline), Op]
        public static int read(MemoryAddress src, ref byte dst, int count)
        {
            var pSrc = z.ptr(ref dst);
            return read(ref pSrc, count, ref dst);
        }

        [MethodImpl(Inline), Op]
        public static int read(ref byte* pSrc, int count, Span<byte> dst)
            => read(ref pSrc, count, ref first(dst));

        [MethodImpl(Inline), Op]
        public static int read(ref byte* pSrc, int limit, ref byte dst)
        {
            var offset = 0;
            var count = 0;
            while(offset < limit && count < MaxZeroCount)        
            {
                var value = Unsafe.Read<byte>(pSrc++);
                seek(dst, offset++) = value;
                if(value != 0)
                    count = 0;
                else
                    count++;
            }
            return offset;
        }
    }
}