//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class BitSpans
    {
        /// <summary>
        /// Creates a bitspan from text encoding of a binary number
        /// </summary>
        /// <param name="src">The bit source</param>
        [Op]
        public static BitSpan parse(string src)                
        {            
            var data = BitString.normalize(src);
            var len = data.Length;
            var lastix = len - 1;
            Span<bit> bits = new bit[len];
            for(var i=0; i<= lastix; i++)
               bits[lastix - i] = data[i] == bit.Zero ? bit.Off : bit.On;
            return BitSpans.load(bits);
        }         
    }
}