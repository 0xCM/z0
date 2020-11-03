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

    partial struct Cmd
    {
        [MethodImpl(Inline)]
        public static CmdWorker<C> worker<C>(CmdWorkerFunction<C> fx)
            where C : struct, ICmdSpec<C>
                => new CmdWorker<C>(fx);

        [MethodImpl(Inline), Op]
        public static CmdWorker worker(CmdWorkerFunction fx)
            => new CmdWorker(fx);
    }
}