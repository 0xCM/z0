//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct ClrPrimitiveInfo : ITextual
    {
        public ClrPrimalKind Kind {get;}

        public TypeWidth Width {get;}

        public PolarityKind Sign {get;}

        public PrimalCode TypeCode {get;}

        [MethodImpl(Inline)]
        public ClrPrimitiveInfo(ClrPrimalKind kind, TypeWidth width, PolarityKind sign, PrimalCode tc)
        {
            Kind = kind;
            Width = width;
            Sign = sign;
            TypeCode = tc;
        }

        public string Format()
            => Kind.ToString();

        public override string ToString()
            => Format();
    }
}