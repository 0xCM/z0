//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;
    using static memory;

    public enum AsmGenTarget
    {
        None,

        InstructionType,

        MonicCode,

        MonicExpression,

        InstructionContracts
    }

}