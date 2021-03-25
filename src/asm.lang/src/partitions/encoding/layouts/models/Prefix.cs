//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct LayoutComponents
    {
        public readonly struct Prefix : IPrefix
        {
            public Cell8 Value {get;}

            public Prefix(Cell8 value)
            {
                Value = value;
            }

            public bool IsEmpty
                => Value == 0;

            public string Format()
                => Value.Format();

            public override string ToString()
                => Format();

        }
    }
}