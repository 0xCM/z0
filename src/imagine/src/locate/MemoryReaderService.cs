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
    
    public readonly struct MemoryReaderService
    {
        const int MaxZeroCount = 10;
        
        public static MemoryReaderService Service => default;

        [MethodImpl(Inline)]
        public unsafe int Read(MemoryAddress src, Span<byte> dst, int? count = null)
        {
            var pSrc = src.Pointer<byte>();
            var limit = count ?? dst.Length;
            return Read(ref pSrc, limit, dst);
        }

        [MethodImpl(Inline)]
        public unsafe int Read(MemoryAddress src, ref byte dst, int count)
        {
            var pSrc = src.Pointer<byte>();
            return Read(ref pSrc, count, ref dst);
        }

        [MethodImpl(Inline)]
        unsafe int Read(ref byte* pSrc, int count, Span<byte> dst)
            => Read(ref pSrc, count, ref first(dst));

        unsafe int Read(ref byte* pSrc, int limit, ref byte dst)
        {
            var offset = 0;
            var zcount = 0;
            while(offset < limit && zcount < MaxZeroCount)        
            {
                var value = Unsafe.Read<byte>(pSrc++);
                seek(dst, offset++) = value;
                if(value != 0)
                    zcount = 0;
                else
                    zcount++;
            }
            return offset;
        }
    }
}