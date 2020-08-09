//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    public readonly struct CellCount : ITextual
    {
        public readonly uint Value;

        [MethodImpl(Inline)]
        public static implicit operator CellCount(uint count)
            => new CellCount(count);

        [MethodImpl(Inline)]
        public static implicit operator CellCount(int count)
            => new CellCount((uint)count);

        [MethodImpl(Inline)]
        public CellCount(uint value)
        {
            Value = value;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Value.ToString();
    }
}