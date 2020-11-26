//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;
    using static WfScripts;

    partial struct CmdVarTypes
    {
        public struct DirVars : ICmdVars<DirVars>
        {
            readonly Index<DirVar> Data;

            [MethodImpl(Inline)]
            internal DirVars(DirVar[] src)
                => Data = src;

            [MethodImpl(Inline)]
            public Index<ICmdVar> Members()
                => Data.Storage.Cast<ICmdVar>().Array();

            public string Format()
                => CmdVars.format(this);

            public override string ToString()
                => Format();
        }
    }
}