//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct ClrPrimitiveInfo : ITextual
    {
        public PrimalKind Kind;

        public TypeWidth Width;

        public SignKind Sign;

        public PrimalTypeCode TypeCode;

        [MethodImpl(Inline)]
        public ClrPrimitiveInfo(PrimalKind kind, TypeWidth width, SignKind sign, PrimalTypeCode tc)
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