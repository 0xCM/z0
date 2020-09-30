//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct SeqFormatConfig : ISeqFormat<SeqFormatConfig>
    {
        [MethodImpl(Inline), Op]
        public static SeqFormatConfig define(string delimiter = AsciCharText.Comma)
            => new SeqFormatConfig(delimiter);
        public string Delimiter {get;}

        [MethodImpl(Inline)]
        public SeqFormatConfig(string delimiter)
        {
            Delimiter = delimiter;
        }
    }
}