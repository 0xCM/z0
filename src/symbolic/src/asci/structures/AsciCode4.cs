//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Control;
    using static AC4;

    using N = N4;    

    /// <summary>
    /// Defines an asci code sequence of length 4
    /// </summary>
    public readonly struct AsciCode4 : IAsciSequence<AsciCode4,N>
    {        
        internal readonly uint Data;

        [MethodImpl(Inline)]
        public AsciCode4(uint src)
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

        public AsciCode4 Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        public bool Equals(AsciCode4 src)
            => Data == src.Data;

        public override bool Equals(object src)
            => src is AsciCode4 j && Equals(j);

        public override int GetHashCode()
            => Data.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => format(this);
 
        public override string ToString()
            => Format(); 

        [MethodImpl(Inline)]
        public static bool operator ==(AsciCode4 a, AsciCode4 b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(AsciCode4 a, AsciCode4 b)
            => !a.Equals(b);
    }
}