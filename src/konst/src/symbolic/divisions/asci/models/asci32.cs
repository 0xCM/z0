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
    using static z;

    using N = N32;
    using W = W256;
    using A = asci32;
    using S = System.Runtime.Intrinsics.Vector256<byte>;
            
    /// <summary>
    /// Defines an asci code sequence of length 32
    /// </summary>
    public readonly struct asci32 : IAsciSequence<A,N>
    {     
        internal readonly S Storage;        

        [MethodImpl(Inline)]
        public static implicit operator A(string src)
            => new A(src);

        [MethodImpl(Inline)]
        public static implicit operator string(A src)
            => src.Text;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(A src)
            => src.View;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(A src)
            => src.Decoded;

        [MethodImpl(Inline)]
        public static bool operator ==(A a, A b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(A a, A b)
            => !a.Equals(b); 
        
        public bool IsBlank
        {
            [MethodImpl(Inline)]
            get => IsNull || Equals(Spaced);
        }

        public bool IsNull
        {
            [MethodImpl(Inline)]
            get => Equals(Null);
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
            get => asci.length(this);
        }
        
        public int Capacity
        {
            [MethodImpl(Inline)]
            get => Size;
        }

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => asci.bytes(this);
        }

        public ReadOnlySpan<char> Decoded
        {
            [MethodImpl(Inline)]
            get => asci.decode(this);
        }

        public AsciCharCode this[int index]
        {
            [MethodImpl(Inline)]
            get => (AsciCharCode)Storage.GetElement(index);
        }

        public asci2 this[byte index, N2 size]
        {
            [MethodImpl(Inline)]
            get =>  Storage.As<byte,ushort>().GetElement(index/2);
        }

        public asci4 this[byte index, N4 size]
        {
            [MethodImpl(Inline)]
            get =>  Storage.As<byte,uint>().GetElement(index/4);
        }

        public asci8 this[byte index, N8 size]
        {
            [MethodImpl(Inline)]
            get =>  Storage.As<byte,ulong>().GetElement(index/8);
        }

        public A Zero
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


        public string Text
        {
            [MethodImpl(Inline)]
            get => asci.format(this);
        }


        [MethodImpl(Inline)]
        public bool Equals(A src)
            => Storage.Equals(src.Storage);
 
         public override int GetHashCode()
            => Storage.GetHashCode();

        public override bool Equals(object src)
            => src is A j && Equals(j);

        [MethodImpl(Inline)]
        public string Format()
            => Text;
 
        public override string ToString()
            => Text;


        public const int Size = 32;

        public static A Spaced 
        {
            [MethodImpl(Inline)]
            get => asci.init(n);
        }
        
        public static A Null 
        {
            [MethodImpl(Inline)]
            get => new A(default(S));
        }


        [MethodImpl(Inline)]
        public asci32(Vector256<byte> src)
        {
            Storage = src;
        }

        [MethodImpl(Inline)]
        public asci32(string src)
        {
            Storage = asci.encode(n,src).Storage;
        }

        [MethodImpl(Inline)]
        public asci32(ReadOnlySpan<byte> src)
        {
            Storage = z.vload(w, first(src));
        }

        static N n => default;

        static W w => default;
    }
}