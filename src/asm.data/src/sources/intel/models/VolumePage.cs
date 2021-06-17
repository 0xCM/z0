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
        /// Represents content of the form Vol. {VolName} {Chapter}-{Page}
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Pack =1)]
        public struct VolumePage
        {
            public const string RenderPattern = "Vol. {0} {1}";

            public VolumePart Volume;

            public ChapterPage Page;

            [MethodImpl(Inline)]
            public VolumePage(VolumePart vol, ChapterPage page)
            {
                Volume = vol;
                Page = page;
            }

            public string Format()
                => string.Format(RenderPattern, Volume, Page);

            public override string ToString()
                => Format();
        }
    }
}