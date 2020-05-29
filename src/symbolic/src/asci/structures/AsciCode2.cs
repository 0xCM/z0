//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using N = N2;
    using API = AsciCodes;

    /// <summary>
    /// Defines an asci code sequence of length 2
    /// </summary>
    public readonly struct AsciCode2 : IAsciSequence<AsciCode2,N>
    {
        public static AsciCode2 Empty => new AsciCode2(0);

        public const int Length = (int)N.Value;        

        internal readonly ushort Data;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Empty.Equals(this);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !Empty.Equals(this);
        }

        public AsciCode2 Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }
        
        [MethodImpl(Inline)]
        public bool Equals(AsciCode2 src)
            => Data == src.Data;

        public override bool Equals(object src)
            => src is AsciCode2 x && Equals(x);

        public override int GetHashCode()
            => Data.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => API.format(this);

        public override string ToString()
            => Format(); 

        [MethodImpl(Inline)]
        public static bool operator ==(AsciCode2 a, AsciCode2 b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(AsciCode2 a, AsciCode2 b)
            => !a.Equals(b);
        
        [MethodImpl(Inline)]
        public static implicit operator ushort(AsciCode2 src)
            => src.Data;
        
        [MethodImpl(Inline)]
        public AsciCode2(ushort src)
        {
            Data = src;
        }
    }
}