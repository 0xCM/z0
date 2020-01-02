//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    [AttributeUsage(AttributeTargets.Method)]
    public class AsmInstrAttribute : Attribute
    {
        public AsmInstrAttribute(MnemonicKind mnemonic, string opcode = null, string spec = null)
        {
            this.Mnemonic = mnemonic;
            this.OpCode = opcode ?? string.Empty;
            this.Spec = spec ?? string.Empty;
        }
        
        public string OpCode {get;}    

        public MnemonicKind Mnemonic {get;}

        public string Spec {get;}
    }
}