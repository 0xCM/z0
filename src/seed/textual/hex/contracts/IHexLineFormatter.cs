//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IHexLineFormatter
    {
        string[] FormatHexLines(byte[] data, HexLineConfig config);

        string[] FormatHexLines(byte[] data)
            => FormatHexLines(data, HexLineConfig.Default);
    }
}