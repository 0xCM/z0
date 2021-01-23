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
        public interface IImplication : ITerm
        {

        }

        public interface IImplication<I,A,C> : IImplication
            where I : unmanaged, IEquatable<I>
            where A : IEquatable<A>
            where C : IEquatable<C>
        {
            I Index {get;}

            A Antecedant {get;}

            C Consequent {get;}

            TermId ITerm.Id
                => memory.u32(Index);
        }

        public interface IImplication<A,C> : IImplication<uint,A,C>
            where A : IEquatable<A>
            where C : IEquatable<C>
        {

        }

    }
}