//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    
    
    public abstract class Shell<S> : IShell<S>
        where S : Shell<S>, new()
    {
        /// <summary>
        /// The default application path collection
        /// </summary>
        protected static IAppPaths AppPaths => Z0.AppPaths.Default;

        /// <summary>
        /// The shell terminal
        /// </summary>
        protected static ITerminal Term => Terminal.Get();

        public void Dispose()
            => OnDispose();

        public abstract void RunShell(params string[] args);

        protected virtual void OnDispose() 
            => term.warn($"Dispose handler not implemented");

        public virtual void OnFatalError(Exception e)
            => term.error(e);

        /// <summary>
        /// The parts that are not unknown
        /// </summary>
        protected static PartIndex KnownParts => LazyParts.Value;

        static Lazy<PartIndex> LazyParts {get;} 
            = Control.defer(PartIndex.Build);        

        protected static void Launch(params string[] args)
        {
            try
            {
                term.inform($"Launching shell");
                using var shell = new S() as IShell;            
                shell.Execute(args);
            }
            catch(Exception e)
            {
                term.error("Unable to launch host");
                term.error(e);
            }
        }
    }    

    /// <summary>
    /// Base class for shells with pararametric context
    /// </summary>
    /// <typeparam name="S">The shell refication type</typeparam>
    /// <typeparam name="C">The shell context type</typeparam>
    public abstract class Shell<S,C> : Shell<S>, IShell<S,C>
        where S : Shell<S,C>, new()
        where C : IContext
    {
        public C Context {get;}
    
        protected Shell(C context)
        {
            Context = context;
        }    
    }
}