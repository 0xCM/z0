//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;
    using static Root;

    partial struct IntelSdm
    {
        /// <summary>
        /// Represents content of the form '{Chapter}-{Page}'
        /// </summary>
        public struct ChapterPage
        {
            public const string RenderPattern = "{0}-{1}";

            public byte Chapter;

            public ushort Page;

            [MethodImpl(Inline)]
            public ChapterPage(byte chapter, ushort page)
            {
                Chapter = chapter;
                Page = page;
            }

            public string Format()
                => format(this);

            public override string ToString()
                => Format();

            public static ChapterPage Empty => new ChapterPage(0,0);
        }
    }
}