//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static AsciCharCode;
    using static Konst;
    using static z;

    [ApiHost(ApiNames.BitParser,true)]
    public readonly struct BitParser
    {
        public static bit Parse(string src)
            => OnLabels.Contains(src.Trim().ToLower());

        static string[] OnLabels
            => new string[]{"on", "1", "enabled", "true", "yes"};

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
        /// Creates a bitspan from the text encoding of a binary number
        /// </summary>
        /// <param name="src">The bit source</param>
        [Op]
        public static ReadOnlySpan<bit> parse(string src)
        {
            var data = span(src);
            var count = data.Length;
            var dst = sys.span<bit>(count);

            var j=0u;
            for(uint i=0u; i<count; i++)
            {
                ref readonly var c = ref skip(data,i);
                if(!exclude(c))
                    seek(dst, j++) = skip(data,i) == bit.One;
            }
            return slice(dst,0,j);
        }
    }
}