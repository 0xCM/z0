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

    using N = N16;

    /// <summary>
    /// Defines an asci code sequence of length 16
    /// </summary>
    public readonly struct AsciCode16 : IAsciSequence<AsciCode16,N>
    {
        public const int Size = 16;
        
        public static AsciCode16 Blank => AsciCodes.init(n);
        
        public static AsciCode16 Null => new AsciCode16(Vector128<byte>.Zero);

        static N n => default;


        [MethodImpl(Inline)]
        public static AsciCode16 init(AsciCharCode fill = AsciCharCode.Space)
            => new AsciCode16(SymBits.vbroadcast(w128, (byte)fill));

        internal readonly Vector128<byte> Storage;        

        [MethodImpl(Inline)]
        public static implicit operator AsciCode16(string src)
            => new AsciCode16(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(AsciCode16 src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(AsciCode16 src)
            => src.Decoded;

        [MethodImpl(Inline)]
        public AsciCode16(Vector128<byte> src)
        {
            Storage = src;
        }

        [MethodImpl(Inline)]
        public AsciCode16(string src)
        {
            Storage = AsciCodes.encode(n16,src).Storage;
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

        public AsciCode16 Zero
        {
            [MethodImpl(Inline)]
            get => Null;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Symbolic.length(this);
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
        public bool Equals(AsciCode16 src)
            => Storage.Equals(src.Storage);
 
        [MethodImpl(Inline)]
        public void CopyTo(Span<byte> dst)
            => AsciCodes.copy(this,dst);
 
         public override int GetHashCode()
            => Storage.GetHashCode();

        public override bool Equals(object src)
            => src is AsciCode16 j && Equals(j);

        [MethodImpl(Inline)]
        public string Format()
            => AsciCodes.format(this);
 
        public override string ToString()
            => Format(); 

        [MethodImpl(Inline)]
        public static bool operator ==(AsciCode16 a, AsciCode16 b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(AsciCode16 a, AsciCode16 b)
            => !a.Equals(b);
    }
}