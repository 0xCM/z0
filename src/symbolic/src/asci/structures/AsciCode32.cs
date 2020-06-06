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
        public static AsciCode32 Blank => init(AsciCharCode.Space);

        public static AsciCode32 Null => new AsciCode32(Vector256<byte>.Zero);
        
        [MethodImpl(Inline)]
        public static AsciCode32 init(AsciCharCode fill = AsciCharCode.Space)
            => new AsciCode32(SymBits.vbroadcast(w256, (byte)fill));

        internal readonly Vector256<byte> Data;        

        [MethodImpl(Inline)]
        public AsciCode32(Vector256<byte> src)
        {
            Data = src;
        }
        
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.Equals(default);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !Data.Equals(default);
        }

        public AsciCode32 Zero
        {
            [MethodImpl(Inline)]
            get => Null;
        }

        [MethodImpl(Inline)]
        public bool Equals(AsciCode32 src)
            => Data.Equals(src.Data);
 
         public override int GetHashCode()
            => Data.GetHashCode();

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