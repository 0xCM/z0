//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    using static Root;

    public readonly struct ApiSig
    {
        public static ApiSig Empty => default;

        public ApiSig(ApiSigCell[] parts)
        {
            this.Nodes = parts;
        }
        public Arrow<ApiSigCell> Nodes {get;}
    }

    public readonly struct ApiSigCell : IEquatable<ApiSigCell>
    {
        public readonly NumericClass Numeric;

        [MethodImpl(Inline)]
        public bool Equals(ApiSigCell other)
        {
            return Numeric == other.Numeric;
        }
    }

}
