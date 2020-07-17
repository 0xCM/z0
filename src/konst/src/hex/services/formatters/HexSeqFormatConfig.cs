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
        public HexFormatConfig HexFormat {get;}            
        
        public string Delimiter {get;}

        [MethodImpl(Inline)]
        public static HexSeqFormatConfig Define(in HexFormatConfig hex, string delimiter = null)
            => new HexSeqFormatConfig(hex, delimiter ?? hex.Delimiter.ToString());
            
        [MethodImpl(Inline)]
        public HexSeqFormatConfig(in HexFormatConfig hex, string delimiter)
        {
            Delimiter = delimiter;
            HexFormat = hex;
        }           

    }
}