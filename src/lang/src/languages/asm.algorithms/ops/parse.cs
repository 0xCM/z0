//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Rules;
    using static memory;
    using static TextRules;

    partial struct AsmAlgorithms
    {
        public static Fence<char> SectionFence
        {
            [MethodImpl(Inline)]
            get => Rules.fence(Chars.LBracket, Chars.RBracket);
        }

        public const char SectionDelimiter = Chars.Colon;

        /// <summary>
        /// Produces a <see cref='Section{T}'/> from text of the form '[max:min]'
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <typeparam name="T"></typeparam>
        [Op, Closures(Closure)]
        public static bool parse<T>(string src, out Section<T> dst)
            where T : unmanaged
        {
            dst = default;
            if(Parse.unfence(src, SectionFence, out var fenced))
            {
                var parts = Parse.split(fenced, SectionDelimiter);
                if(parts.Count == 2)
                {
                    if(NumericParser.parse(parts[0], out T max)
                        && NumericParser.parse(parts[1], out T min))
                    {
                        dst = section<T>(min,max);
                        return true;
                    }
                }
            }

            return false;
        }
    }
}