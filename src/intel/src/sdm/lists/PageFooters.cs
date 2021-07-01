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
        [ApiComplete("intel.sdm.pagefooters")]
        public readonly struct PageFooters
        {
            const string Null = "{null}";

            /// <summary>
            /// Returns a descripter of the form {Title} {null} Vol. {Major}.{Minor} {ChapterNumber}.{PageNumber}
            /// </summary>
            public static PageFooter TitleVolPage() => footer("{Title}", Null, VolNumber.Descriptor, ChapterPage.Descriptor);

            /// <summary>
            /// Returns a descripter of the form <paramref parameter='{title}'/> {null} Vol. {Major}.{Minor} {ChapterNumber}.{PageNumber}
            /// </summary>
            public static PageFooter TitleVolPage(string title) => footer(title, Null,VolNumber.Descriptor, ChapterPage.Descriptor);

            /// <summary>
            /// Returns a descripter of the form <paramref parameter='{title}'/> {null} <paramref parameter='{vol}'/> {ChapterNumber}.{PageNumber}
            /// </summary>
            public static PageFooter TitleVolPage(string title, VolNumber vol) => footer(title, Null, vol, ChapterPage.Descriptor);

            /// <summary>
            /// Returns a descripter of the form <paramref parameter='{title}'/> {null} <paramref parameter='{vol}'/> <paramref parameter='{page}'/>
            /// </summary>
            public static PageFooter TitleVolPage(string title, VolNumber vol, ChapterPage page) => footer(title, Null, vol, page);
        }
    }
}