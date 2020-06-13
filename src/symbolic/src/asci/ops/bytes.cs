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

    partial class AsciCodes
    {
        [MethodImpl(Inline), Op]
        public static int bytes(ReadOnlySpan<char> src, Span<byte> dst)
        {
            var count = Math.Min(src.Length, dst.Length);
            for(var i=0; i<count; i++)
                seek(dst,i) = (byte)skip(src,i);
            return count;
        }

        [MethodImpl(Inline), Op]
        public static int bytes(in char src, int count, ref byte dst)
        {
            for(var i=0; i<count; i++)
                seek(ref dst,i) = (byte)skip(src,i);
            return count;
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> bytes(ReadOnlySpan<AsciCharCode> src)
            => cast<AsciCharCode,byte>(src);
    }
}