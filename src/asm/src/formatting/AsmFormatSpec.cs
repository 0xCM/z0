//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public struct AsmFormatSpec
    {
        public const string SectionSep = text.PageBreak + text.PageBreak;

        public const string FieldSep = RenderPatterns.FieldSep;

        public static AsmFormatSpec Default
            => create();

        public static AsmFormatSpec WithSectionDelimiter
            => create(EmitSectionDelimiter : true);

        public static AsmFormatSpec WithFunctionTimestamp
            => create(EmitFunctionTimestamp : true);

        public static AsmFormatSpec DefaultStreamFormat
            => create(EmitSectionDelimiter : true, EmitBaseAddress : true);

        public static AsmFormatSpec create(
           bool EmitCaptureTermCode = true,
           bool EmitFileHeader = true,
           bool EmitFunctionHeaderEncoding = true,
           bool EmitBaseAddress = true,
           bool EmitFunctionHeader = true,
           bool EmitFunctionTimestamp = false,
           bool EmitSectionDelimiter = false,
           int InstructionPad = 40,
           bool ShowLineAddresses = true,
           int SectionDelimiterWidth = 120
           ) => new AsmFormatSpec(
               EmitCaptureTermCode,
               EmitFileHeader,
               EmitFunctionHeaderEncoding,
               EmitBaseAddress,
               EmitFunctionHeader,
               EmitFunctionTimestamp,
               EmitSectionDelimiter,
               InstructionPad,
               ShowLineAddresses,
               SectionDelimiterWidth);

        public AsmFormatSpec(
           bool EmitCaptureTermCode,
           bool EmitFileHeader,
           bool EmitFunctionHeaderEncoding,
           bool EmitLocation,
           bool EmitFunctionHeader,
           bool EmitFunctionTimestamp,
           bool EmitSectionDelimiter,
           int InstructionPad,
           bool ShowLineAddresses,
          int SectionDelimiterWidth
           )
       {
           this.EmitCaptureTermCode = EmitCaptureTermCode;
           this.EmitFileHeader = EmitFileHeader;
           this.EmitFunctionHeaderEncoding = EmitFunctionHeaderEncoding;
           this.EmitBaseAddress = EmitLocation;
           this.EmitFunctionHeader = EmitFunctionHeader;
           this.EmitFunctionTimestamp = EmitFunctionTimestamp;
           this.EmitSectionDelimiter = EmitSectionDelimiter;
           this.InstructionPad = InstructionPad;
           this.EmitLineAddresses = ShowLineAddresses;
           this.FieldDelimiter = FieldSep;
           this.SectionDelimiter  = SectionSep;
           this.HeaderEncodingFormat = FormatOptions.hex();
       }

        public bool EmitCaptureTermCode;

        public bool EmitFileHeader;

        public bool EmitFunctionHeaderEncoding;

        public bool EmitBaseAddress;

        public bool EmitFunctionHeader;

        public bool EmitFunctionTimestamp;

        public bool EmitSectionDelimiter;

        public int InstructionPad;

        public bool EmitLineAddresses;

        public string FieldDelimiter;

        public string SectionDelimiter;

        public HexFormatOptions HeaderEncodingFormat;
    }
}