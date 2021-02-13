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
        public ClrPrimalKind Kind {get;}

        public TypeWidth Width {get;}

        public SignKind Sign {get;}

        public PrimalCode TypeCode {get;}

        [MethodImpl(Inline)]
        public ClrPrimitiveInfo(ClrPrimalKind kind, TypeWidth width, SignKind sign, PrimalCode tc)
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