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

    using N = N64;

    public readonly struct AsciCode64 : IAsciSequence<AsciCode64,N>
    {
        public static AsciCode64 Blank => AsciCodes.init(n);

        public static AsciCode64 Null => new AsciCode64(Vector512<byte>.Zero);

        public const int Size = 64;

        static N n => default;

        internal readonly Vector512<byte> Storage;        

        [MethodImpl(Inline)]
        public static implicit operator AsciCode64(string src)
            => new AsciCode64(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(AsciCode64 src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(AsciCode64 src)
            => src.Decoded;

        [MethodImpl(Inline)]
        public AsciCode64(Vector512<byte> src)
        {
            Storage = src;
        }

        [MethodImpl(Inline)]
        public AsciCode64(string src)
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

        public int Length
        {
            [MethodImpl(Inline)]
            get => Symbolic.length(this);
        }

        public AsciCode64 Zero
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public AsciCode32 Lo
        {
            [MethodImpl(Inline)]
            get => new AsciCode32(Storage.Lo);
        }

        public AsciCode32 Hi
        {
            [MethodImpl(Inline)]
            get => new AsciCode32(Storage.Hi);
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
        public string Format()
            => AsciCodes.format(this);

        [MethodImpl(Inline)]
        public bool Equals(AsciCode64 src)
            => Storage.Equals(src.Storage);
 
         public override int GetHashCode()
            => Storage.GetHashCode();

        public override bool Equals(object src)
            => src is AsciCode64 j && Equals(j);
    }
}