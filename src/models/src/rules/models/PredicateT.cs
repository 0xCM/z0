//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = Rules;

    partial struct Rules
    {
        public interface IPredicate<T>
        {
            bool Test(T src);
        }

        public abstract class Predicate<T> : IPredicate<T>
            where T : ITerm
        {
            public abstract bool Test(T src);
        }
    }
}