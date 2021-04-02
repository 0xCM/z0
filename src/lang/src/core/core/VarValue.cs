//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct VarValue : IValue<Value>
    {
        public Var Var {get;}

        public Value Content {get;}

        [MethodImpl(Inline)]
        public VarValue(Var var, Value value)
        {
            Var = var;
            Content = value;
        }

        public DataType Type => Var.Type;
    }
}