//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Part;

    partial struct Cil
    {
        /// <summary>
        /// Defines a cil instruction
        /// </summary>
        public readonly struct Instruction
        {
            public OpCode OpCode {get;}

            public Index<byte> Args {get;}

            [MethodImpl(Inline)]
            public Instruction(OpCode op, params byte[] args)
            {
                OpCode = op;
                Args = args;
            }

            public string Format()
                => OpCode.ToString();
        }
    }
}