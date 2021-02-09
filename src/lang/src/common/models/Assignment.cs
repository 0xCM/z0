//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Represents an assignment A := B
    /// </summary>
    public readonly struct VarAssignment
    {
        public Var Variable {get;}

        public Value Value {get;}

        [MethodImpl(Inline)]
        public VarAssignment(Var var, Value value)
        {
            Variable = var;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator VarValue(VarAssignment src)
            => new VarValue(src.Variable, src.Value);
    }
}