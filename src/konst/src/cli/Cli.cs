//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Reflection.Emit;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct Cli
    {
        [MethodImpl(Inline)]
        public static CliDependency<S,T> dependency<S,T>(S src, T dst)
            where S : struct
            where T : struct
                => new CliDependency<S,T>(src,dst);
    }
}