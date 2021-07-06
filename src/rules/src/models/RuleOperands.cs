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
        public readonly struct RuleOperands
        {
            public Index<RuleOperand> Values {get;}

            [MethodImpl(Inline)]
            public RuleOperands(params RuleOperand[] values)
                => Values = values;

            public byte Count
            {
                [MethodImpl(Inline)]
                get => (byte)Values.Count;
            }
        }
    }
}