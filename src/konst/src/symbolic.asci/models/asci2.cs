//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using N = N2;
    using W = W16;
    using A = asci2;
    using S = System.UInt16;

    /// <summary>
    /// Defines an asci code sequence of length 2
    /// </summary>
    public readonly struct asci2 : IBytes<A,N>
    {
        internal readonly S Storage;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(A src)
            => src.View;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(A src)
            => src.Decoded;

        [MethodImpl(Inline)]
        public static implicit operator string(A src)
            => src.Text;

        [MethodImpl(Inline)]
        public static implicit operator A(string src)
            => new A(src);

        [MethodImpl(Inline)]
        public static implicit operator A(S src)
            => new A(src);

        [MethodImpl(Inline)]
        public static bool operator ==(A a, A b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(A a, A b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static implicit operator ushort(A src)
            => src.Storage;

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
            get => Null.Equals(this);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !Null.Equals(this);
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
            => Storage == src.Storage;

        public override bool Equals(object src)
            => src is A x && Equals(x);

        public override int GetHashCode()
            => Storage.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => Text;

        public override string ToString()
            => Text;

        public const int Size = 2;

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

        static N n => default;

        static W w => default;

        [MethodImpl(Inline)]
        public asci2(S src)
        {
            Storage = src;
        }

        [MethodImpl(Inline)]
        public asci2(string src)
        {
            Storage = asci.encode(n,src).Storage;
        }
    }
}