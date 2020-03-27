//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    public class CilFormatConfig
    {
        public static CilFormatConfig Default
            => new CilFormatConfig();

        public CilFormatConfig()
        {

        }

        public bool EmitFileHeader {get;set;}
            = false;

        public bool EmitFunctionHeader {get; set;}
            = true;

        public string SectionDelimiter {get;set;}
            = new string(Chars.Dash, 120);        

        public bool EmitSectionDelimiter {get;set;}
            = true;
    }
}