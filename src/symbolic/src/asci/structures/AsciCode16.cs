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

    using N = N16;
    using API = AsciCodes;

    /// <summary>
    /// Defines a 34-bit asci code sequence of length 16
    /// </summary>
    public readonly struct AsciCode16 : IAsciSequence<AsciCode16,N>
    {
        public static AsciCode16 Empty => new AsciCode16(Vector128<byte>.Zero);

        public const int Length = (int)N.Value;

        internal readonly Vector128<byte> Data;        

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

        public AsciCode16 Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        public bool Equals(AsciCode16 src)
            => Data.Equals(src.Data);
 
         public override int GetHashCode()
            => Data.GetHashCode();

        public override bool Equals(object src)
            => src is AsciCode16 j && Equals(j);

        [MethodImpl(Inline)]
        public string Format()
            => API.format(this);
 
        public override string ToString()
            => Format(); 

        [MethodImpl(Inline)]
        public static bool operator ==(AsciCode16 a, AsciCode16 b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(AsciCode16 a, AsciCode16 b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public AsciCode16(Vector128<byte> src)
        {
            Data = src;
        }
    }
}