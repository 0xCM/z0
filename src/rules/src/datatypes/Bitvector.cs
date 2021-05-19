//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Bitvector
    {
        public uint Width {get;}

        [MethodImpl(Inline)]
        public Bitvector(uint width)
        {
            Width = width;
        }
    }
}