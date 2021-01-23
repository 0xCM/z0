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
        public interface IConsequent : ITerm
        {
            dynamic Term {get;}
        }

        public interface IConsequent<C> : IConsequent, ITerm<C>
            where C : IEquatable<C>
        {
            new C Term {get;}

            dynamic IConsequent.Term
                => Term;
        }
    }
}