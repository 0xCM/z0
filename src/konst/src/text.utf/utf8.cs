//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct utf8
    {
        readonly byte[] Data;

        [MethodImpl(Inline)]
        public utf8(byte[] src)
            => Data = src;
    }
}