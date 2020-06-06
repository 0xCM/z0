//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Typed;

    using API = AsciCodes;
    using N = N2;

    /// <summary>
    /// Defines an asci code sequence of length 2
    /// </summary>
    public readonly struct AsciCode2 : IAsciSequence<AsciCode2,N>
    {
        public static AsciCode2 Empty => new AsciCode2(0);

        public const int Size = 2;

        internal readonly ushort Storage;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(AsciCode2 src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(AsciCode2 src)
            => src.Decoded;

        [MethodImpl(Inline)]
        public AsciCode2(ushort src)
        {
            Storage = src;
        }
        
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Empty.Equals(this);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !Empty.Equals(this);
        }
        public AsciCode2 Zero
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
        public bool Equals(AsciCode2 src)
            => Storage == src.Storage;

        public override bool Equals(object src)
            => src is AsciCode2 x && Equals(x);

        public override int GetHashCode()
            => Storage.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => API.format(this);

        public override string ToString()
            => Format(); 

        [MethodImpl(Inline)]
        public static bool operator ==(AsciCode2 a, AsciCode2 b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(AsciCode2 a, AsciCode2 b)
            => !a.Equals(b);
        
        [MethodImpl(Inline)]
        public static implicit operator ushort(AsciCode2 src)
            => src.Storage;    
    }
}