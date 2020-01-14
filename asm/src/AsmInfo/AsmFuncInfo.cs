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
    /// Describes the assembly encoding for a function
    /// </summary>
    public class AsmFuncInfo
    {   
        public AsmFuncInfo(ulong StartAddress, ulong EndAddress, Moniker Name, AsmInstructionInfo[] Instructions, byte[] Encoding)
        {
            this.StartAddress = StartAddress;
            this.EndAddress = EndAddress;
            this.Name = Name;
            this.Instructions = Instructions;
            this.Encoding = Encoding;
        }

        public AsmFuncInfo(ulong StartAddress, ulong EndAddress, MethodSig Signature, AsmInstructionInfo[] Instructions, byte[] Encoding)
        {
            this.StartAddress = StartAddress;
            this.EndAddress = EndAddress;
            this.Signature = Signature;
            this.Name = Moniker.define(Signature.MethodName);
            this.Instructions = Instructions;
            this.Encoding = Encoding;
        }

        /// <summary>
        /// The address at which the function definition begins
        /// </summary>
        public ulong StartAddress {get;}

        /// <summary>
        /// The address at which the function definition ends
        /// </summary>
        public ulong EndAddress {get;}

        /// <summary>
        /// The signature of the defined function
        /// </summary>
        public Option<MethodSig> Signature {get;}

        public Moniker Name {get;}

        public string FunctionName
            => Signature.MapValueOrElse(s => s.MethodName, () => Name.Text);
        
        /// <summary>
        /// The number of encoded instructions
        /// </summary>
        public int InstructionCount
            => Instructions.Length;

        /// <summary>
        /// The encoded instructions
        /// </summary>
        public AsmInstructionInfo[] Instructions {get;}

        /// <summary>
        /// The instruction encoding
        /// </summary>
        public byte[] Encoding {get;}                
    }
}
