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
        public readonly struct OneByteImm : IOneByteImm
        {
            public Cell8 Value {get;}

            [MethodImpl(Inline)]
            public OneByteImm(Cell8 value)
            {
                Value = value;
            }

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Value == 0;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => !IsEmpty;
            }

            public static OneByteImm Empty
                => default;

            [MethodImpl(Inline)]
            public static implicit operator OneByteImm(byte src)
                => new OneByteImm(src);

            [MethodImpl(Inline)]
            public static implicit operator OneByteImm(Cell8 src)
                => new OneByteImm(src);
        }
    }
}