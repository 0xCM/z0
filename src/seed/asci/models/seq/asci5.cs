//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    using N = N5;    

    /// <summary>
    /// Defines an asci code sequence of length 5
    /// </summary>
    public readonly struct asci5 : IAsciSequence<asci5,N>
    {
        public static asci5 Blank => new asci5(0x2020202020);

        public static asci5 Null => new asci5(0);        

        public const int Size = 5;

        internal readonly ulong Data;

        [MethodImpl(Inline)]
        public asci5(ulong src)
        {
            Data = src;
        }
        
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Data != 0;
        }

        public asci5 Zero
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

        public string Text
        {
            [MethodImpl(Inline)]
            get => asci.format(this);
        }
        
        [MethodImpl(Inline)]
        public static implicit operator string(asci5 src)
            => src.Text;

        [MethodImpl(Inline)]
        public bool Equals(asci5 src)
            => Data == src.Data;

        public override bool Equals(object src)
            => src is asci5 j && Equals(j);

        public override int GetHashCode()
            => Data.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => Text;
 
        public override string ToString()
            => Text;

        [MethodImpl(Inline)]
        public static bool operator ==(asci5 a, asci5 b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(asci5 a, asci5 b)
            => !a.Equals(b);
    }
}