//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a data structure that measures a nonnegative count (I mean, really, is there any other kind?) of 32-bit capacity
    /// </summary>
    public struct Count32 : ITextual
    {
        public uint Value;

        [MethodImpl(Inline)]
        public static implicit operator Count32(uint count)
            => new Count32(count);

        [MethodImpl(Inline)]
        public static implicit operator Count32(int count)
            => new Count32((uint)count);

        [MethodImpl(Inline)]
        public static implicit operator uint(Count32 src)
            => src.Value;

        [MethodImpl(Inline)]
        public static explicit operator int(Count32 src)
            => (int)src.Value;

        [MethodImpl(Inline)]
        public Count32(uint value)
            => Value = value;

        [MethodImpl(Inline)]
        public Count32(int value)
            => Value = (uint)value;

        [MethodImpl(Inline)]
        public string Format()
            => Value.ToString();
    }
}