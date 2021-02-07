//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct IntelAlgorithms
    {
        public readonly struct BitVector
        {
            public Identifier Name {get;}

            public ushort Size {get;}

            [MethodImpl(Inline)]
            public BitVector(string name, ushort size)
            {
                Name = name;
                Size = size;
            }
        }
    }
}
