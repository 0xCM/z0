//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly ref struct HexString
    {
        public ReadOnlySpan<AsciCode> Data {get;}

        public HexString(ReadOnlySpan<AsciCode> src)
        {
            Data = src;
        }
    }
}