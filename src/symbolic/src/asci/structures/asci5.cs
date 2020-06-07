//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Typed;

    using N = N5;    

    /// <summary>
    /// Defines an asci code sequence of length 5
    /// </summary>
    public readonly struct asci5 : IAsciSequence<asci5,N>
    {
        public static asci5 Empty => new asci5(0);        

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
            get => Empty;
        }


        public int MaxLength
        {
            [MethodImpl(Inline)]
            get => Size;
        }

        [MethodImpl(Inline)]
        public bool Equals(asci5 src)
            => Data == src.Data;

        public override bool Equals(object src)
            => src is asci5 j && Equals(j);

        public override int GetHashCode()
            => Data.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => AsciCodes.format(this);
 
        public override string ToString()
            => Format(); 

        [MethodImpl(Inline)]
        public static bool operator ==(asci5 a, asci5 b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(asci5 a, asci5 b)
            => !a.Equals(b);
    }
}