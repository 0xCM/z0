//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    public abstract class Shell<S> : IShell<S>
        where S : Shell<S>, new()
    {
        /// <summary>
        /// The default application path collection
        /// </summary>
        protected static TAppPaths AppPaths 
            => Z0.AppPaths.Default;

        /// <summary>
        /// The shell terminal
        /// </summary>
        protected static ITerminal Term 
            => Terminal.Get();

        public void Dispose()
            => OnDispose();

        public abstract void RunShell(params string[] args);

        protected virtual void OnDispose() 
            => term.warn($"Dispose handler not implemented");

        public virtual void OnFatalError(Exception e)
        {
            term.red("Shell was fatally wounded");
            term.error(e);
        }

        /// <summary>
        /// The parts that are not unknown
        /// </summary>
        protected static PartIndex KnownParts 
            => LazyParts.Value;

        static Lazy<PartIndex> LazyParts {get;} 
            = Root.defer(Parted.index);        

        protected static void Launch(params string[] args)
        {
            var created = false;
            try
            {
                term.inform($"Creating shell");
                using var shell = new S() as IShell;                            

                created = true;

                term.inform($"Executing shell");
                shell.Execute(args);
            }
            catch(Exception e)
            {
                if(created)
                    term.errlabel(e, $"Shell abended upon disposal!");
                else
                    term.errlabel(e, $"Shell abended upon creation!");
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
            => Context = context;

    }
}