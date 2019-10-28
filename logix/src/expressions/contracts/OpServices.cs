//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public interface IOpSvc
    {
        
    }

    public interface ILogicOpSvc : IOpSvc
    {
        IEnumerable<UnaryLogicOpKind> UnaryOpKinds {get;}

        IEnumerable<BinaryLogicOpKind> BinaryOpKinds {get;}

        IEnumerable<TernaryBitOpKind> TernaryOpKinds {get;}

        bit Eval(UnaryLogicOpKind kind, bit a);

        bit eval(BinaryLogicOpKind kind, bit a, bit b);        

        bit eval(TernaryBitOpKind kind, bit a, bit b, bit c);        

        UnaryOp<bit> Lookup(UnaryLogicOpKind kind);

        BinaryOp<bit> Lookup(BinaryLogicOpKind kind);

        TernaryOp<bit> Lookup(TernaryBitOpKind kind);

    }
    
    public interface ITypedOpSvc : IOpSvc
    {
        IEnumerable<UnaryBitwiseOpKind> UnaryBitwiseKinds {get;}

        IEnumerable<BinaryBitwiseOpKind> BinaryBitwiseKinds {get;}

        IEnumerable<TernaryBitOpKind> TernaryBitOpKinds {get;}

        T Eval<T>(UnaryBitwiseOpKind kind, T a)
            where T : unmanaged;

        T Eval<T>(BinaryBitwiseOpKind kind, T a, T b)
            where T : unmanaged;

        T Eval<T>(TernaryBitOpKind kind, T a, T b, T c)
            where T : unmanaged;

        UnaryOp<T> Lookup<T>(UnaryBitwiseOpKind kind)
            where T : unmanaged;

        BinaryOp<T> Lookup<T>(BinaryBitwiseOpKind kind)
            where T : unmanaged;

        TernaryOp<T> Lookup<T>(TernaryBitOpKind kind)
            where T : unmanaged;

    }
     

    public interface ILogicDispatcher
    {
        /// <summary>
        /// Routes an expression to an evaulator
        /// </summary>
        /// <param name="expr">The expression to route</param>
        bit Eval(ILogicExpr expr);

        /// <summary>
        /// Returns an enabled bit if the equality expression is satisfied with 
        /// specified variable values and a disabled bit otherwise
        /// </summary>
        /// <param name="expr">The expression to test</param>
        /// <param name="a">The first variable value</param>
        /// <param name="b">The second variable value</param>
        bit Satisfied(ComparisonExpr expr, bit a, bit b);
    }


}