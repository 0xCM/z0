//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.BZ;

    using static Root;
    using static core;

    partial struct Blit
    {
        [MethodImpl(Inline), Op]
        public static name128 name(W128 w, ReadOnlySpan<char> src)
        {
            var present = 0u;
            for(var i=0; i<present; i++)
            {
                if(skip(src,i) != 0)
                    present++;
                else
                    break;
            }
            var length = min(present,name128.MaxLength);
            var storage = Cell128.Empty;
            var dst = storage.Bytes;
            for(var i=0; i<length; i++)
                seek(dst,i) = (byte)skip(src,i);
            seek(dst,15) = (byte)length;
            return new name128(storage);
        }

        [MethodImpl(Inline), Op]
        public static name64 name(W64 w, ReadOnlySpan<char> src)
        {
            var present = 0u;
            for(var i=0; i<present; i++)
            {
                if(skip(src,i) != 0)
                    present++;
                else
                    break;
            }
            var length = min(present, name64.MaxLength);
            var storage = 0ul;
            var dst = bytes(storage);
            for(var i=0; i<length; i++)
                seek(dst,i) = (byte)skip(src,i);
            seek(dst,15) = (byte)length;
            return new name64(storage);
        }
    }
}