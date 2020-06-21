//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;


    using N = N2;

    /// <summary>
    /// Defines an asci code sequence of length 2
    /// </summary>
    public readonly struct asci2 : IAsciSequence<asci2,N>
    {
        public static asci2 Blank => new asci2(0x2020);

        public static asci2 Null => new asci2(0);

        public const int Size = 2;

        internal readonly ushort Storage;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(asci2 src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(asci2 src)
            => src.Decoded;

        [MethodImpl(Inline)]
        public static asci2 From(ReadOnlySpan<AsciCharCode> src)
            => new asci2(Root.head(Root.cast<AsciCharCode,ushort>(src)));

        [MethodImpl(Inline)]
        public static implicit operator string(asci2 src)
            => src.Text;

        [MethodImpl(Inline)]
        public static implicit operator asci2(ushort src)
            => new asci2(src);

        [MethodImpl(Inline)]
        public asci2(ushort src)
        {
            Storage = src;
        }
        
        
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Null.Equals(this);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !Null.Equals(this);
        }
        public asci2 Zero
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
        public bool Equals(asci2 src)
            => Storage == src.Storage;

        public override bool Equals(object src)
            => src is asci2 x && Equals(x);

        public override int GetHashCode()
            => Storage.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => Text;

        public override string ToString()
            => Text;

        [MethodImpl(Inline)]
        public static bool operator ==(asci2 a, asci2 b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(asci2 a, asci2 b)
            => !a.Equals(b);
        
        [MethodImpl(Inline)]
        public static implicit operator ushort(asci2 src)
            => src.Storage;    
    }
}