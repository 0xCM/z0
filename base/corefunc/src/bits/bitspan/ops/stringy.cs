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
        public static string format(in BitSpan src)
        {
            var bitcount = src.Length;      
            Span<char> buffer = stackalloc char[bitcount];
            ref var dst = ref head(buffer);
            
            for(int i = 0, j=bitcount-1; i < bitcount; i++, j--)
            {
                seek(ref dst, j) = src[i].ToChar();                
            }
            
            return new string(buffer);
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(this);

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

    }

}