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

    partial struct WfScripts
    {
        [MethodImpl(Inline), Op]
        public static CmdVarSymbol combine(CmdVarSymbol a, CmdVarSymbol b)
            => new CmdVarSymbol(string.Format("{0}{1}", a, b));

        [MethodImpl(Inline), Op]
        public static CmdVarSymbol combine<T>(CmdVarSymbol<T> a, CmdVarSymbol<T> b)
            => new CmdVarSymbol(string.Format("{0}{1}", a,b));
    }
}