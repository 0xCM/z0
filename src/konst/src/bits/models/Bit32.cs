//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines a boolean value that is 32 bits wide
    /// </summary>
    public readonly struct Bit32 : IEquatable<Bit32>, ITextual
    {
        readonly uint State;

        /// <summary>
        /// Implicitly constructs a bool from a bit
        /// </summary>
        /// <param name="state">The state of the bit to construct</param>
        [MethodImpl(Inline), Op]
        public static implicit operator bool(Bit32 src)
            => src.State != 0;

        /// <summary>
        /// Inverts the bitstate
        /// </summary>
        /// <param name="a">The source bit</param>
        [MethodImpl(Inline)]
        public static Bit32 operator !(Bit32 a)
            => new Bit32(a.State != 0 ? 0 : 1);

        /// <summary>
        /// Returns true if the bit is enabled, false otherwise
        /// </summary>
        /// <param name="b">The bit to test</param>
        [MethodImpl(Inline), Op]
        public static bool operator true(Bit32 b)
            => b.State != 0;

        /// <summary>
        /// Returns false if the bit is disabled, true otherwise
        /// </summary>
        /// <param name="b">The bit to test</param>
        [MethodImpl(Inline), Op]
        public static bool operator false(Bit32 b)
            => b.State == 0;

        [MethodImpl(Inline), Op]
        public static explicit operator Bit32(bool src)
            => new Bit32(src);

        [MethodImpl(Inline), Op]
        public static explicit operator Bit32(uint src)
            => new Bit32(src);

        [MethodImpl(Inline), Op]
        public static explicit operator byte(Bit32 src)
            => (byte)src.State;

        [MethodImpl(Inline)]
        public static bool operator ==(Bit32 a, Bit32 b)
            => a.State == b.State;

        [MethodImpl(Inline)]
        public static bool operator !=(Bit32 a, Bit32 b)
            => a.State != b.State;

        public const string Zero = "0";

        public const string One = "1";

        [MethodImpl(Inline)]
        public Bit32(bool src)
            => State = z.@byte(src);

        [MethodImpl(Inline)]
        public Bit32(uint src)
            => State = src;

        [MethodImpl(Inline)]
        public bool Equals(Bit32 src)
            => State == src.State;

        [MethodImpl(Inline)]
        public string Format()
            => State != 0 ? One : Zero;

        public override int GetHashCode()
            => (int)State;


        public override bool Equals(object src)
            => src is Bit32 x && Equals(x);
    }
}