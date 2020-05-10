//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    using IM = InstructionModels;

    partial class InstructionModels
    {
        public class CmdAttribute : Attribute
        {
            public static OpCode TargetOpCode(Type t)
                =>  IM.OpCode.Define(t.Tag<CmdAttribute>().MapValueOrDefault(x => x.OpCode, string.Empty));

            public static OpSig TargetSig(Type t)
                => IM.OpSig.Define(t.Tag<CmdAttribute>().MapValueOrDefault(x => x.Sig, string.Empty));

            public static OpCode TargetOpCode<T>()
                => TargetOpCode(typeof(T));

            public static OpSig TargetSig<T>()
                => TargetSig(typeof(T));

            public CmdAttribute()
            {
                OpCode = string.Empty;
            }

            public CmdAttribute(string opcode)
            {
                OpCode = opcode;
            }

            public CmdAttribute(string opcode, string sig)
            {
                OpCode = opcode;
                Sig = sig;
            }

            /// <summary>
            /// The instruction op code
            /// </summary>
            public string OpCode {get;}

            /// <summary>
            /// The instruction signature
            /// </summary>
            public string Sig {get;}
        }
    }
}