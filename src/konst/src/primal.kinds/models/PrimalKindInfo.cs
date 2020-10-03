//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    public readonly struct PrimalKindInfo : ITextual
    {
        [MethodImpl(Inline)]
        public PrimalKindInfo(PrimalKind kind, TypeWidth width, SignKind sign, PrimalTypeCode tc)
        {
            Kind = kind;
            Width = width;
            Sign = sign;
            TypeCode = tc;
        }

        public PrimalKind Kind {get;}

        public TypeWidth Width {get;}

        public SignKind Sign {get;}

        public PrimalTypeCode TypeCode {get;}

        public string Format()
            => Kind.ToString();
    }
}