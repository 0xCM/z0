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

    using N = N5;    

    using static AC5;    

    /// <summary>
    /// Defines an asci code sequence of length 5
    /// </summary>
    public readonly struct AsciCode5 : IAsciSequence<AsciCode5,N>
    {
        internal readonly ulong Data;

        [MethodImpl(Inline)]
        public AsciCode5(ulong src)
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

        public AsciCode5 Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        public bool Equals(AsciCode5 src)
            => Data == src.Data;

        public override bool Equals(object src)
            => src is AsciCode5 j && Equals(j);

        public override int GetHashCode()
            => Data.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => format(this);
 
        public override string ToString()
            => Format(); 

        [MethodImpl(Inline)]
        public static bool operator ==(AsciCode5 a, AsciCode5 b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(AsciCode5 a, AsciCode5 b)
            => !a.Equals(b);
    }
}