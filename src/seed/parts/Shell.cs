//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    
    
    public abstract class Shell<S> :  IShell<S>
        where S : Shell<S>, new()
    {
        public abstract void RunShell(params string[] args);

        protected virtual void OnDispose() { }

        public void Dispose()
            => OnDispose();

        public virtual void OnFatalError(Exception e)
            => Console.Error.WriteLine(e);   

        static void Execute(IShell shell, params string[] args)
            => shell.Execute(args);        

        protected static void Launch(params string[] args)
        {
            try
            {
                using var shell = new S();            
                Execute(shell, args);
            }
            catch(Exception e)
            {
                Console.Error.WriteLine("Unable to launch host");
                Console.Error.WriteLine(e);
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