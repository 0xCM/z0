//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = Sizes;

    /// <summary>
    /// Specifies data size in bits
    /// </summary>
    [Datatype]
    public readonly struct Kb
    {
        /// <summary>
        /// Specifies a kilobyte count
        /// </summary>
        public uint Count {get;}

        /// <summary>
        /// Specifies the remaining bit count
        /// </summary>
        public uint Rem {get;}

        [MethodImpl(Inline)]
        public Kb(uint count, uint rem)
        {
            Count = count;
            Rem = rem;
        }

        public ByteSize Bytes
        {
            [MethodImpl(Inline)]
            get => api.bytes(this);
        }

        public BitWidth Bits
        {
            [MethodImpl(Inline)]
            get => api.bits(this);
        }

        public string Format()
            => api.format(this);

        [MethodImpl(Inline)]
        public bool Equals(Kb rhs)
            => api.eq(this, rhs);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)api.hash(this);

        public override bool Equals(object obj)
            => obj is Kb x && Equals(x);

        [MethodImpl(Inline)]
        public static explicit operator ByteSize(Kb src)
            => api.bytes(src);

        [MethodImpl(Inline)]
        public static explicit operator BitWidth(Kb src)
            => api.bits(src);

        [MethodImpl(Inline)]
        public static implicit operator Kb(DataWidth src)
            => api.kb((BitWidth)src);

        [MethodImpl(Inline)]
        public static implicit operator DataWidth(Kb src)
            => api.bits(src);

        [MethodImpl(Inline)]
        public static implicit operator Kb(TypeWidth src)
            => api.kb((BitWidth)src);

        [MethodImpl(Inline)]
        public static implicit operator TypeWidth(Kb src)
            => api.bits(src);

        [MethodImpl(Inline)]
        public static implicit operator Kb(VectorWidth src)
            => api.kb((BitWidth)src);

        [MethodImpl(Inline)]
        public static implicit operator Kb(NumericWidth src)
            => api.kb((BitWidth)src);

        [MethodImpl(Inline)]
        public static bool operator ==(Kb a, Kb b)
            => api.eq(a,b);

        [MethodImpl(Inline)]
        public static bool operator !=(Kb a, Kb b)
            => api.neq(a,b);

        // [MethodImpl(Inline)]
        // public static Kb operator +(Kb lhs, Kb rhs)
        //     => lhs.Count + rhs.Count;

        // [MethodImpl(Inline)]
        // public static Kb operator -(Kb lhs, Kb rhs)
        //     => lhs.Count - rhs.Count;

        // [MethodImpl(Inline)]
        // public static Kb operator *(Kb lhs, Kb rhs)
        //     => lhs.Count * rhs.Count;

        // [MethodImpl(Inline)]
        // public static Kb operator /(Kb lhs, Kb rhs)
        //     => lhs.Count / rhs.Count;

        // [MethodImpl(Inline)]
        // public static Kb operator %(Kb lhs, Kb rhs)
        //     => lhs.Count % rhs.Count;

        /// <summary>
        /// The bit with no size
        /// </summary>
        public static Kb Empty
            => default;

        /// <summary>
        /// The bit with no size
        /// </summary>
        public static Kb Zero
            => default;
    }
}