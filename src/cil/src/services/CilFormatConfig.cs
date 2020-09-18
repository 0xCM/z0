//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct CilFormatConfig
    {
        public static CilFormatConfig Default
            => default;

        public bool EmitFileHeader
            => false;

        public bool EmitFunctionHeader
            => true;

        public string SectionDelimiter
            => RenderPatterns.PageBreak120;

        public bool EmitSectionDelimiter
            => true;
    }
}