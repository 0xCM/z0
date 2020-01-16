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
        public static AsmFuncInfo Define(ulong StartAddress, ulong EndAddress, AsmCode code, AsmInstructionInfo[] instructions)
            => new AsmFuncInfo(StartAddress, EndAddress, code, instructions);

        public static AsmFuncInfo Define(ulong StartAddress, ulong EndAddress, AsmCode code, MethodSig sig, AsmInstructionInfo[] instructions)
            => new AsmFuncInfo(StartAddress, EndAddress, code, sig, instructions);

        public AsmFuncInfo(ulong StartAddress, ulong EndAddress, AsmCode code, AsmInstructionInfo[] instructions)
        {
            this.StartAddress = StartAddress;
            this.EndAddress = EndAddress;
            this.Instructions = instructions;
            this.Code = code;
        }

        public AsmFuncInfo(ulong StartAddress, ulong EndAddress, AsmCode code, MethodSig Signature,  AsmInstructionInfo[] instructions)
        {
            this.StartAddress = StartAddress;
            this.EndAddress = EndAddress;
            this.Signature = Signature;
            this.Instructions = instructions;
            this.Code = code;
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

        /// <summary>
        /// The encoded instructions
        /// </summary>
        public AsmInstructionInfo[] Instructions {get;}

        /// <summary>
        /// The function encoding
        /// </summary>
        public AsmCode Code {get;}

        /// <summary>
        /// The function identifier
        /// </summary>
        public Moniker Id 
            => Code.Id;

        /// <summary>
        /// The function label
        /// </summary>
        public string Label
            => Code.Label;

        public string Name
            => Signature.MapValueOrElse(s => s.MethodName, () => Id.Text);
        
        /// <summary>
        /// The number of encoded instructions
        /// </summary>
        public int InstructionCount
            => Instructions.Length;
    }
}
