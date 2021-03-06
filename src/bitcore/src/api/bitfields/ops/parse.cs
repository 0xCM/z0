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

    partial struct BitFields
    {
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
                        dst = BitFields.segment<T>("0b",min, max);
                        return true;
                    }
                }
            }

            return false;
        }
    }
}