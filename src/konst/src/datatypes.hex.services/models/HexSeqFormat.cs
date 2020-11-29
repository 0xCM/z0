//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct HexSeqFormat : ISeqFormat<HexSeqFormat>
    {
        public HexFormatOptions HexFormat {get;}

        public string Delimiter {get;}

        [MethodImpl(Inline)]
        public HexSeqFormat(in HexFormatOptions hex, string delimiter)
        {
            Delimiter = delimiter;
            HexFormat = hex;
        }
    }
}