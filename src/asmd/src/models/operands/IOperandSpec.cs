//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public interface IOperandSpec
    {
        /// <summary>
        /// The operand width, in bits
        /// </summary>
        DataWidth Width {get;}

        /// <summary>
        /// The operand sort
        /// </summary>
        OperandKind Kind {get;}
    }
}