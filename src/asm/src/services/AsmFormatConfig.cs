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

        public static AsmFormatConfig Default
            => create();

        public static AsmFormatConfig DefaultStreamFormat
            => create(EmitSectionDelimiter : true, EmitBaseAddress : true);

        public static AsmFormatConfig create(
           bool EmitCaptureTermCode = true,
           bool EmitFileHeader = true,
           bool EmitBaseAddress = true,
           bool EmitSectionDelimiter = false,
           byte InstructionPad = 40,
           bool ShowLineAddresses = true,
           bool AbsoluteLabels = true,
           int SectionDelimiterWidth = 120
           ) => new AsmFormatConfig(EmitCaptureTermCode, EmitFileHeader, EmitBaseAddress, EmitSectionDelimiter,
                    InstructionPad, ShowLineAddresses, AbsoluteLabels, SectionDelimiterWidth);

        public AsmFormatConfig(
           bool EmitCaptureTermCode,
           bool EmitFileHeader,
           bool EmitLocation,
           bool EmitSectionDelimiter,
           byte InstructionPad,
           bool ShowLineAddresses,
           bool AbsoluteLabels,
           int SectionDelimiterWidth
           )
       {
           this.EmitCaptureTermCode = EmitCaptureTermCode;
           this.EmitFileHeader = EmitFileHeader;
           this.EmitBaseAddress = EmitLocation;
           this.EmitSectionDelimiter = EmitSectionDelimiter;
           this.InstructionPad = InstructionPad;
           this.EmitLineAddresses = ShowLineAddresses;
           this.FieldDelimiter = FieldSep;
           this.SectionDelimiter  = SectionSep;
           this.AbsoluteLabels = AbsoluteLabels;
           this.HeaderEncodingFormat = HexFormatSpecs.options();
       }
    }
}