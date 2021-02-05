//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct ApiSigs
    {
        public readonly struct OperandSig
        {
            public Name Name {get;}

            public TypeSig Type {get;}

            public SigModifier Modifier {get;}

            [MethodImpl(Inline)]
            public OperandSig(Name name, TypeSig type, SigModifier modifier)
            {
                Name = name;
                Type = type;
                Modifier = modifier;
            }
        }
    }
}