//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;

    partial class Memories
    {
       [MethodImpl(Inline)]   
        public static void report(Exception e)
            => Console.Error.WriteLine(e);
    }
}