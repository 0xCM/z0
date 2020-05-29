//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 4040
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using N = N8;
    using API = AsciCodes;

    /// <summary>
    /// Defines a 34-bit asci code sequence of length 8
    /// </summary>
    public readonly struct AsciCode8 : IAsciSequence<AsciCode8,N>
    {
        public static AsciCode8 Empty => new AsciCode8(0);

        public const int Length = (int)N.Value;
        
        internal readonly ulong Data;

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

        public AsciCode8 Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        public bool Equals(AsciCode8 src)
            => Data == src.Data;

        public override bool Equals(object src)
            => src is AsciCode8 x && Equals(x);

        public override int GetHashCode()
            => Data.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => API.format(this);
 
        public override string ToString()
            => Format(); 

        [MethodImpl(Inline)]
        public static bool operator ==(AsciCode8 a, AsciCode8 b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(AsciCode8 a, AsciCode8 b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public AsciCode8(ulong src)
        {
            Data = src;
        }
    }
}