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
    public struct Count : ITextual
    {
        public uint Value;

        [MethodImpl(Inline)]
        public static implicit operator Count(uint count)
            => new Count(count);

        [MethodImpl(Inline)]
        public static implicit operator Count(int count)
            => new Count((uint)count);

        [MethodImpl(Inline)]
        public static implicit operator uint(Count src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator Count(ushort src)
            => new Count(src);

        [MethodImpl(Inline)]
        public static explicit operator int(Count src)
            => (int)src.Value;

        [MethodImpl(Inline)]
        public Count(uint value)
            => Value = value;

        [MethodImpl(Inline)]
        public Count(int value)
            => Value = (uint)value;

        [MethodImpl(Inline)]
        public string Format()
            => Value.ToString();
    }
}