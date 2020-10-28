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

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static CmdBuilder CmdBuilder(this IWfShell wf)
            => new CmdBuilder(wf);

    }

    public readonly struct CmdBuilder
    {
        readonly IWfShell _Wf;

        readonly IFileDb _Db;

        [MethodImpl(Inline)]
        internal CmdBuilder(IWfShell wf)
        {
            _Wf = wf;
            _Db = wf.Db();
        }

        public IWfShell Wf
        {
            [MethodImpl(Inline)]
            get => _Wf;
        }

        public IFileDb Db
        {
            [MethodImpl(Inline)]
            get => _Db;
        }


    }
}