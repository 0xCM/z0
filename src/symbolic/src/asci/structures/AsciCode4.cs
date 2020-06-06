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
    using N = N4;    

    /// <summary>
    /// Defines an asci code sequence of length 4
    /// </summary>
    public readonly struct AsciCode4 : IAsciSequence<AsciCode4,N>
    {        
        public static AsciCode4 Empty => new AsciCode4(0);

        public const int Size = 4;

        static N n => default;
        
        internal readonly uint Storage;

        [MethodImpl(Inline)]
        public static implicit operator AsciCode4(string src)
            => new AsciCode4(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(AsciCode4 src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(AsciCode4 src)
            => src.Decoded;

        [MethodImpl(Inline)]
        public AsciCode4(uint src)
        {
            Storage = src;
        }

        [MethodImpl(Inline)]
        public AsciCode4(string src)
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

        public AsciCode4 Zero
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
        public bool Equals(AsciCode4 src)
            => Storage == src.Storage;

        public override bool Equals(object src)
            => src is AsciCode4 j && Equals(j);

        public override int GetHashCode()
            => Storage.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => API.format(this);
 
        public override string ToString()
            => Format(); 

        [MethodImpl(Inline)]
        public static bool operator ==(AsciCode4 a, AsciCode4 b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(AsciCode4 a, AsciCode4 b)
            => !a.Equals(b);
    }
}