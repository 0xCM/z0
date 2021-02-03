//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Bitvector : IDataType<Bitvector>
    {
        public BitSize Width {get;}

        [MethodImpl(Inline)]
        public Bitvector(BitSize width)
        {
            Width = width;
        }
    }
}