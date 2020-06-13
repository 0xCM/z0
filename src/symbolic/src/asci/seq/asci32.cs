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

    using N = N32;
    using W = W256;
    
    /// <summary>
    /// Defines an asci code sequence of length 32
    /// </summary>
    public readonly struct asci32 : IAsciSequence<asci32,N>
    {
        public static asci32 Blank => asci.init(n);

        public static asci32 Null => new asci32(Vector256<byte>.Zero);

        public const int Size = 32;

        static N n => default;

        static W w => default;

        [MethodImpl(Inline)]
        public static asci32 From(ReadOnlySpan<AsciCharCode> src)
            => new asci32(Control.cast<AsciCharCode,byte>(src));

        internal readonly Vector256<byte> Storage;        

        [MethodImpl(Inline)]
        public static implicit operator asci32(string src)
            => new asci32(src);

        [MethodImpl(Inline)]
        public static implicit operator string(asci32 src)
            => src.Text;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(asci32 src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(asci32 src)
            => src.Decoded;


        [MethodImpl(Inline)]
        public asci32(Vector256<byte> src)
        {
            Storage = src;
        }
        
        [MethodImpl(Inline)]
        public asci32(ReadOnlySpan<byte> src)
        {
            Storage = SymBits.vload(w, Control.head(src));
        }

        [MethodImpl(Inline)]
        public asci32(string src)
        {
            Storage = asci.encode(n,src).Storage;
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

        public asci32 Zero
        {
            [MethodImpl(Inline)]
            get => Null;
        }

        public asci16 Lo
        {
            [MethodImpl(Inline)]
            get => new asci16(Storage.GetLower());
        }

        public asci16 Hi
        {
            [MethodImpl(Inline)]
            get => new asci16(Storage.GetUpper());
        }

        public ReadOnlySpan<byte> Encoded
        {
            [MethodImpl(Inline)]
            get => Symbolic.bytes(this);
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
        public bool Equals(asci32 src)
            => Storage.Equals(src.Storage);
 
         public override int GetHashCode()
            => Storage.GetHashCode();

        public override bool Equals(object src)
            => src is asci32 j && Equals(j);

        [MethodImpl(Inline)]
        public string Format()
            => Text;
 
        public override string ToString()
            => Text;

        [MethodImpl(Inline)]
        public static bool operator ==(asci32 a, asci32 b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(asci32 a, asci32 b)
            => !a.Equals(b); 
    }
}