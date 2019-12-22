//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;


    partial struct BitSpan
    {
        /// <summary>
        /// Forms the bitspan z := [head,tail] via concatentation
        /// </summary>
        /// <param name="head">The leading bits</param>
        /// <param name="tail">The trailing bits</param>
        public static BitSpan concat(in BitSpan head, in BitSpan tail)
        {
            Span<bit> dst = new bit[head.Length + tail.Length];
            head.bits.CopyTo(dst);
            tail.bits.CopyTo(dst, head.Length);
            return load(dst);
        }

        [MethodImpl(Inline)]
        public BitSpan truncate(in BitSpan src, int maxlen)
        {
            if(Length <= maxlen)
                return src;
            
            return load(src.bits.Slice(0, maxlen));            
        }

        /// <summary>
        /// Creates a bitspan from text encoding of a binary number
        /// </summary>
        /// <param name="src">The bit source</param>
        public static BitSpan parse(string src)                
        {            
            var data = src.RemoveWhitespace().Replace("0b",string.Empty);
            var len = data.Length;
            var lastix = len - 1;
            Span<bit> bits = new bit[len];
            for(var i=0; i<= lastix; i++)
               bits[lastix - i] = data[i] == bit.Zero ? bit.Off : bit.On;
            return load(bits);
        }
    }
}