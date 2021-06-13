//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct IntelSdm
    {
        /// <summary>
        /// Represents content of the form '{Chapter}-{Page}'
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct ChapterPage
        {
            public const string RenderPattern = "{0}-{1}";

            public Chapter Chapter;

            public Page Page;

            [MethodImpl(Inline)]
            public ChapterPage(Chapter chapter, Page page)
            {
                Chapter = chapter;
                Page = page;
            }

            public string Format()
                => string.Format(RenderPattern, Chapter, Page);

            public override string ToString()
                => Format();

            public static ChapterPage Empty => new ChapterPage(0,0);
        }
    }
}