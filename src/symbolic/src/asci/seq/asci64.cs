//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 4040
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    using N = N64;

    public readonly struct asci64 : IAsciSequence<asci64,N>
    {
        internal readonly Vector512<byte> Storage;        

        public static asci64 Blank => AsciCodes.init(n);

        public static asci64 Null => new asci64(Vector512<byte>.Zero);

        public const int Size = 64;

        static N n => default;

        [MethodImpl(Inline)]
        public static implicit operator asci64(string src)
            => new asci64(src);

        [MethodImpl(Inline)]
        public static implicit operator string(asci64 src)
            => src.Text;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(asci64 src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(asci64 src)
            => src.Decoded;

        [MethodImpl(Inline)]
        public asci64(Vector512<byte> src)
        {
            Storage = src;
        }

        [MethodImpl(Inline)]
        public asci64(string src)
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

        public asci64 Zero
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public asci32 Lo
        {
            [MethodImpl(Inline)]
            get => new asci32(Storage.Lo);
        }

        public asci32 Hi
        {
            [MethodImpl(Inline)]
            get => new asci32(Storage.Hi);
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

        public string Text
        {
            [MethodImpl(Inline)]
            get => AsciCodes.format(this);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Text;

        public override string ToString()
            => Text;

        [MethodImpl(Inline)]
        public bool Equals(asci64 src)
            => Storage.Equals(src.Storage);
 
         public override int GetHashCode()
            => Storage.GetHashCode();

        public override bool Equals(object src)
            => src is asci64 j && Equals(j);
    }
}