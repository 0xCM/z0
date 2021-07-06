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

        /// <summary>
        /// Defines an operand value of parametric type
        /// </summary>
        public readonly struct RuleOperand<T>
        {
            public string Name {get;}

            public T Value {get;}

            [MethodImpl(Inline)]
            public RuleOperand(string name, T value)
            {
                Name = name;
                Value = value;
            }

            [MethodImpl(Inline)]
            public static implicit operator RuleOperand(RuleOperand<T> src)
                => new RuleOperand(src.Name, src.Value);

            [MethodImpl(Inline)]
            public static implicit operator RuleOperand<T>((string name, T value) src)
                => new RuleOperand<T>(src.name, src.value);
        }

    }
}