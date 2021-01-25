//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct Fork<T>
    {
        public Predicate<T> Test;

        public Action<T> Satisfied;

        public Action<T> Unsatisfied;

        [MethodImpl(Inline)]
        public Fork(Predicate<T> test, Action<T> sat, Action<T> unsat)
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