//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Represents an assembly instruction together with zero or more arguments
    /// </summary>
    public class AsmInstrExpr : AsmExpr
    {
        public AsmInstrExpr(MnemonicKind mnemonic, params IAsmExpr[] args)
        {
            this.Mnemonic = mnemonic;
            this.Args = new AsmArgList(args.Mapi((i,a) => new AsmArgExpr(i,a)));
        }

        /// <summary>
        /// The instruction mnemonic
        /// </summary>
        public MnemonicKind Mnemonic {get;}

        /// <summary>
        /// The associated argument list
        /// </summary>
        public AsmArgList Args {get;}
    }
}