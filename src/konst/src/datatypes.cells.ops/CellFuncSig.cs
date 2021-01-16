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
        public utf8 FuncName {get;}

        public Index<TypeWidth> ArgWidths {get;}

        public TypeWidth ResultWidth {get;}

        [MethodImpl(Inline)]
        public CellFuncSig(utf8 name, TypeWidth[] args, TypeWidth result)
        {
            FuncName = name;
            ArgWidths = args;
            ResultWidth = result;
        }
    }
}