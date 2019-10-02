//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static partial class asm
    {                        
        public static AsmInstrExpr expr(MnemonicKind kind, params AsmExpr[] args)
            => AsmExpr.Define(kind,args);

    }

}