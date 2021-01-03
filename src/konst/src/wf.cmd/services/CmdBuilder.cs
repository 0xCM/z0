//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CmdBuilder
    {
        readonly IWfShell _Wf;

        readonly IWfDb _Db;

        readonly Env _Env;

        [MethodImpl(Inline)]
        public CmdBuilder(IWfShell wf)
        {
            _Wf = wf;
            _Db = wf.Db();
            _Env = Env.create();
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

        public Env Env
        {
            [MethodImpl(Inline)]
            get => _Env;
        }

        // public Env Env
        // {
        //     get =>
        // }
    }
}