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
        public abstract class Evaluator<R,T>
            where R : IRule
        {

            public abstract T Evaluate(R src);
        }

        public abstract class RuleTest<R> : Evaluator<R,bool>
            where R : IRule
        {

        }
    }
}