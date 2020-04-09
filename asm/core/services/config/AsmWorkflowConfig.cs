//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct AsmWorkflowConfig
    {
        [MethodImpl(Inline)]
        public static AsmWorkflowConfig Define(FolderPath root)
            => new AsmWorkflowConfig(root);

        [MethodImpl(Inline)]
        public AsmWorkflowConfig(FolderPath root)
        {
            this.EmissionRoot = root;
        }

        public FolderPath EmissionRoot {get;}
    }
}