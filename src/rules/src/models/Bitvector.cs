//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    partial struct Rules
    {
        public readonly struct Bitvector : IRuleDataType<Bitvector>
        {
            public uint Width {get;}

            [MethodImpl(Inline)]
            public Bitvector(uint width)
            {
                Width = width;
            }
        }
    }
}