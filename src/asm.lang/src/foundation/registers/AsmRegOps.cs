//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using R = AsmRegs;


    public readonly struct RegOp : IRegOp
    {
        public AsmOpKind OpKind => AsmOpKind.R;

        public BitWidth Width => throw new NotImplementedException();

        public dynamic Content => throw new NotImplementedException();

        public string Format()
        {
            throw new NotImplementedException();
        }
    }

    public readonly struct RegOp<T>
    {

    }

    public readonly partial struct AsmRegOps
    {
        public static RegOp<R.al> al => default;

    }
}