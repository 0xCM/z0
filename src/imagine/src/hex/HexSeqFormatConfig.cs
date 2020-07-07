//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct HexSeqFormatConfig : ISeqFormatConfig<HexSeqFormatConfig>
    {        
        [MethodImpl(Inline)]
        public static HexSeqFormatConfig Define(in HexFormatConfig hex, string delimiter = null)
            => new HexSeqFormatConfig(hex, delimiter ?? hex.Delimiter.ToString());
            
        [MethodImpl(Inline)]
        HexSeqFormatConfig(in HexFormatConfig hex, string delimiter)
        {
            Delimiter = delimiter;
            HexFormat = hex;
        }
            
        public HexFormatConfig HexFormat {get;}            
        
        public string Delimiter {get;}
    }
}