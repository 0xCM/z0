//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    using N = N4;    

    /// <summary>
    /// Defines an asci code sequence of length 4
    /// </summary>
    public readonly struct asci4 : IAsciSequence<asci4,N>
    {        
        public static asci4 Blank => new asci4(0x20202020);

        public static asci4 Null => new asci4(0);

        public const int Size = 4;

        static N n => default;
        
        internal readonly uint Storage;

        [MethodImpl(Inline)]
        public static asci4 From(ReadOnlySpan<AsciCharCode> src)
            => new asci4(Root.head(Root.cast<AsciCharCode,uint>(src)));

        [MethodImpl(Inline)]
        public static implicit operator asci4(string src)
            => new asci4(src);

        [MethodImpl(Inline)]
        public static implicit operator string(asci4 src)
            => src.Text;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(asci4 src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(asci4 src)
            => src.Decoded;

        [MethodImpl(Inline)]
        public static implicit operator asci4(ushort src)
            => new asci4(src);

        [MethodImpl(Inline)]
        public static implicit operator asci4(uint src)
            => new asci4(src);

        [MethodImpl(Inline)]
        public static explicit operator byte(asci4 src)
            => (byte)src.Storage;

        [MethodImpl(Inline)]
        public static explicit operator ushort(asci4 src)
            => (ushort)src.Storage;

        [MethodImpl(Inline)]
        public static explicit operator uint(asci4 src)
            => src.Storage;

        [MethodImpl(Inline)]
        public asci4(uint src)
        {
            Storage = src;
        }

        [MethodImpl(Inline)]
        public asci4(string src)
        {
            Storage = asci.encode(n,src).Storage;
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

        public asci4 Zero
        {
            [MethodImpl(Inline)]
            get => Null;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => asci.length(this);
        }
        
        public int MaxLength
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
        public bool Equals(asci4 src)
            => Storage == src.Storage;

        public override bool Equals(object src)
            => src is asci4 j && Equals(j);

        public override int GetHashCode()
            => Storage.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => Text;
 
        public override string ToString()
            => Text;

        [MethodImpl(Inline)]
        public static bool operator ==(asci4 a, asci4 b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(asci4 a, asci4 b)
            => !a.Equals(b);
    }
}