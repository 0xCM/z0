//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly partial struct TextDocs
    {
        /// <summary>
        /// Creates a <see cref='TextSegment'/> from an index-identifed segment of a <see cref='TextLine'/>
        /// </summary>
        /// <param name="src">The source line</param>
        /// <param name="i0">The index of the first included character</param>
        /// <param name="i1">The index of the last included character</param>
        [MethodImpl(Inline), Op]
        public static TextSegment segment(TextLine src, uint i0, uint i1)
            => new TextSegment(src,i0, i1);

        /// <summary>
        /// Creates a <see cref='TextLine'/>
        /// </summary>
        /// <param name="number">The line number</param>
        /// <param name="src">The line text</param>
        [MethodImpl(Inline), Op]
        public static TextLine line(uint number, string src)
            => new TextLine(number, src);

        /// <summary>
        /// Creates a <see cref='TextBlock'/>
        /// </summary>
        /// <param name="src">The source text</param>
        [MethodImpl(Inline), Op]
        public static TextBlock block(string src)
            => new TextBlock(src);
    }
}