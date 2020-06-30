//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    public readonly struct CilFormatConfig
    {
        public static CilFormatConfig Default
            => default;

        public bool EmitFileHeader
            => false;

        public bool EmitFunctionHeader
            => true;

        public string SectionDelimiter
            => new string(Chars.Dash, 120);        

        public bool EmitSectionDelimiter
            => true;
    }
}