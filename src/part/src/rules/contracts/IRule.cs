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
        public interface IRule : ITerm
        {

        }

        public interface IRule<P> : IRule
            where P : IProposition, IEquatable<P>
        {
            Index<P> Terms {get;}
        }
    }
}