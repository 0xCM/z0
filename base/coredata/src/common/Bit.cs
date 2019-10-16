//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Linq;

    using static zfunc;

    public readonly struct bit
    {
        readonly uint state;

        /// <summary>
        /// Constructs an enabled bit
        /// </summary>
        public static bit On => true;

        /// <summary>
        /// Constructs a disabled bit
        /// </summary>
        public static bit Off => false;
        
        /// <summary>
        /// Returns true if the bit is enabled, false otherwise
        /// </summary>
        /// <param name="b">The bit to test</param>
        public static bool operator true(bit b)
            => b.state == 1;

        /// <summary>
        /// Returns false if the bit is disabled, true otherwise
        /// </summary>
        /// <param name="b">The bit to test</param>
        public static bool operator false(bit b)
            => b.state == 0;

        /// <summary>
        /// Implicitly constructs a bit from a bool
        /// </summary>
        /// <param name="state">The state of the bit to construct</param>
        [MethodImpl(Inline)]
        public static implicit operator bit(bool state)
            => new bit(state);

        /// <summary>
        /// Implicitly constructs a bool from a bit
        /// </summary>
        /// <param name="state">The state of the bit to construct</param>
        [MethodImpl(Inline)]
        public static implicit operator bool(bit src)
            => src.state == 1;

        /// <summary>
        /// Combines the states of the source bits
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline)]
        public static bit operator + (bit a, bit b) 
            => Wrap(a.state ^ b.state);

        /// <summary>
        /// Computes the bitwise AND between the operands
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline)]
        public static bit operator & (bit a, bit b) 
            => Wrap(a.state & b.state);

        /// <summary>
        /// Computes the bitwise OR between the operands
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline)]
        public static bit operator | (bit a, bit b) 
            => Wrap(a.state | b.state);

        /// <summary>
        /// Computes the bitwise XOR between the operands
        /// </summary>
        /// <param name="a">The left bit</param>
        /// <param name="b">The right bit</param>
        [MethodImpl(Inline)]
        public static bit operator ^ (bit a, bit b) 
            => Wrap(a.state ^ b.state);

        /// <summary>
        /// Inverts the state of the source bit
        /// </summary>
        /// <param name="a">The source bit</param>
        [MethodImpl(Inline)]
        public static bit operator ~ (bit a) 
            => SafeWrap(~a.state);

        /// <summary>
        /// Inverts the state of the source bit
        /// </summary>
        /// <param name="a">The source bit</param>
        [MethodImpl(Inline)]
        public static bit operator ! (bit a) 
            => SafeWrap(~a.state);

        [MethodImpl(Inline)]
        public static bool operator ==(bit a, bit b)
            => a.state == b.state;

        [MethodImpl(Inline)]
        public static bool operator !=(bit a, bit b)
            => a.state != b.state;

        [MethodImpl(Inline)]
        bit(bool on)
            => this.state  = on ? 1u : 0u;

        [MethodImpl(Inline)]
        bit(uint state)
            => this.state = state;
        
        [MethodImpl(Inline)]
        public static bit nand(bit a, bit b)
            => SafeWrap(~(a.state & b.state));

        [MethodImpl(Inline)]
        public static bit nor(bit a, bit b)
            => SafeWrap(~(a.state | b.state));

        [MethodImpl(Inline)]
        public static bit xnor(bit a, bit b)
            => SafeWrap(~(a.state ^ b.state));

        [MethodImpl(Inline)]
        public static bit andnot(bit a, bit b)
            => SafeWrap(a.state & ~b.state);

        [MethodImpl(Inline)]
        public static bit select(bit a, bit b, bit c)
            => a ? b : c;

        [MethodImpl(Inline)]
        static bit Wrap(uint state)
            => new bit(state);

        [MethodImpl(Inline)]
        static bit SafeWrap(uint state)
            => new bit(state & 1);


        [MethodImpl(Inline)]
        public bool Equals(bit b)
            => state == b.state;

        public override bool Equals(object b)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
  
    }


}