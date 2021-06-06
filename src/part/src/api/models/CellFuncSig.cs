//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CellFuncSig
    {
        [MethodImpl(Inline), Op]
        public static CellFuncSig sig(Name name, TypeWidth[] args, TypeWidth result)
            => new CellFuncSig(name, args, result);

        public Name FuncName {get;}

        public Index<TypeWidth> ArgWidths {get;}

        public TypeWidth ResultWidth {get;}

        [MethodImpl(Inline)]
        public CellFuncSig(Name name, TypeWidth[] args, TypeWidth result)
        {
            FuncName = name;
            ArgWidths = args;
            ResultWidth = result;
        }
    }
}