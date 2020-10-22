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

    sealed class AppShell : Shell<AppShell>
    {

        public static void Main(params string[] args)
            => AppShell.Launch(args);

        protected override void OnDispose()
        {

        }
    }
}