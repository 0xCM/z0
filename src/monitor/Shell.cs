//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    
    sealed class AppShell : Shell<AppShell>
    {
        void OnChange(FileSystemObject subject, FileSystemChangeKind kind)
        {
            term.print(subject);
        }
        
        public override void RunShell(params string[] args)
        {
            var path = args.Length != 0 ? FolderPath.Define(args[0]) : FolderPath.Define(AppPaths.LogRoot.Name);            
            using var monitor = Monitors.monitor(path,OnChange);
            term.print(text.format("",""));
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