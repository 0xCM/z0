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
    using static AC16;

    using N = N16;

    /// <summary>
    /// Defines an asci code sequence of length 16
    /// </summary>
    public readonly struct AsciCode16 : IAsciSequence<AsciCode16,N>
    {
        internal readonly Vector128<byte> Data;        

        [MethodImpl(Inline)]
        public AsciCode16(Vector128<byte> src)
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

        public AsciCode16 Zero
        {
            [MethodImpl(Inline)]
            get => AC16.Null;
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
            => format(this);
 
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