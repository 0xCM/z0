//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static zfunc;

    public static class BytePatternMatch
    {
        public static bool matches(Span<byte> src, Span<byte> pattern)
        {
            var len = pattern.Length;
            var offset = src.Length - pattern.Length - 1;
            if(offset >= 0)
                return src.Slice(offset, len).EndsWith(pattern);
            else
                return false;
                        
        }

        public static bool matches(Span<byte> src, Span<byte?> pattern)
        {
            var len = pattern.Length;
            var offset = src.Length - pattern.Length - 1;
            if(offset < 0)
                return false;

            for(int  i=offset, j=0; i< src.Length; i++,j++)    
            {
                var y = pattern[j];
                if(y != null)
                {
                    if(src[i] != y.Value)
                        return false;
                }
            }
                
            return true;
        }
    }
}