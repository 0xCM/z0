//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Rules;

    public readonly struct VarValue : IValue<object>
    {
        public Var Var {get;}

        public object Content {get;}

        [MethodImpl(Inline)]
        public VarValue(Var var, object value)
        {
            Var = var;
            Content = value;
        }

        public DataType Type => Var.Type;
    }

}