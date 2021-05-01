//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static memory;

    partial struct BitfieldSpecs
    {
        /// <summary>
        /// Produces a <see cref='BitFieldPart{T}'/> from text of the form '[max:min]'
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="dst">Upon success, the populated section</param>
        /// <typeparam name="T">The section index type</typeparam>
        [Op, Closures(Closure)]
        public static Outcome parse<T>(string src, out BitFieldPart<T> dst)
            where T : unmanaged
        {
            dst = default;
            if(text.unfence(src, SegmentFence, out var fenced))
            {
                var parts = text.split(fenced, SegmentDelimiter).View;
                if(parts.Length == 2)
                {
                    if(Numeric.parse(skip(parts,0), out T max) && Numeric.parse(skip(parts,1), out T min))
                    {
                        dst = part<T>("0b", min, max);
                        return true;
                    }
                }
            }

            return false;
        }
    }
}