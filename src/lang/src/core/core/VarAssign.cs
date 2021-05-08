//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Represents an assignment A := B
    /// </summary>
    public readonly struct VarAssign
    {
        public Var Variable {get;}

        public Value Value {get;}

        [MethodImpl(Inline)]
        public VarAssign(Var var, Value value)
        {
            Variable = var;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator VarValue(VarAssign src)
            => new VarValue(src.Variable, src.Value);
    }
}