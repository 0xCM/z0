//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public struct AsmFormatConfig
    {
        public bool EmitCaptureTermCode;

        public bool EmitFileHeader;

        public bool EmitBaseAddress;

        public bool EmitSectionDelimiter;

        public byte InstructionPad;

        public bool EmitLineAddresses;

        public string FieldDelimiter;

        public string SectionDelimiter;

        public bool AbsoluteLabels;

        public HexFormatOptions HeaderEncodingFormat;

        const string SectionSep = "; " + RP.PageBreak160;

        const string FieldSep = RP.FieldSep;

        public static AsmFormatConfig DefaultStreamFormat
            => @default(out var _);

        public static ref AsmFormatConfig @default(out AsmFormatConfig dst)
        {
            dst.EmitCaptureTermCode = true;
            dst.EmitFileHeader = true;
            dst.EmitBaseAddress = true;
            dst.EmitSectionDelimiter = true;
            dst.InstructionPad = 46;
            dst.AbsoluteLabels = false;
            dst.FieldDelimiter = RP.FieldSep;
            dst.SectionDelimiter = "; " + RP.PageBreak160;
            dst.EmitLineAddresses = true;
            dst.HeaderEncodingFormat = HexFormatSpecs.options();
            return ref dst;
        }
    }
}