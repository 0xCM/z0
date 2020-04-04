//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Security;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public class AsmFunctionIndex
    {
        public static AsmFunctionIndex Create(AsmFunctionGroup src)
            => new AsmFunctionIndex(src);
         
        AsmFunctionIndex(AsmFunctionGroup src)
        {
            Id = src.Id;
            index = new Dictionary<OpIdentity, AsmFunction>();
            foreach(var item in src.Members)            
            {
                if(!index.TryAdd(item.Id, item))
                    AppErrors.Throw($"Duplicate identifier found: Id = {item.Id}");
            }
        }
        
        Dictionary<OpIdentity,AsmFunction> index;

        OpIdentity Id {get;}
        
        Option<AsmFunction> Lookup(OpIdentity id)
            => index.TryFind(id);

        public IEnumerable<AsmFunction> Functions
            => index.Values;
        
        public IEnumerable<AsmFunction> Containing(Mnemonic mnemonic)
            => from f in Functions
                from i in  f.Instructions
                where i.Mnemonic == mnemonic
                select f;
    }
}
