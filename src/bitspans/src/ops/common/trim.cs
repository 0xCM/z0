//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class BitSpans
    {
        [MethodImpl(Inline), Op]
        public static int msb(in BitSpan32 src)
        {
            var len = src.Length;
            for(var i = len - 1; i >=0; i--)
                if(src[i])
                    return i;
            return 0;
        }

        [MethodImpl(Inline), Op]
        public static int msb(in BitSpan src)
        {
            var len = src.Length;
            for(var i = len - 1; i >=0; i--)
                if(src[i])
                    return i;
            return 0;
        }

        [MethodImpl(Inline), Op]
        public static int lsb(in BitSpan32 src)
        {
            var len = src.Length;
            for(var i = 0; i <len;  i++)
                if(src[i])
                    return i;
            return -1;
        }

        [MethodImpl(Inline), Op]
        public static int lsb(in BitSpan src)
        {
            var len = src.Length;
            for(var i = 0; i <len;  i++)
                if(src[i])
                    return i;
            return -1;
        }

        [MethodImpl(Inline), Op]
        public static BitSpan32 trim(in BitSpan32 src)
        {
            var pos = msb(src);
            if(pos != 0 && pos != src.Length - 1)
                return BitSpans.load32(src.Data.Slice(0, pos + 1));
            else
                return src;
        }

        [MethodImpl(Inline), Op]
        public static BitSpan trim(in BitSpan src)
        {
            var pos = msb(src);
            if(pos != 0 && pos != src.Length - 1)
                return BitSpans.load(src.Storage.Slice(0, pos + 1));
            else
                return src;
        }
    }
}