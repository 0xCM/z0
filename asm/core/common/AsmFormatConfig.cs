//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.IO;

    public class AsmFormatConfig
    {
        public static AsmFormatConfig Default
            => new AsmFormatConfig();

        public AsmFormatConfig()
        {

        }

        public bool EmitCaptureTermCode {get; set;}
            = true;

        public bool EmitFileHeader {get; set;}
            = true;

        public bool EmitFunctionHeaderEncoding {get;set;}
            = true;        

        public HexFormatConfig FunctionHeaderEncodingFormat {get;set;}
            = HexFormatConfig.Define();

        public bool EmitFunctionOrigin {get;set;}
            = false;

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
            = new string(AsciSym.Dash, 120);        
        
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
            EmitFunctionOrigin = false;
            return this;
        }

        public AsmFormatConfig WithFunctionOrigin()
        {
            EmitFunctionOrigin = true;
            return this;
        }

        public AsmFormatConfig WithFunctionTimestamp()
        {
            EmitFunctionTimestamp = true;
            return this;
        }
    }
}