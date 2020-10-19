//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Part;

    public readonly struct PrimalKindInfo : ITextual
    {
        public PrimalKind Kind {get;}

        public TypeWidth Width {get;}

        public SignKind Sign {get;}

        public PrimalTypeCode TypeCode {get;}

        [MethodImpl(Inline)]
        public PrimalKindInfo(PrimalKind kind, TypeWidth width, SignKind sign, PrimalTypeCode tc)
        {
            Kind = kind;
            Width = width;
            Sign = sign;
            TypeCode = tc;
        }

        public string Format()
            => Kind.ToString();
    }
}