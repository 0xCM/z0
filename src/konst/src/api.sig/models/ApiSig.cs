//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static z;
    using static Konst;

    public readonly struct ApiSig
    {
        readonly Vector256<byte> Data;

        internal ApiSig(Vector256<byte> src)
        {
            Data = src;
        }
    }
}