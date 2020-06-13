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
    using static Typed;

    using N = N16;
    using W = W128;

    /// <summary>
    /// Defines an asci code sequence of length 16
    /// </summary>
    public readonly struct asci16 : IAsciSequence<asci16,N>
    {
        internal readonly Vector128<byte> Storage;        

        public const int Size = 16;
        
        public static asci16 Blank => asci.init(n);
        
        public static asci16 Null => new asci16(Vector128<byte>.Zero);

        static N n => default;

        static W w => default;
        

        [MethodImpl(Inline)]
        public static asci16 Init(AsciCharCode fill = AsciCharCode.Space)
            => new asci16(SymBits.vbroadcast(w, (byte)fill));

        [MethodImpl(Inline)]
        public static asci16 From(ReadOnlySpan<AsciCharCode> src)
            => new asci16(Control.cast<AsciCharCode,byte>(src));

        [MethodImpl(Inline)]
        public static implicit operator asci16(string src)
            => new asci16(src);

        [MethodImpl(Inline)]
        public static implicit operator string(asci16 src)
            => src.Text;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(asci16 src)
            => src.Encoded;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(asci16 src)
            => src.Decoded;

        [MethodImpl(Inline)]
        public asci16(ReadOnlySpan<byte> src)
        {
            Storage = SymBits.vload(w, Control.head(src));
        }

        [MethodImpl(Inline)]
        public asci16(Vector128<byte> src)
        {
            Storage = src;
        }

        [MethodImpl(Inline)]
        public asci16(string src)
        {
            Storage = asci.encode(n16,src).Storage;
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

        public asci16 Zero
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
            get => asci.decode(this);
        } 
        
        public string Text
        {
            [MethodImpl(Inline)]
            get => asci.format(this);
        }

        [MethodImpl(Inline)]
        public bool Equals(asci16 src)
            => Storage.Equals(src.Storage);
 
        [MethodImpl(Inline)]
        public void CopyTo(Span<byte> dst)
            => Symbolic.copy(this,dst);

        [MethodImpl(Inline)]
        public void CopyTo(ref byte dst)
            => Symbolic.copy(this, ref dst);

         public override int GetHashCode()
            => Storage.GetHashCode();

        public override bool Equals(object src)
            => src is asci16 j && Equals(j);

        [MethodImpl(Inline)]
        public string Format()
            => Text;
 
        public override string ToString()
            => Text;

        [MethodImpl(Inline)]
        public static bool operator ==(asci16 a, asci16 b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(asci16 a, asci16 b)
            => !a.Equals(b);
    }
}