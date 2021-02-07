//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Rules;
    using static TextRules;
    using static memory;

    [ApiHost]
    public readonly struct BitSections
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Produces a <see cref='BitSection{T}'/> from text of the form '[max:min]'
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="dst">Upon success, the populated section</param>
        /// <typeparam name="T">The section index type</typeparam>
        public static bool parse<T>(string src, out BitSection<T> dst)
            where T : unmanaged
        {
            dst = default;
            if(Parse.unfence(src, SectionFence, out var fenced))
            {
                var parts = Parse.split(fenced, SectionDelimiter);
                if(parts.Count == 2)
                {
                    if(Numeric.parse(parts[0], out T max)
                        && Numeric.parse(parts[1], out T min))
                    {
                        dst = BitFieldModels.section<T>(min, max);
                        return true;
                    }
                }
            }

            return false;
        }

        public static string format<T>(BitSection<T> src)
            where T : unmanaged
                => Format.enclose(Format.adjacent(src.EndPos, SectionDelimiter, src.StartPos), SectionFence);


        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint width<T>(BitSection<T> src)
            where T : unmanaged
                => bw32(src.EndPos) - bw32(src.StartPos) + 1u;

        public const char SectionDelimiter = Chars.Colon;

        public static Fence<char> SectionFence
        {
            [MethodImpl(Inline)]
            get => Rules.fence(Chars.LBracket, Chars.RBracket);
        }
    }
}