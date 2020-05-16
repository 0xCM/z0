//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Defines a primary opcode of one, two or three bytes in length
    /// </summary>
    public readonly struct OpCode
    {
        readonly byte C0;

        readonly byte C1;

        readonly byte C2;

        readonly byte C3;

        [MethodImpl(Inline)]
        public OpCode(byte c0)
        {
            C0 = c0;
            C1 = 0;
            C2 = 0;
            C3 = 0;
        }

        [MethodImpl(Inline)]
        public OpCode(byte c0, byte c1)
            : this(c0)
        {
            C1 = c1;
        }

        [MethodImpl(Inline)]
        public OpCode(byte c0, byte c1, byte c3)
            : this(c0, c1)
        {
            C3 = c3;
        }
    }
}