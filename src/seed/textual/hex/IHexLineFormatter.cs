//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IHexLineFormatter
    {
        string[] FormatHexLines(byte[] data, HexLineConfig config);

        string[] FormatHexLines(byte[] data)
            => FormatHexLines(data, HexLineConfig.Default);
    }
}