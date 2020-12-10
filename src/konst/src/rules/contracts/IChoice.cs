//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Characterizes an item selection
    /// </summary>
    /// <typeparam name="T">The item type</typeparam>
    public interface IChoice<T> : IRule<T>
    {
        T Chosen {get;}
    }

    public interface IChoice<H,T> : IChoice<T>
        where H : IChoice<H,T>
    {
        RuleId IRule<T>.RuleId
            => new RuleId<H>();
    }
}