//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Seed;    
    
    public abstract class Shell<S> : IShell<S>
        where S : Shell<S>, new()
    {
        /// <summary>
        /// The default application path collection
        /// </summary>
        protected static IAppPaths AppPaths => AppPathProvider.FromApp<S>();

        /// <summary>
        /// The shell terminal
        /// </summary>
        protected static ITerminal Term => Terminal.Get();

        public void Dispose()
            => OnDispose();

        public abstract void RunShell(params string[] args);

        protected virtual void OnDispose() 
            => Term.Warn($"Dispose handler not implemented");

        public virtual void OnFatalError(Exception e)
            => Term.Error(e);

        /// <summary>
        /// The parts that are not unknown
        /// </summary>
        protected static PartIndex KnownParts => LazyParts.Value; //Part.Index;//Part.KnownParts;

        static Lazy<PartIndex> LazyParts {get;} 
            = new Lazy<PartIndex>(PartIndex.Build);        

        protected static void Launch(params string[] args)
        {
            try
            {
                Term.Info($"Launching shell");
                using var shell = new S() as IShell;            
                shell.Execute(args);
                //Execute(shell, args);
            }
            catch(Exception e)
            {
                Term.Error("Unable to launch host");
                Term.Error(e);
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