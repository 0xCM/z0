//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Operand
    {
        public Name Name {get;}

        public DataType Type {get;}

        public dynamic Value {get;}

        [MethodImpl(Inline)]
        public Operand(string name, DataType type, dynamic value)
        {
            Name = name;
            Type = type;
            Value = value;
        }
    }
}