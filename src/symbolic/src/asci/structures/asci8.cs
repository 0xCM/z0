//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 4040
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Typed;

    using N = N8;
    
    /// <summary>
    /// Defines a 64-bit asci code sequence of length 8
    /// </summary>
    public readonly struct asci8 : IAsciSequence<asci8,N>
    {        
        public static asci8 Empty => new asci8(0);        

        public const int Size = 8;

        static N n => default;
        
        internal readonly ulong Storage;

        [MethodImpl(Inline)]
        public static implicit operator asci8(string src)
            => new asci8(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(asci8 src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(asci8 src)
            => src.Decoded;

        [MethodImpl(Inline)]
        public asci8(ulong src)
        {
            Storage = src;
        }
      
        [MethodImpl(Inline)]
        public asci8(string src)
        {
            Storage = AsciCodes.encode(n,src).Storage;
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

        public asci8 Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        public int MaxLength
        {
            [MethodImpl(Inline)]
            get => Size;
        }

        public ReadOnlySpan<byte> Encoded
        {
            [MethodImpl(Inline)]
            get => Symbolic.bytes(this);
        }

        public ReadOnlySpan<char> Decoded
        {
            [MethodImpl(Inline)]
            get => AsciCodes.decode(this);
        }

        [MethodImpl(Inline)]
        public bool Equals(asci8 src)
            => Storage == src.Storage;

        public override bool Equals(object src)
            => src is asci8 x && Equals(x);

        public override int GetHashCode()
            => Storage.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => AsciCodes.format(this);
 
        public override string ToString()
            => Format(); 

        [MethodImpl(Inline)]
        public static bool operator ==(asci8 a, asci8 b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(asci8 a, asci8 b)
            => !a.Equals(b);
    }
}