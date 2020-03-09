//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    using Z0.ClrSpecs;

    /// <summary>
    /// Adheres a set of IL instructions with the source method
    /// </summary>
    public class CilFunction
    {
        public static CilFunction Create(int MethodId, string FullName, MethodImplAttributes ImplSpec, Instruction[] Instructions)
            => new CilFunction(MethodId, FullName, ImplSpec, Instructions);

        CilFunction(int MethodId, string FullName, MethodImplAttributes ImplSpec, Instruction[] Instructions)
        {
            this.MethodId = MethodId;
            this.FullName = FullName;
            this.ImplSpec = ImplSpec;
            this.Instructions = Instructions;
        }
        
        public int MethodId {get;}

        public MethodImplAttributes ImplSpec {get;}
                
        public string FullName {get;}

        public Option<MethodSig> Sig {get; private set;}

        public Instruction[] Instructions {get;}

        public CilFunction WithSig(MethodSig sig)
        {
            this.Sig = sig;
            return this;
        }
    }
}