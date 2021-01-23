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
        public interface IAntecedant : ITerm
        {

        }

        public interface IAntecedant<A> : IAntecedant, ITerm<A>
            where A : IEquatable<A>
        {
            Index<A> Terms {get;}
        }
    }
}