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
    public readonly partial struct BitFields
    {
        const NumericKind Closure = UnsignedInts;

        public const char SegmentDelimiter = Chars.Colon;

        public static Fence<char> SegmentFence
        {
            [MethodImpl(Inline)]
            get => Rules.fence(Chars.LBracket, Chars.RBracket);
        }

        public static string format<T>(BitSegment<T> src)
            where T : unmanaged
                => Format.enclose(Format.adjacent(src.EndPos, SegmentDelimiter, src.StartPos), SegmentFence);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint width<T>(BitSegment<T> src)
            where T : unmanaged
                => bw32(src.EndPos) - bw32(src.StartPos) + 1u;

        /// <summary>
        /// Produces a <see cref='BitSegment{T}'/> from text of the form '[max:min]'
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="dst">Upon success, the populated section</param>
        /// <typeparam name="T">The section index type</typeparam>
        public static bool parse<T>(string src, out BitSegment<T> dst)
            where T : unmanaged
        {
            dst = default;
            if(Parse.unfence(src, SegmentFence, out var fenced))
            {
                var parts = Parse.split(fenced, SegmentDelimiter);
                if(parts.Count == 2)
                {
                    if(Numeric.parse(parts[0], out T max)
                        && Numeric.parse(parts[1], out T min))
                    {
                        dst = BitFieldModels.segment<T>("0b",min, max);
                        return true;
                    }
                }
            }

            return false;
        }
   }
}