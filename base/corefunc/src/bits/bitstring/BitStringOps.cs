//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.IO;
    
    using static zfunc;
    using static As;

    partial struct BitString
    {

        public static BitString not(BitString src)
        {            
            var len = src.Length;
            var dst = alloc(len);
            for(var i=0; i< len; i++)
                dst[i] = ~src[i];
            return dst;
        }

        public static BitString and(BitString lhs, BitString rhs)
        {            
            var len = length(lhs.bitseq,rhs.bitseq);
            var dst = alloc(len);
            for(var i=0; i< len; i++)
                dst[i] = lhs[i] & rhs[i];
            return dst;
        }

        public static BitString or(BitString lhs, BitString rhs)
        {            
            var len = length(lhs.bitseq,rhs.bitseq);
            var dst = alloc(len);
            for(var i=0; i< len; i++)
                dst[i] = lhs[i] | rhs[i];
            return dst;
        }

        public static BitString xor(BitString lhs, BitString rhs)
        {            
            var len = length(lhs.bitseq,rhs.bitseq);
            var dst = alloc(len);
            for(var i=0; i< len; i++)
                dst[i] = lhs[i] ^ rhs[i];
            return dst;
        }

        public static BitString srl(BitString lhs, int offset)
        {            
            var dst = alloc(lhs.Length);
            for(var i=lhs.Length - offset; i>=0; i--)
                dst[i] = lhs[i];
            return dst;
        }

        public static BitString sll(BitString lhs, int offset)
        {            
            var dst = alloc(lhs.Length);
            for(var i=offset; i<dst.Length; i++)
                dst[i] = lhs[i];
            return dst;
        }
    }
}