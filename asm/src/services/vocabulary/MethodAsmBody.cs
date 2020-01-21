//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using Iced.Intel;
    using static zfunc;
        
    /// <summary>
    /// Adheres a set of IL instructions with the source method
    /// </summary>
    public class MethodAsmBody
    {
        public static MethodAsmBody Define(MethodInfo method, NativeCodeBlock block, IEnumerable<Instruction> instructions)
            => new MethodAsmBody(method,block,instructions.ToArray());

        public MethodAsmBody(MethodInfo method, NativeCodeBlock block, Instruction[] instructions)
        {
            this.Method = method;
            this.NativeBlock = block;
            this.Instructions = instructions;
            this.Location = MemoryRange.Define(instructions.First().IP,instructions.Last().IP + (ulong)instructions.Last().ByteLength);            
        }
        
        public MethodInfo Method {get;}

        public MemoryRange Location {get;}
            
        public Instruction[] Instructions {get;}
        
        public NativeCodeBlock NativeBlock {get;}

    }
}