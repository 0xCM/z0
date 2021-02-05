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
        public readonly struct TypeSig
        {
            public Name TypeName {get;}

            public Index<TypeParameter> Parameters {get;}

            [MethodImpl(Inline)]
            public TypeSig(Name name, Index<TypeParameter> parameters)
            {
                TypeName = name;
                Parameters = parameters;
            }

        }
    }
}