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

    public readonly partial struct CellFuncs
    {
        [MethodImpl(Inline), Op]
        public static CellFuncSig sig(utf8 name, TypeWidth[] args, TypeWidth result)
            => new CellFuncSig(name, args, result);

    }
}