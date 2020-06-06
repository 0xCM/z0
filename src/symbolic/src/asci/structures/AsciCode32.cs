//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 4040
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Typed;

    using N = N32;
    
    /// <summary>
    /// Defines an asci code sequence of length 32
    /// </summary>
    public readonly struct AsciCode32 : IAsciSequence<AsciCode32,N>
    {
        public static AsciCode32 Blank => AsciCodes.init(n);

        public static AsciCode32 Null => new AsciCode32(Vector256<byte>.Zero);

        public const int Size = 32;

        static N n => default;

        internal readonly Vector256<byte> Storage;        

        [MethodImpl(Inline)]
        public static implicit operator AsciCode32(string src)
            => new AsciCode32(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(AsciCode32 src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(AsciCode32 src)
            => src.Decoded;


        [MethodImpl(Inline)]
        public AsciCode32(Vector256<byte> src)
        {
            Storage = src;
        }
        
        [MethodImpl(Inline)]
        public AsciCode32(string src)
        {
            Storage = AsciCodes.encode(n,src).Storage;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Storage.Equals(default);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !Storage.Equals(default);
        }

        public int MaxLength
        {
            [MethodImpl(Inline)]
            get => Size;
        }

        public AsciCode32 Zero
        {
            [MethodImpl(Inline)]
            get => Null;
        }

        public AsciCode16 Lo
        {
            [MethodImpl(Inline)]
            get => new AsciCode16(Storage.GetLower());
        }

        public AsciCode16 Hi
        {
            [MethodImpl(Inline)]
            get => new AsciCode16(Storage.GetUpper());
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
        public bool Equals(AsciCode32 src)
            => Storage.Equals(src.Storage);
 
         public override int GetHashCode()
            => Storage.GetHashCode();

        public override bool Equals(object src)
            => src is AsciCode32 j && Equals(j);

        [MethodImpl(Inline)]
        public string Format()
            => AsciCodes.format(this);
 
        public override string ToString()
            => Format(); 

        [MethodImpl(Inline)]
        public static bool operator ==(AsciCode32 a, AsciCode32 b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(AsciCode32 a, AsciCode32 b)
            => !a.Equals(b); 
    }
}