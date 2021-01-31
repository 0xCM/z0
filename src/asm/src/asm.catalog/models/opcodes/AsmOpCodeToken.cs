//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmOpCodeModel
    {
        public readonly struct OpCodeToken
        {
            public AsmOpCodeSyntaxKey Id {get;}
        }
    }
}