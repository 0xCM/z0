//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using Z0.CilSpecs;

    using static Konst;

    /// <summary>
    /// Adheres a set of IL instructions with the source method
    /// </summary>
    public class CilFunction
    {
        [MethodImpl(Inline)]
        public static CilFunction Create(int MethodId, string FullName, MethodImplAttributes ImplSpec, Instruction[] Instructions)
            => new CilFunction(MethodId, FullName, ImplSpec, Instructions);

        [MethodImpl(Inline)]
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

    }
}