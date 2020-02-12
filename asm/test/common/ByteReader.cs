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

        public unsafe int Read(ref byte* pSrc, int count, Span<byte> dst)
        {
            var offset = 0;
            ref var target = ref head(dst);
            var zcount = 0;
            while(offset < count && zcount < 10)        
            {
                var value = Unsafe.Read<byte>(pSrc++);
                seek(ref target, offset++) = value;
                if(value != 0)
                    zcount = 0;
                else
                    zcount++;
            }
            return offset;
        }

    }


}