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
            ShowLineAddresses = true;
            ShowRawBytes = true;
            EmitHeader = true;
            TimestampHeader = true;
        }

        public bool ShowLineAddresses {get; set;}
        
        public bool ShowRawBytes {get; set;}

        public bool EmitHeader {get; set;}

        public bool TimestampHeader {get;set;}

        public AsmFormatConfig Invert()
            => new AsmFormatConfig{
                ShowLineAddresses = !ShowLineAddresses,
                ShowRawBytes = !ShowRawBytes,
                EmitHeader = !EmitHeader,
                TimestampHeader = !TimestampHeader
            };
    }

}