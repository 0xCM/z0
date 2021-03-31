//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiClassifier
    {
        public Name Type {get;}

        public Index<SymLiteral> Literals {get;}

        [MethodImpl(Inline)]
        public ApiClassifier(Name type, Index<SymLiteral> literals)
        {
            Type = type;
            Literals = literals;
        }
    }
}