//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    partial struct IntelSdm
    {
        /// <summary>
        /// EG:Vol. 2C 5-557
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Pack =1)]
        public struct Location
        {
            public VolPart Volume;

            public ChapterNumber Chapter;

            public Page Page;

            [MethodImpl(Inline)]
            public Location(VolPart v, ChapterNumber c, Page p)
            {
                Volume = v;
                Chapter = c;
                Page = p;
            }
        }
    }
}