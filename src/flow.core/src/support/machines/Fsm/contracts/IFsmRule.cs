//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface IFsmRule
    {
        int RuleId {get;}   
    }

    /// <summary>
    ///  Characterizes a state machine rule predicated on an input event and source state
    /// </summary>
    /// <typeparam name="E">The input event type</typeparam>
    /// <typeparam name="S">The source state</typeparam>
    public interface IFsmRule<E,S> : IFsmEventRule<E>, IFsmStateRule<S>
    {
        /// <summary>
        /// The rule key for hash-based lookups
        /// </summary>
        IRuleKey<E,S> Key {get;}
    }
}