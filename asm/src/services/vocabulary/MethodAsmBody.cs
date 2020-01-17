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
        public MethodAsmBody(MethodInfo method, NativeCodeBlock block, Instruction[] instructions)
        {
            this.Method = method;
            this.NativeBlock = block;
            this.Instructions = instructions;
            this.StartAddress = instructions.First().IP;
            this.EndAddress = instructions.Last().IP;
        }
        
        public MethodInfo Method {get;}

        public ulong StartAddress {get;}
            
        public ulong EndAddress {get;}

        public Instruction[] Instructions {get;}
        
        public NativeCodeBlock NativeBlock {get;}

    }
}