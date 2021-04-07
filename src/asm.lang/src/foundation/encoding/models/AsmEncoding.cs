//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct AsmEncoding : IEquatable<AsmEncoding>, IComparable<AsmEncoding>
    {
        public AsmExpr Asm {get;}

        public AsmHexCode Encoding {get;}

        [MethodImpl(Inline)]
        public AsmEncoding(AsmExpr asm, AsmHexCode code)
        {
            Asm = asm;
            Encoding = code;
        }

        public bool Equals(AsmEncoding src)
            => Asm.Equals(src.Asm) && Encoding.Equals(src.Encoding);

        public int CompareTo(AsmEncoding src)
            => Encoding.CompareTo(src.Encoding);

        public override bool Equals(object src)
            => src is AsmEncoding x && Equals(x);


        public override int GetHashCode()
            => (int)alg.hash.combine(Asm.GetHashCode(), Encoding.GetHashCode());
    }
}