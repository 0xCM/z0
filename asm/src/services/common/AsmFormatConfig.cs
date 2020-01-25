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
        static readonly AsmFormatConfig _Default
            = new AsmFormatConfig();

        public static AsmFormatConfig Default
            => _Default;

        public AsmFormatConfig()
        {

        }

        public bool EmitHeader {get; set;}
            = true;

        public bool HeaderEncodingProp {get; set;}
            = false;
        
        public bool HeaderEncoding {get;set;}
            = true;
         
        public bool HeaderTimestamp {get;set;}
            = true;

        public bool HeaderLocation {get;set;}
            = true;

        public int InstructionPad {get;set;}
            = 40;

        public bool ShowLineAddresses {get; set;}
            = true;

        public string InfoDelimiter {get;set;}
            = " || ";

        public string SectionDelimiter {get;set;}
            = new string(AsciSym.Dash, 120);        

        public bool EmitSectionDelimiter {get;set;}
            = false;

        public AsmFormatConfig Replicate()
            => new AsmFormatConfig
            {   
                EmitHeader = EmitHeader,
                HeaderEncodingProp = HeaderEncodingProp,
                HeaderEncoding = HeaderEncoding,                   
                HeaderLocation = HeaderLocation,
                HeaderTimestamp = HeaderTimestamp,
                InfoDelimiter = InfoDelimiter,
                SectionDelimiter = SectionDelimiter,
                InstructionPad = InstructionPad,
                EmitSectionDelimiter = EmitSectionDelimiter,
                ShowLineAddresses = ShowLineAddresses, 

            };
        public AsmFormatConfig Invert()
            => new AsmFormatConfig{
                ShowLineAddresses = !ShowLineAddresses,
                HeaderEncodingProp = !HeaderEncodingProp,
                EmitHeader = !EmitHeader,
                HeaderTimestamp = !HeaderTimestamp,
                EmitSectionDelimiter = !EmitSectionDelimiter
            };
        
        public AsmFormatConfig WithSeparator()
        {
            var config = Replicate();
            config.EmitSectionDelimiter = true;
            return config;
        }

        public AsmFormatConfig WithoutHeaderTimestamp()
        {
            var config = Replicate();
            config.HeaderTimestamp = false;
            return config;
        }

        public AsmFormatConfig WithHeaderTimestamp()
        {
            var config = Replicate();
            config.HeaderTimestamp = true;
            return config;
        }

    }

}