//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct HexSequenceFormatConfig : ISequenceFormatConfig<HexSequenceFormatConfig>
    {        
        public HexFormatConfig HexFormat {get;}            
        
        public string Delimiter {get;}

        [MethodImpl(Inline)]
        public static HexSequenceFormatConfig define(in HexFormatConfig hex, string delimiter = null)
            => new HexSequenceFormatConfig(hex, delimiter ?? hex.Delimiter.ToString());
            
        [MethodImpl(Inline)]
        public HexSequenceFormatConfig(in HexFormatConfig hex, string delimiter)
        {
            Delimiter = delimiter;
            HexFormat = hex;
        }           
    }
}