//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;
    using static Shell;

    public readonly struct Shell
    {
        public const PartId ShellId = PartId.Machine;
    }

    class App : AppShell<App,IAppContext>
    {
        public CorrelationToken Ct;

        public App()
            : base(WfBuilder.app())
        {
            Ct = correlate(ShellId);
        }

        public override void RunShell(params string[] args)
        {
            Engine.run(Context, args);
        }

        public static void Main(params string[] args)
            => Launch(args);
    }

    public static partial class XTend {}
}