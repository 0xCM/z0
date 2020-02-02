//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly struct AsmEmissionToken : IEquatable<AsmEmissionToken>, IComparable<AsmEmissionToken>
    {
        public readonly OpUri Uri;

        public readonly MemoryRange Origin;

        [MethodImpl(Inline)]
        public static bool operator==(AsmEmissionToken a, AsmEmissionToken b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(AsmEmissionToken a, AsmEmissionToken b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static AsmEmissionToken Define(OpUri uri, MemoryRange origin)        
            => new AsmEmissionToken(uri, origin);

        [MethodImpl(Inline)]
        AsmEmissionToken(OpUri uri, MemoryRange origin)
        {
            this.Uri = uri;
            this.Origin = origin;
        }

        public string Format()
            => concat(Uri.ToString(), Origin.Format());

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => HashCode.Combine(Uri,Origin);

        [MethodImpl(Inline)]
        public bool Equals(AsmEmissionToken src)
            => Uri == src.Uri && Origin == src.Origin;
        
        public override bool Equals(object src)
            => src is AsmEmissionToken d && Equals(d);

        [MethodImpl(Inline)]
        public int CompareTo(AsmEmissionToken rhs)
            => Origin.CompareTo(rhs.Origin);
    }

}