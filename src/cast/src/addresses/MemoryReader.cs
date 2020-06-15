//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static Control;

    public readonly struct MemoryReader : IMemoryReader
    {
        const int MaxZeroCount = 10;
        
        public static IMemoryReader Service => default(MemoryReader);

        [MethodImpl(Inline)]
        public unsafe int Read(MemoryAddress src, Span<byte> dst)
        {
            var pSrc = src.ToPointer<byte>();
            var limit = dst.Length;
            return Read(ref pSrc, limit, dst);
        }

        [MethodImpl(Inline)]
        public unsafe int Read(MemoryAddress src, int limit, ref byte dst)
        {
            var pSrc = src.ToPointer<byte>();
            return Read(ref pSrc, limit, ref dst);
        }

        [MethodImpl(Inline)]
        unsafe int Read(ref byte* pSrc, int limit, Span<byte> dst)
            => Read(ref pSrc, limit, ref head(dst));

        unsafe int Read(ref byte* pSrc, int limit, ref byte dst)
        {
            var offset = 0;
            var zcount = 0;
            while(offset < limit && zcount < MaxZeroCount)        
            {
                var value = Unsafe.Read<byte>(pSrc++);
                seek(ref dst, offset++) = value;
                if(value != 0)
                    zcount = 0;
                else
                    zcount++;
            }
            return offset;
        }
    }
}