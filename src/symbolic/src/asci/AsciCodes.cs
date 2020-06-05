//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static Seed;
    using static Typed;
    using static Control;

    [ApiHost]
    public partial class AsciCodes : IApiHost<AsciCodes>
    {                
        [MethodImpl(Inline), Op]
        public static int first(ReadOnlySpan<char> src, char c)
        {
            for(var i=0; i<src.Length; i++)
                if(skip(src,i) == c)
                    return i;
            return -1;
        }

        [MethodImpl(Inline), Op]
        public static int encode(ReadOnlySpan<char> src, Span<byte> dst)
        {
            const int W = 16;
            const char Z = (char)0;

            var @null = first(src, Z);                                
            var count = @null == -1 ? src.Length : 0;
            if(count == 0)
                return 0;

            var j = 0;
            var r = count;
            for(int i=0; i<count; i++)
            {
                if(r<0) 
                    break;                
                
                var seglen = r >= W ? W : r;
                var segSrc = src.Slice(j, seglen);            
                var segDst = dst.Slice(j, seglen);
                AC16.encode(segSrc, out var encoded).CopyTo(segDst);
                
                j += seglen;
                r -= seglen;
            }
            return j;
        }

        [MethodImpl(Inline), Op]
        public static int encode(ReadOnlySpan<string> src, Span<byte> dst)
        {
            var j = 0;
            for(int i=0; i<src.Length; i++)
                j += encode(skip(src, i), dst.Slice(j));
            return j + 1;
        }
    } 
}