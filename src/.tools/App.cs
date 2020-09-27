//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static z;

    struct App
    {
        public static int Main(params string[] args)
        {
            using var wf = Flow.shell(args);

            return 0;
        }
    }
}