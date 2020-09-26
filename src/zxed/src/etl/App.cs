//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;


    using Z0.Xed;

    readonly struct Shell
    {
        public static void Main(params string[] args)
            => XedWf.Go(args);
    }
}