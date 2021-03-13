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

    [ApiHost(ApiNames.BitParser,true)]
    public readonly struct BitParser
    {
        [Op]
        public static bool parse(string src, out bit dst)
        {
            const string On1 = "1";
            const string On2 = "true";
            const string On3 = "yes";
            const string On4 = "on";

            const string Off1 = "0";
            const string Off2 = "false";
            const string Off3 = "no";
            const string Off4 = "off";

            if(matches(src, On1))
            {
                dst = 1;
                return true;
            }

            if(matches(src, On2))
            {
                dst = 1;
                return true;
            }

            if(matches(src, On3))
            {
                dst = 1;
                return true;
            }

            if(matches(src, On4))
            {
                dst = 1;
                return true;
            }

            if(matches(src, Off1))
            {
                dst = 0;
                return true;
            }

            if(matches(src, Off2))
            {
                dst = 0;
                return true;
            }

            if(matches(src, Off3))
            {
                dst = 0;
                return true;
            }

            if(matches(src, Off4))
            {
                dst = 0;
                return true;
            }

            dst = default;
            return false;
        }

        [MethodImpl(Inline), Op]
        static bool matches(ReadOnlySpan<char> left,  ReadOnlySpan<char> right)
        {
            var count = left.Length;
            if(count != right.Length)
                return false;
            for(var i=0; i<count; i++)
                if(skip(left,i) != skip(right, i))
                    return false;
            return true;
        }

        static string[] OnLabels
            => new string[]{"on", "1", "enabled", "true", "yes"};

        static ReadOnlySpan<AsciCharCode> Filter
            => new AsciCharCode[]{LBracket, RBracket, AsciCharCode.Space, Underscore, b};

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