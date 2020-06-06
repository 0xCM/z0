//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 4040
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Typed;

    using N = N8;
    
    /// <summary>
    /// Defines a 64-bit asci code sequence of length 8
    /// </summary>
    public readonly struct AsciCode8 : IAsciSequence<AsciCode8,N>
    {        
        public static AsciCode8 Empty => new AsciCode8(0);        

        public const int Size = 8;

        static N n => default;
        
        internal readonly ulong Storage;

        [MethodImpl(Inline)]
        public static implicit operator AsciCode8(string src)
            => new AsciCode8(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(AsciCode8 src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(AsciCode8 src)
            => src.Decoded;

        [MethodImpl(Inline)]
        public AsciCode8(ulong src)
        {
            Storage = src;
        }
      
        [MethodImpl(Inline)]
        public AsciCode8(string src)
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

        public AsciCode8 Zero
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
        public bool Equals(AsciCode8 src)
            => Storage == src.Storage;

        public override bool Equals(object src)
            => src is AsciCode8 x && Equals(x);

        public override int GetHashCode()
            => Storage.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => AsciCodes.format(this);
 
        public override string ToString()
            => Format(); 

        [MethodImpl(Inline)]
        public static bool operator ==(AsciCode8 a, AsciCode8 b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(AsciCode8 a, AsciCode8 b)
            => !a.Equals(b);
    }
}