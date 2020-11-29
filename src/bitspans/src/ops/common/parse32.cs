//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class BitSpans
    {
        /// <summary>
        /// Creates a bitspan from text encoding of a binary number
        /// </summary>
        /// <param name="src">The bit source</param>
        [Op]
        public static BitSpan32 parse32(string src)
        {
            var data = BitString.normalize(src);
            var len = data.Length;
            var lastix = len - 1;
            Span<Bit32> bits = new Bit32[len];
            for(var i=0; i<= lastix; i++)
               bits[lastix - i] = data[i] == Bit32.Zero ? Bit32.Off : Bit32.On;
            return BitSpans.load32(bits);
        }
    }
}