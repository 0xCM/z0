//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public interface IAsmExpr
    {


    }

    public abstract class AsmExpr : IAsmExpr
    {
        public static AsmInstrExpr Define(MnemonicKind mnemonic, params IAsmExpr[] args)
            => new AsmInstrExpr(mnemonic, args);
    }
}