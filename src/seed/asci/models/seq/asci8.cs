//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 4040
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using N = N8;
    using A = asci8;
    using W = W64;
    using S = System.UInt64;

    /// <summary>
    /// Defines a 64-bit asci code sequence of length 8
    /// </summary>
    public readonly struct asci8 : IAsciSequence<A,N>
    {                
        internal readonly S Storage;

        [MethodImpl(Inline)]
        public static implicit operator A(string src)
            => new A(src);

        [MethodImpl(Inline)]
        public static implicit operator string(A src)
            => src.Text;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(A src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(A src)
            => src.Decoded;

        [MethodImpl(Inline)]
        public static implicit operator A(uint src)
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
            get => Equals(Null);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !Equals(Null);
        }

        public A Zero
        {
            [MethodImpl(Inline)]
            get => Null;
        }
        
        /// <summary>
        /// Specifies the number of characters that precede a null terminator, if any; otherwise, returns the maximum content length
        /// </summary>
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

        public ReadOnlySpan<byte> Encoded
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
            => src is A x && Equals(x);

        public override int GetHashCode()
            => Storage.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => Text;
 
        public override string ToString()
            => Text;

        public const int Size = 8;

        static N n => default;
        
        static W w => default;
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

        [MethodImpl(Inline)]
        public asci8(S src)
            => Storage = src;
      
        [MethodImpl(Inline)]
        public asci8(string src)
            => Storage = asci.encode(n,src).Storage;

 
    }
}