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
            : this(context, Flow.sink())
        {

        }

        protected Shell()
            : this(Flow.context())
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
}