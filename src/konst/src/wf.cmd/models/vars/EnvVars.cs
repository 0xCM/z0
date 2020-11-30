//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    partial struct CmdVarTypes
    {
        public struct EnvVars : ICmdVars<EnvVars>
        {
            public DirVar DevRoot;

            public DirVar Db;

            public DirVar Control;

            [MethodImpl(Inline)]
            public Index<ICmdVar> Members()
                => CmdVars.members(this);

            [MethodImpl(Inline)]
            public string Format()
                => CmdFormat.format(this);

            public override string ToString()
                => Format();
        }
    }
}