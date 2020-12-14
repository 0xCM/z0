//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct Branch<T>
    {
        public Predicate<T> Test;

        public Action<T> Satisfied;

        public Action<T> Unsatisfied;

        [MethodImpl(Inline)]
        public Branch(Predicate<T> test, Action<T> sat, Action<T> unsat)
        {
            Test = test;
            Satisfied = sat;
            Unsatisfied = unsat;
        }

        [MethodImpl(Inline)]
        public void Run(T src)
        {
            if(Test(src))
                Satisfied(src);
            else
                Unsatisfied(src);
        }
    }
}