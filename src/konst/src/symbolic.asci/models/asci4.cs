//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using N = N4;
    using A = asci4;
    using S = System.UInt32;

    /// <summary>
    /// Defines an asci code sequence of length 4
    /// </summary>
    public readonly struct asci4 : IBytes<A,N>
    {
        internal readonly S Storage;

        [MethodImpl(Inline)]
        public asci4(S src)
        {
            Storage = src;
        }

        [MethodImpl(Inline)]
        public asci4(string src)
        {
            Storage = asci.encode(n,src).Storage;
        }

        public bool IsBlank
        {
            [MethodImpl(Inline)]
            get => IsNull || Equals(Spaced);
        }

        public bool IsNull
        {
            [MethodImpl(Inline)]
            get => Equals(Null);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Storage == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Storage != 0;
        }

        public A Zero
        {
            [MethodImpl(Inline)]
            get => Null;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => asci.length(this);
        }

        public int Capacity
        {
            [MethodImpl(Inline)]
            get => Size;
        }

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => asci.bytes(this);
        }

        public ReadOnlySpan<char> Decoded
        {
            [MethodImpl(Inline)]
            get => asci.decode(this);
        }

        public string Text
        {
            [MethodImpl(Inline)]
            get => asci.format(this);
        }

        [MethodImpl(Inline)]
        public bool Equals(A src)
            => Storage.Equals(src.Storage);

        public override bool Equals(object src)
            => src is A j && Equals(j);

        public override int GetHashCode()
            => Storage.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => Text;

        public override string ToString()
            => Text;

        public static A Null
        {
            [MethodImpl(Inline)]
            get => new A(default(S));
        }

        public static A Spaced
        {
            [MethodImpl(Inline)]
            get => asci.init(n);
        }

        public const int Size = 4;

        static N n => default;



        [MethodImpl(Inline)]
        public static implicit operator A(string src)
            => new A(src);

        [MethodImpl(Inline)]
        public static implicit operator string(A src)
            => src.Text;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(A src)
            => src.View;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(A src)
            => src.Decoded;

        [MethodImpl(Inline)]
        public static implicit operator A(ushort src)
            => new A(src);

        [MethodImpl(Inline)]
        public static implicit operator A(uint src)
            => new A(src);

        [MethodImpl(Inline)]
        public static explicit operator byte(A src)
            => (byte)src.Storage;

        [MethodImpl(Inline)]
        public static explicit operator ushort(A src)
            => (ushort)src.Storage;

        [MethodImpl(Inline)]
        public static explicit operator uint(A src)
            => src.Storage;

        [MethodImpl(Inline)]
        public static bool operator ==(A a, A b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(A a, A b)
            => !a.Equals(b);
    }
}