//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct WfCmdBuilder
    {
        readonly IWfShell _Wf;

        readonly IWfDb _Db;

        [MethodImpl(Inline)]
        public WfCmdBuilder(IWfShell wf)
        {
            _Wf = wf;
            _Db = wf.Db();
        }

        public IWfShell Wf
        {
            [MethodImpl(Inline)]
            get => _Wf;
        }

        public IWfDb Db
        {
            [MethodImpl(Inline)]
            get => _Db;
        }

        public Env Env => Wf.Env;
    }
}