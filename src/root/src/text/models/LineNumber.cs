//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;


    public readonly struct LineNumber
    {
        public uint Value {get;}

        [MethodImpl(Inline)]
        public LineNumber(uint value)
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
            get => Value != 0;
        }

        public string Format()
            => string.Format("{0:D8}",Value);

        public override string ToString()
            => Format();

        public static LineNumber Empty => default;

        [MethodImpl(Inline)]
        public static implicit operator LineNumber(uint src)
            => new LineNumber(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(LineNumber src)
            => src.Value;

    }
}