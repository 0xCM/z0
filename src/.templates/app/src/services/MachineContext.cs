//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Asm;

    using static Konst;
    using static Memories;

    public interface IMachineContext : IContext
    {
        PartId[] CodeParts {get;}
    }

    readonly struct MachineContext : IMachineContext
    {
        public static IMachineContext Create(IAsmContext root, PartId[] code)
            => new MachineContext(root,code);
        
        MachineContext(IAsmContext root, PartId[] code)
        {
            Root = root;
            CodeParts = code;
            
        }

        readonly IAsmContext Root;

        public PartId[] CodeParts {get;}
    }
}