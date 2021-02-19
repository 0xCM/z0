//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmLabel
    {
        public Identifier Name {get;}

        public AsmLabel(Identifier name)
        {
            Name = name;
        }
    }
}