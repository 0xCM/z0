//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public readonly struct BitvectorType : IRuleDataType<BitvectorType>
        {
            public uint Width {get;}

            [MethodImpl(Inline)]
            public BitvectorType(uint width)
            {
                Width = width;
            }
        }
    }
}