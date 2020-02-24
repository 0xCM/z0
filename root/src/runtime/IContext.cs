//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    /// <summary>
    /// A context of everything and yet to everyting nothing
    /// </summary>
    public interface IContext
    {
        
    }

    /// <summary>
    /// A context with parameteric state
    /// </summary>
    public interface IContext<S> : IContext
    {
        /// <summary>
        /// State shared with members of the context
        /// </summary>
        S State {get;}
    }


    /// <summary>
    /// Charaterizes a type that supports execution within a context
    /// </summary>
    public interface IContextual
    {
        IContext Context {get;}
    }

    public interface IContextual<C> : IContextual
        where C : IContext
    {
        new C Context {get;}

        IContext IContextual.Context
            => Context;
    }    

    public interface IContextual<C,S> : IContextual<C>
        where C : IContext<S>
    {

    }
}