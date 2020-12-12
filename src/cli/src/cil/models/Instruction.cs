//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    partial struct Cil
    {
        /// <summary>
        /// Defines a cil instruction
        /// </summary>
        public readonly struct Instruction
        {
            public CilOpCodeKind OpCode {get;}

            public Instruction(CilOpCodeKind kind)
            {
                OpCode = kind;
            }

            public string Format()
                => OpCode.ToString();
        }
    }
}