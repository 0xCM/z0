//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct HexSeqFormatConfig : ISeqFormatConfig<HexSeqFormatConfig>, IFormatConfig<HexSeqFormatConfig>
    {
        public static HexSeqFormatConfig Define(in HexFormatConfig hex, string delimiter = null)
            => new HexSeqFormatConfig(hex, delimiter ?? hex.Delimiter.ToString());
            
        HexSeqFormatConfig(in HexFormatConfig hex, string delimiter)
        {
            this.Delimiter = delimiter;
            this.HexFormat = hex;
        }
            
        public HexFormatConfig HexFormat {get;}            
        
        public string Delimiter {get;}
    }
}