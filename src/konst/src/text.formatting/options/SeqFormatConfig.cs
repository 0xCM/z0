//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static data.tchars;

    public readonly struct SeqFormatConfig : ISeqFormat<SeqFormatConfig>
    {
        [MethodImpl(Inline), Op]
        public static SeqFormatConfig define(string delimiter = Comma)
            => new SeqFormatConfig(delimiter);

        public string Delimiter {get;}

        [MethodImpl(Inline)]
        public SeqFormatConfig(string delimiter)
            => Delimiter = delimiter;

    }
}