//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Charaterizes a component that maintains readnly-access to encapsulated state, here and throughout
    /// referred to as a context
    /// </summary>
    public interface IContextual<C>
        where C : IContext
    {
        C Context {get;}
    }    
}