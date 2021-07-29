//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct SdmModels
    {
        public readonly struct PagePatterns
        {
            public const string Vex128Version = "(VEX.128 encoded version)";

            public const string Vex256Version = "(VEX.256 encoded version)";

            public const string EvexVersions = "(EVEX encoded versions)";

            /// <summary>
            /// {Chapter}-{Page} Vol. {Vol}
            /// </summary>
            public const string PageNumber = "{0}-{1} Vol. {2}";

            /// <summary>
            /// {Mnemonic} — {Description}
            /// </summary>
            public const string MnemonicTitle = "{0} — {1}";

            /// <summary>
            /// {0}/{1}
            /// </summary>
            public const string MultiMnemonicTitle1 = "{Mnemonic}/{0}";

            /// <summary>
            /// {0}/{1}/{2}
            /// </summary>
            public const string MultiMnemonicTitle2 = "{0}/{1}/{2}";

            /// <summary>
            /// {0}/{1}/{2}/{3}
            /// </summary>
            public const string MultiMnemonicTitle3 = "{0}/{1}/{2}/{3}";

            public const string ChapterNumber = "CHAPTER " + "{0}";

            public const string TableNumber = "Table " + "{0}";

            public const string ChapterPage = "{0}-{1}";

            public const string Intrinsics = "Intel C/C++ Compiler Intrinsic Equivalent";

            public const string TocTitle = " . . . . . . . . . .";
        }
    }
}