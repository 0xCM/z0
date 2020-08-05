//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a worklow context
    /// </summary>
    public interface IWfContext : IDisposable
    {
        IAppContext ContextRoot {get;}

        WfEventId Raise<E>(in E e)
            where E : IWfEvent;        
    }

    /// <summary>
    /// Characterizes a workflow context that carries parametric cata
    /// </summary>
    /// <typeparam name="T">The data type</typeparam>
    public interface IWfContext<T> : IWfContext
    {
        T State {get;}
    }    
}