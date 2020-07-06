//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct SeqFormatConfig : ISeqFormatConfig<SeqFormatConfig>
    {
        [MethodImpl(Inline)]
        public static SeqFormatConfig Define(string delimiter)
            => new SeqFormatConfig(delimiter);
        
        [MethodImpl(Inline)]
        SeqFormatConfig(string delimiter)
        {
            Delimiter = delimiter;
        }

        public string Delimiter {get;}
    }

    public readonly struct DefaultSeqFormatConfig : ISeqFormatConfig<DefaultSeqFormatConfig>
    {        
        public static DefaultSeqFormatConfig Default => default(DefaultSeqFormatConfig);
        
        public string Delimiter 
            => ",";
    }
}