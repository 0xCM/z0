//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    public readonly struct AsmFormatSpec
    {        
        public static AsmFormatSpec Default 
            => Create();

        public static AsmFormatSpec WithSectionDelimiter 
            => Create(EmitSectionDelimiter : true);

        public static AsmFormatSpec WithFunctionTimestamp 
            => Create(EmitFunctionTimestamp : true);

        public static AsmFormatSpec DefaultStreamFormat 
            => Create(EmitSectionDelimiter : true, EmitBaseAddress : true);

        public static AsmFormatSpec Create(
           bool EmitCaptureTermCode = true, 
           bool EmitFileHeader = true, 
           bool EmitFunctionHeaderEncoding = true,
           bool EmitBaseAddress = true,
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
               EmitBaseAddress, 
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
           this.EmitBaseAddress = EmitLocation;
           this.EmitFunctionHeader = EmitFunctionHeader;
           this.EmitFunctionTimestamp = EmitFunctionTimestamp;
           this.EmitSectionDelimiter = EmitSectionDelimiter;
           this.InstructionPad = InstructionPad;
           this.EmitLineAddresses = ShowLineAddresses;
           this.FieldDelimiter = string.Concat(Chars.Space, FieldDelimiter, FieldDelimiter, Chars.Space);
           this.SectionDelimiter  = new string(Chars.Dash, 120);
           this.HeaderEncodingFormat = HexFormat.configure();
       }

        public readonly bool EmitCaptureTermCode;

        public readonly bool EmitFileHeader;

        public readonly bool EmitFunctionHeaderEncoding;

        public readonly bool EmitBaseAddress;

        public readonly bool EmitFunctionHeader;

        public readonly bool EmitFunctionTimestamp;

        public readonly bool EmitSectionDelimiter;

        public readonly int InstructionPad;

        public readonly bool EmitLineAddresses;

        public readonly string FieldDelimiter;

        public readonly string SectionDelimiter;

        public readonly HexFormatConfig HeaderEncodingFormat;
    }
}