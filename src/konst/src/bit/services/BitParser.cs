//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static AsciCharCode;
    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct BitParser
    {
        static ReadOnlySpan<AsciCharCode> Filter 
            => new AsciCharCode[]{LBracket, RBracket, AsciCharCode.Space, Underscore, b};

        [MethodImpl(Inline), Op]
        static bool exclude(char c)
        {
            for(var i=0; i<Filter.Length; i++)
                if(skip(Filter,i) == (AsciCharCode)c)
                    return true;
            return false;
        }

        /// <summary>
        /// Creates a bitspan from text encoding of a binary number
        /// </summary>
        /// <param name="src">The bit source</param>
        [Op]
        public static ReadOnlySpan<uint1> parse(string input)                
        {            
            var src = span(input);
            var count = src.Length;
            var dst = sys.span<uint1>(count);

            var j=0u;
            for(uint i=0u; i<count; i++)
            {
                ref readonly var c = ref skip(src,i);
                if(!exclude(c))
                    seek(dst, j++) = skip(src,i) == '1';
            }
            return slice(dst,0,j);
        }         
    }
}