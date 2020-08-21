//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;

    public abstract class Shell<S> : IShell<S>
        where S : Shell<S>, new()
    {
        protected IMultiSink Sink {get;}

        protected Shell(IMultiSink sink)
        {
            Sink = sink;
        }

        protected Shell()
        {
            Sink = WfSinks.term();
        }

        /// <summary>
        /// The default application path collection
        /// </summary>
        protected static IAppPaths AppPaths
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
            = z.defer(Parted.executing);

        protected static void Launch(params string[] args)
        {
            var created = false;
            try
            {
                using var shell = new S() as IShell;
                created = true;
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
    /// <typeparam name="S">The shell reification type</typeparam>
    /// <typeparam name="C">The shell context type</typeparam>
    public abstract class Shell<S,C> : Shell<S>, IShell<S,C>
        where S : Shell<S,C>, new()
        where C : IContext
    {
        public C Context {get;}

        protected Shell(C context)
            : base()
        {
            Context = context;
        }

        protected Shell(C context, IMultiSink sink)
            : base(sink)
        {
            Context = context;
        }
    }
}