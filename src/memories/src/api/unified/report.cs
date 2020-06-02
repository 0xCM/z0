//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Memories
    {
        [Op, MethodImpl(NotInline)]   
        public static void report(Exception e)
            => Console.Error.WriteLine(e);
    }
}