//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;
    
    public interface Shelled : IShell
    {
        void RunShell(params string[] args);

        void OnFatalError(Exception e)
            => Console.Error.WriteLine(e);   

        void IExecutable.Execute(params string[] args)
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

    public interface Shelled<S> : Shelled
        where S : Shelled<S>, new()
    {
    }

    /// <summary>
    /// Base class for shells with pararametric context
    /// </summary>
    /// <typeparam name="S">The shell refication type</typeparam>
    /// <typeparam name="C">The shell context type</typeparam>
    public abstract class Shell<S,C> : Shelled<S>, IShell<S,C>
        where S : Shell<S,C>, new()
        where C : IContext
    {
        public C Context {get;}
    
        protected Shell(C context)
        {
            Context = context;
        }

        Shelled Me => this;

        public virtual void OnFatalError(Exception e)
            => Console.Error.WriteLine(e);   

        public abstract void RunShell(params string[] args);

        protected static void Launch(params string[] args)
            => new S().Me.Execute(args);
    }

    /// <summary>
    /// Base class for shells with default, stateless context
    /// </summary>
    /// <typeparam name="A">The shell reification type</typeparam>
    public abstract class Shell<S> : Shelled<S>
        where S : Shell<S>, new()
    {
        public abstract void RunShell(params string[] args);

        public virtual void OnFatalError(Exception e)
            => Console.Error.WriteLine(e);   

        Shelled Me => this;

        protected static void Launch(params string[] args)
            => new S().Me.Execute(args);
    }         
}