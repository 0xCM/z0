//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        /// <summary>
        /// Defines an operand value of dynamic type
        /// </summary>
        public readonly struct RuleOperand
        {
            public string Name {get;}

            public dynamic Value {get;}

            [MethodImpl(Inline)]
            public RuleOperand(string name, dynamic value)
            {
                Name = name;
                Value = value;
            }
        }
    }
}