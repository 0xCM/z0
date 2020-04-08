//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    partial struct BitSpan
    {
        [MethodImpl(Inline)]
        public static int msb(in BitSpan src)
        {
            var len = src.Length;
            for(var i = len - 1; i >=0; i--)
                if(src[i])
                    return i;
            return 0;
        }

        [MethodImpl(Inline)]
        public static int lsb(in BitSpan src)
        {
            var len = src.Length;
            for(var i = 0; i <len;  i++)
                if(src[i])
                    return i;
            return -1;
        }

        [MethodImpl(Inline)]
        public static BitSpan trim(in BitSpan src)
        {
            var msbpos = msb(src);
            if(msbpos != 0 && msbpos != src.Length - 1)
                return load(src.bits.Slice(0, msbpos + 1));
            else
                return src;            
        }
    }
}