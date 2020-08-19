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
        public override void RunShell(params string[] args)
        {
            term.print("Not yet");
        }

        public static void Main(params string[] args)
            => AppShell.Launch(args);

        protected override void OnDispose()
        {

        }
    }
}