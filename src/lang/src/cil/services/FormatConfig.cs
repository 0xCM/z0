//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Cil
    {
        public readonly struct FormatConfig
        {
            public static FormatConfig Default
                => default;

            public bool EmitFileHeader
                => false;

            public bool EmitFunctionHeader
                => true;

            public string SectionDelimiter
                => RP.PageBreak120;

            public bool EmitSectionDelimiter
                => true;
        }
    }
}