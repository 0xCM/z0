//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;

    public readonly struct ByteReader
    {
        [MethodImpl(Inline)]
        public static ByteReader Create()
            => default;

        public unsafe int Read(ref byte* pSrc, int count, ref byte dst)
        {
            var offset = 0;
            var zcount = 0;
            while(offset < count && zcount < 10)        
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

        [MethodImpl(Inline)]
        public unsafe int Read(ref byte* pSrc, int count, Span<byte> dst)
            => Read(ref pSrc, count, ref head(dst));

        [MethodImpl(Inline)]
        public unsafe int Read(MemoryAddress src, int count, Span<byte> dst)
        {
            var pSrc = src.ToPointer<byte>();
            return Read(ref pSrc, count, dst);
        }
    }
}