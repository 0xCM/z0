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
    using static Part;
    using static memory;

    [ApiDeep]
    public readonly struct EnabledSynonyms
    {
        public static string On() => "on";

        public static string One() => "1";

        public static string Enabled() => "enabled";

        public static string True() => "true";

        public static string Yes() => "yes";

        static string[] OnLabels
            => new string[]{On(), One(), Enabled(), True(), Yes()};
    }

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
        static string OnLabel(byte index)
            => memory.skip(OnLabels, index);

        /// <summary>
        /// Creates a bitspan from the text encoding of a binary number
        /// </summary>
        /// <param name="src">The bit source</param>
        [Op]
        public static Span<bit> parse(string src)
            => parse(src, span<bit>(src.Length));

        [Op]
        public static Span<bit> parse(string src, Span<bit> buffer)
        {
            var chars = span(src);
            var count = chars.Length;
            var j=0u;
            for(uint i=0u; i<count; i++)
            {
                ref readonly var c = ref skip(chars, i);
                if(c == bit.One)
                    seek(buffer, j++) = bit.On;
                else if(c == bit.Zero)
                    seek(buffer, j++) = bit.Off;
            }
            return slice(buffer,0,j);
        }
    }
}