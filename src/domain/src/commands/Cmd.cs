//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.Cmd)]
    public readonly struct Cmd
    {
        [Op]
        public static int execute(IWfShell wf, CmdId id, params CmdOption[] options)
        {
            return 0;
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static CmdHost<T> host<T>(T t = default)
            where T : struct
                => CmdHost<T>.create();
    }
}