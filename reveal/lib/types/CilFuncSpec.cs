//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    //using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using dnlib.DotNet;
    using dnlib.DotNet.Emit;
    using static zfunc;
        
    /// <summary>
    /// Adheres a set of IL instructions with the source method
    /// </summary>
    public class CilFuncSpec
    {
        public CilFuncSpec(int MethodId, string FullName, MethodImplAttributes ImplSpec, IReadOnlyList<Instruction> Instructions)
        {
            this.MethodId = MethodId;
            this.FullName = FullName;
            this.ImplSpec = ImplSpec;
            this.Instructions = Instructions.Select(i => new CilMethodCode(i)).ToReadOnlyList();
        }
        
        public int MethodId {get;}

        public MethodImplAttributes ImplSpec {get;}
                
        public string FullName {get;}

        public Option<MethodSig> Sig {get; private set;}

        public IReadOnlyList<CilMethodCode> Instructions {get;}

        public CilFuncSpec WithSig(MethodSig sig)
        {
            this.Sig = sig;
            return this;
        }

        public string Format()
        {
            var desc = text();
            var margin = new string(AsciSym.Space,2);
            var comment = concat(AsciSym.FSlash,AsciSym.FSlash);

            desc.AppendLine($"{comment}{margin}Id := {MethodId}, Name := {FullName}");
            Sig.TryMap(s => desc.AppendLine($"{comment}{margin}{s.Format()}"));
            desc.AppendLine($"{comment}{margin}{ImplSpec}");
            
            desc.AppendLine(AsciSym.LBrace.ToString());                        
            foreach(var i in Instructions)
                desc.AppendLine($"{margin}{i.ToString()}");                        
            desc.AppendLine(AsciSym.RBrace.ToString());            
            
            return desc.ToString();

        }
 
         public override string ToString()
            => Format();

    }
}