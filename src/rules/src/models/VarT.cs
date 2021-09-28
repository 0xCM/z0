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
        public readonly struct Var<T>
        {
            public readonly uint Id;

            public readonly T Value;

            [MethodImpl(Inline)]
            public Var(uint id, T value)
            {
                Id = id;
                Value = value;
            }
        }
    }
}