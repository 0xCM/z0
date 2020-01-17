//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using dnlib.DotNet;
    using dnlib.DotNet.Emit;
    using static zfunc;
        
    /// <summary>
    /// Adheres a set of IL instructions with the source method
    /// </summary>
    public class CilFunction
    {
        public CilFunction(int MethodId, string FullName, MethodImplAttributes ImplSpec, Instruction[] Instructions)
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

        public string FormatBody()
        {
            var body = text();
            iter(Instructions, i => body.AppendLine(i.ToString()));
            return body.ToString();
        }

        public override string ToString()
            => FormatBody();
    }
}