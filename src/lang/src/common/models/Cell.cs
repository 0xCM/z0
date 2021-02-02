//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Cell
    {
        public BitSize Width {get;}

        [MethodImpl(Inline)]
        public Cell(BitSize width)
        {
            Width = width;
        }
    }
}