//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct IntelSdm
    {
        /// <summary>
        /// Represents content of the form Vol. {VolName} {Chapter}-{Page}
        /// </summary>
        public struct VolumePage
        {
            public string VolName;

            public ChapterPage Page;

            public VolumePage(string vol, ChapterPage page)
            {
                VolName = vol;
                Page = page;
            }
        }
    }
}