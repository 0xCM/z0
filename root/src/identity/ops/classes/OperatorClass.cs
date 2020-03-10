//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    using FK = FunctionClass;
    using static OperatorClass;

    /// <summary>
    /// Classifies operators of arity either 1, 2, or 3
    /// </summary>
    public enum OperatorClass : ulong
    {
        None = 0,

        UnaryOp = FK.UnaryOp,

        BinaryOp = FK.BinaryOp,
        
        TernaryOp = FK.TernaryOp,
    }

    public static class OperatorClassOps
    {
        public static int Arity(this OperatorClass src)
            => src switch{
               UnaryOp => 1,
               BinaryOp => 2,
               TernaryOp => 3,     
                _  => 0,
            };
    }
}