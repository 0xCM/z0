//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes console-controlled, perhaps user-initiated, thread of execution
    /// </summary>
    public interface IShell : IExecutable, IDisposable
    {
        PartId AppId {get;}

        IShellContext Context {get;}

        void OnFatalError(Exception e);

        void RunShell(params string[] args);

        void IExeModule<string>.Execute(params string[] args)
        {
            try
            {
               RunShell(args);
            }
            catch (Exception e)
            {
                OnFatalError(e);
            }
        }
    }

    /// <summary>
    /// Characterizes a reified shell
    /// </summary>
    public interface IShell<S> : IShell
        where S : IShell<S>, new()
    {
        PartId IShell.AppId
            => typeof(S).Assembly.Id();
    }

    public interface IShell<S,C> : IShell<S>
        where S : IShell<S,C>, new()
    {
        new IShellContext<C> Context {get;}

        IShellContext IShell.Context
            => Context;
    }
}