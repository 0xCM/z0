//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct RuleOperand
    {
        public Name Name {get;}

        public TextBlock Value {get;}

        [MethodImpl(Inline)]
        public RuleOperand(string name, string value)
        {
            Name = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public RuleOperand(string value)
        {
            Name = Name.Empty;
            Value = value;
        }

        public string Format()
            => Name.IsEmpty ? Value : string.Format("{0}={1}", Name, Value);
    }

}