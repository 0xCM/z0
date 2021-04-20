//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Rules
    {
        public readonly struct Multiplicity
        {
            public MultiplicityKind Kind {get;}

            [MethodImpl(Inline)]
            public Multiplicity(MultiplicityKind kind)
            {
                Kind = kind;
            }

            [MethodImpl(Inline)]
            public static implicit operator Multiplicity(MultiplicityKind kind)
                => new Multiplicity(kind);
        }
    }
}