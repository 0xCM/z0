//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    public readonly struct AsmFormatSpec
    {        
        public static AsmFormatSpec Default => Create();

        public static AsmFormatSpec WithSectionDelimiter => Create(EmitSectionDelimiter : true);

        public static AsmFormatSpec WithFunctionTimestamp => Create(EmitFunctionTimestamp : true);

        public static AsmFormatSpec DefaultStreamFormat => Create(EmitSectionDelimiter : true, EmitLocation : false);

        public static AsmFormatSpec Create(
           bool EmitCaptureTermCode = true, 
           bool EmitFileHeader = true, 
           bool EmitFunctionHeaderEncoding = true,
           bool EmitLocation = true,
           bool EmitFunctionHeader = true,
           bool EmitFunctionTimestamp = false,
           bool EmitSectionDelimiter = false,
           int InstructionPad = 40,
           bool ShowLineAddresses = true,
           char FieldDelimiter = Chars.Pipe,
           int SectionDelimiterWidth = 120
           ) => new AsmFormatSpec(
               EmitCaptureTermCode, 
               EmitFileHeader, 
               EmitFunctionHeaderEncoding, 
               EmitLocation, 
               EmitFunctionHeader, 
               EmitFunctionTimestamp,
               EmitSectionDelimiter,
               InstructionPad,
               ShowLineAddresses,
               FieldDelimiter,
               SectionDelimiterWidth);

        AsmFormatSpec(
           bool EmitCaptureTermCode, 
           bool EmitFileHeader, 
           bool EmitFunctionHeaderEncoding,
           bool EmitLocation,
           bool EmitFunctionHeader,
           bool EmitFunctionTimestamp,
           bool EmitSectionDelimiter,
           int InstructionPad,
           bool ShowLineAddresses,
           char FieldDelimiter,
           int SectionDelimiterWidth
           ) 
       {
           this.EmitCaptureTermCode = EmitCaptureTermCode;
           this.EmitFileHeader = EmitFileHeader;
           this.EmitFunctionHeaderEncoding = EmitFunctionHeaderEncoding;
           this.EmitLocation = EmitLocation;
           this.EmitFunctionHeader = EmitFunctionHeader;
           this.EmitFunctionTimestamp = EmitFunctionTimestamp;
           this.EmitSectionDelimiter = EmitSectionDelimiter;
           this.InstructionPad = InstructionPad;
           this.ShowLineAddresses = ShowLineAddresses;
           this.FieldDelimiter = string.Concat(Chars.Space, FieldDelimiter, FieldDelimiter, Chars.Space);
           this.SectionDelimiter  = new string(Chars.Dash, 120);
           this.HeaderEncodingFormat = HexFormatConfig.Define();
       }

        public readonly bool EmitCaptureTermCode;

        public readonly bool EmitFileHeader;

        public readonly bool EmitFunctionHeaderEncoding;

        public readonly bool EmitLocation;

        public readonly bool EmitFunctionHeader;

        public readonly bool EmitFunctionTimestamp;

        public readonly bool EmitSectionDelimiter;

        public readonly int InstructionPad;

        public readonly bool ShowLineAddresses;

        public readonly string FieldDelimiter;

        public readonly string SectionDelimiter;

        public readonly HexFormatConfig HeaderEncodingFormat;
    }
}