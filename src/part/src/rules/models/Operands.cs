//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        /// <summary>
        /// Defines an operand sequence
        /// </summary>
        public readonly struct Operands
        {
            public Index<Operand> Values {get;}

            [MethodImpl(Inline)]
            public Operands(params Operand[] values)
                => Values = values;

            public byte Count
            {
                [MethodImpl(Inline)]
                get => (byte)Values.Count;
            }
        }
    }
}