//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static Shell;

    public readonly struct Shell
    {
        public const PartId ShellId = PartId.Monitor;

        public const string ShellName = "monitor";
    }

    sealed class AppShell : Shell<AppShell>
    {
        void OnChange(FS.Entry subject, FS.ChangeKind kind)
        {
            term.print(subject);
        }

        public override void RunShell(params string[] args)
        {
            var path = args.Length != 0 ? FolderPath.Define(args[0]) : FolderPath.Define(AppPaths.LogRoot.Name);
            using var monitor = Monitors.monitor(FS.dir(path.Name),OnChange);
            //term.print(WfEventBuilder.watching(ShellName, path, correlate(ShellId)));
            monitor.Start();
            Console.ReadKey();
        }

        public static void Main(params string[] args)
            => AppShell.Launch(args);

        protected override void OnDispose()
        {

        }
    }
}