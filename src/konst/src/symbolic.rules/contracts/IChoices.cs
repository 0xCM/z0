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
    /// Characterizes a sequence of potential choices
    /// </summary>
    /// <typeparam name="T">The item type</typeparam>
    public interface IChoices<T> : IIndex<T>,  IRule<Index<T>>
    {
        T[] IIndex<T>.Storage
            => Items.Storage;

        Index<T> Items {get;}
    }

    public interface IChoices<H,T> : IChoices<T>
        where H : IChoices<H,T>
    {
        RuleId IRule<Index<T>>.RuleId => new RuleId<H>();
    }
}