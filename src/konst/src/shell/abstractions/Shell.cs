//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime;
    using System.IO;

    using static z;

    public abstract class Shell<S> : IShell<S>
        where S : Shell<S>, new()
    {
        protected IMultiSink Sink {get;}

        protected Shell(IShellContext context, IMultiSink sink)
        {
            Sink = sink;
            Context = context;
            ProfileOptimization.SetProfileRoot(Path.GetDirectoryName(typeof(S).Assembly.Location));
            ProfileOptimization.StartProfile("Startup.Profile");
        }

        protected Shell(IShellContext context)
            : this(context, AB.sink())
        {

        }

        protected Shell()
            : this(new ShellContext(sys.empty<string>(), ApiQuery.apiset()))
        {

        }

        public string[] Args {get; private set;}

        public IShellContext Context {get; private set;}

        /// <summary>
        /// The default application path collection
        /// </summary>
        protected static IShellPaths AppPaths
            => Z0.ShellPaths.Default;

        /// <summary>
        /// The shell terminal
        /// </summary>
        protected static ITerminal Term
            => Terminal.Get();

        public void Dispose()
            => OnDispose();

        public virtual void RunShell(params string[] args)
        {

        }

        public virtual void RunShell(IWfShell context)
        {

        }

        protected virtual void OnDispose()
            => term.warn($"Dispose handler not implemented");

        public virtual void OnFatalError(Exception e)
        {
            term.red("Shell was fatally wounded");
            term.error(e);
        }

        protected static S Init(params string[] args)
        {
            var shell = new S();
            shell.Args = args;
            return shell;
        }

        protected static S Init(IShellContext context, params string[] args)
        {
            var shell = new S();
            shell.Args = args;
            shell.Context = context;
            return shell;
        }

        protected static int Launch(IWfShell context)
        {
            try
            {
                var shell = new S();
                shell.Args = context.Args;
                shell.Context = context;
                shell.RunShell(context);

                return 0;
            }
            catch(Exception e)
            {
                term.error(e);
                return -1;
            }
        }

        protected static void Launch(params string[] args)
        {
            var created = false;
            try
            {
                using var shell = new S();
                shell.Args = args;
                (shell as IShell).Execute(args);
            }
            catch(Exception e)
            {
                if(created)
                    term.errlabel(e, $"Shell became angry upon disposal!");
                else
                    term.errlabel(e, $"Shell became angry upon creation!");
            }
        }
    }

    /// <summary>
    /// Base class for shells with pararametric context
    /// </summary>
    /// <typeparam name="S">The shell reification type</typeparam>
    /// <typeparam name="C">The shell context type</typeparam>
    public abstract class Shell<S,C> : Shell<S>
        where S : Shell<S,C>, new()
        where C : IShellContext
    {
        public new C Context {get;}

        protected Shell(C context)
            : base(context)
        {
            Context = context;
        }

        protected Shell(C context, IMultiSink sink)
            : base(context, sink)
        {
            Context = context;
        }
    }
}