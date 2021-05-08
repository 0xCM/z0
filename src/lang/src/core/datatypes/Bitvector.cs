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
        public BitWidth Width {get;}

        [MethodImpl(Inline)]
        public Bitvector(BitWidth width)
        {
            Width = width;
        }
    }
}