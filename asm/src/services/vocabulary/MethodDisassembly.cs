//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;

    using static zfunc;
    
    public class MethodDisassembly
    {
        public static MethodDisassembly Define(Moniker id, MethodAsmBody asmBody, byte[] cilbody, CilFunction cilfunc = null)
            => new MethodDisassembly(id, asmBody, cilbody, cilfunc);
        
        MethodDisassembly(Moniker id, MethodAsmBody asmBody, byte[] cilbody, CilFunction cilfunc = null)        
        {
            this.Id = id;
            this.Label = asmBody.Method.Signature().Format();
            this.AsmBody = asmBody;
            this.Method = asmBody.Method;
            this.CilBody = cilbody;
            this.CilFunction = cilfunc;
        }

        public Moniker Id {get;}

        public string Label {get;}

        public MethodAsmBody AsmBody {get;set;}

        public AsmCode AsmCode 
            => AsmCode.Define(Id, Label, AsmBody.NativeBlock.Data);
        
        public InstructionBlock Instructions
            => InstructionBlock.Define(Id, Label, AsmBody.Location, AsmBody.NativeBlock.Data, AsmBody.Instructions);

        public MethodInfo Method {get; set;}
    
        public byte[] CilBody {get;set;}

        public Option<CilFunction> CilFunction {get;set;}

        public string Name 
            => Method.Name;    
    }
}