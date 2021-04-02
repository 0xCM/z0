//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct IntrinsicOperator
    {
        public Identifier Name {get;}

        public Name Notation {get;}

        public OperatorKind Kind {get;}

        [MethodImpl(Inline)]
        public IntrinsicOperator(Identifier name, Name notation, OperatorKind kind)
        {
            Name = name;
            Notation  = notation;
            Kind = kind;
        }
    }
}