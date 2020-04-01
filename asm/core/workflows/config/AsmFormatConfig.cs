//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        

    public class AsmFormatConfig
    {
        public static AsmFormatConfig New => new AsmFormatConfig();

        AsmFormatConfig() { }

        public bool EmitCaptureTermCode {get; set;}
            = true;

        public bool EmitFileHeader {get; set;}
            = true;

        public bool EmitFunctionHeaderEncoding {get;set;}
            = true;        

        public HexFormatConfig FunctionHeaderEncodingFormat {get;set;}
            = HexFormatConfig.Define();

        public bool EmitLocation {get;set;}
            = true;

        public bool EmitFunctionHeader {get; set;}
            = true;

        public bool EmitFunctionTimestamp {get;set;}
            = false;

        public bool EmitSectionDelimiter {get;set;}
            = false;

        public bool EmitEncodingProp {get; set;}
            = false;                 

        public int InstructionPad {get;set;}
            = 40;

        public bool ShowLineAddresses {get; set;}
            = true;

        public string FieldDelimiter {get;set;}
            = " || ";

        public string SectionDelimiter {get;set;}
            = new string(Chars.Dash, 120);        
        
        public AsmFormatConfig WithSectionDelimiter()
        {
            EmitSectionDelimiter = true;
            return this;
        }

        public AsmFormatConfig WithoutFunctionTimestamp()
        {
            EmitFunctionTimestamp = false;
            return this;
        }

        public AsmFormatConfig WithoutFunctionOrigin()
        {
            EmitLocation = false;
            return this;
        }

        public AsmFormatConfig WithFunctionOrigin()
        {
            EmitLocation = true;
            return this;
        }

        public AsmFormatConfig WithFunctionTimestamp()
        {
            EmitFunctionTimestamp = true;
            return this;
        }
    }
}