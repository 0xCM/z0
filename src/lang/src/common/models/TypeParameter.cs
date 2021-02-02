//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct TypeParameter
    {
        public Name Name {get;}

        [MethodImpl(Inline)]
        public TypeParameter(string name)
        {
            Name = name;
        }
    }
}