//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static memory;

    partial class XFs
    {
        /// <summary>
        /// Reads the line-partitioned content of a text file
        /// </summary>
        /// <param name="src">The file path</param>
        [Op]
        public static Index<string> ReadLines(this FS.FilePath src)
        {
            return FS.lines(src);
        }

        /// <summary>
        /// Reads the line-partitioned content of a text file
        /// </summary>
        /// <param name="src">The file path</param>
        [Op]
        public static Index<TextLine> ReadTextLines(this FS.FilePath src)
        {
            if(!src.Exists)
                return sys.empty<TextLine>();

            var data = FS.lines(src).View;
            var count = data.Length;
            if(count == 0)
                return sys.empty<TextLine>();

            var buffer = sys.alloc<TextLine>(count);
            ref var dst = ref first(buffer);
            for(var i=0u; i<count; i++)
                seek(dst,i) = text.line(i, skip(data,i));
            return buffer;
        }
    }
}