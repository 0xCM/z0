//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public static partial class LogicEngine
    {
        /// <summary>
        /// Evalutates an untyped expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [MethodImpl(Inline)]
        public static bit eval(ILogicExpr expr)
            => BitLogicEval.eval(expr);
        
        /// <summary>
        /// Evalutates a typed scalar expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [MethodImpl(Inline)]
        public static LiteralExpr<T> eval<T>(IExpr<T> expr)
            where T : unmanaged
                => ScalarExprEval.eval(expr);
        
        /// <summary>
        /// Evalutates a typed 128-bit intrinsic expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [MethodImpl(Inline)]
        public static LiteralExpr<Vector128<T>> eval<T>(IExpr<Vector128<T>> expr)
            where T : unmanaged
                => VectorExprEval.eval(expr);

        /// <summary>
        /// Evalutates a typed 256-bit intrinsic expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [MethodImpl(Inline)]
        public static LiteralExpr<Vector256<T>> eval<T>(IExpr<Vector256<T>> expr)
            where T : unmanaged
                => VectorExprEval.eval(expr);
  
        /// <summary>
        /// Returns an enabled bit if the equality expression is satisfied with 
        /// specified variable values and a disabled bit otherwise
        /// </summary>
        /// <param name="expr">The expression to test</param>
        /// <param name="a">The first variable value</param>
        /// <param name="b">The second variable value</param>
        [MethodImpl(Inline)]
        public static bit satisfied(EqualityExpr expr, bit a, bit b)
        {
            expr.SetVars(a,b);
            return LogicEngine.eval(expr);
        }

        /// <summary>
        /// Returns an enabled bit if the equality expression is satisfied with 
        /// specified variable values and a disabled bit otherwise
        /// </summary>
        /// <param name="expr">The expression to test</param>
        /// <param name="a">The first variable value</param>
        /// <param name="b">The second variable value</param>
        [MethodImpl(Inline)]
        public static bit satisfied<T>(EqualityExpr<T> expr, T a, T b)
            where T :unmanaged
        {
            expr.SetVars(a,b);
            return gmath.eq(LogicEngine.eval(expr).Value, gmath.maxval<T>());
        }

        /// <summary>
        /// Returns an enabled bit if the equality expression is satisfied with 
        /// specified variable values and a disabled bit otherwise
        /// </summary>
        /// <param name="expr">The expression to test</param>
        /// <param name="a">The first variable value</param>
        /// <param name="b">The second variable value</param>
        [MethodImpl(Inline)]
        public static bit satisfied<T>(EqualityExpr<Vector128<T>> expr, Vector128<T> a, Vector128<T> b)
            where T :unmanaged
        {
            expr.SetVars(a,b);
            var result = LogicEngine.eval(expr);
            return ginx.testc(result.Value, ginx.vones<T>(n128));
        }

        /// <summary>
        /// Returns an enabled bit if the equality expression is satisfied with 
        /// specified variable values and a disabled bit otherwise
        /// </summary>
        /// <param name="expr">The expression to test</param>
        /// <param name="a">The first variable value</param>
        /// <param name="b">The second variable value</param>
        [MethodImpl(Inline)]
        public static bit satisfied<T>(EqualityExpr<Vector256<T>> expr, Vector256<T> a, Vector256<T> b)
            where T :unmanaged
        {
            expr.SetVars(a,b);
            var result = LogicEngine.eval(expr);
            return ginx.testc(result.Value, ginx.vones<T>(n256));
        }

        /// <summary>
        /// Determines by exhaustion whether the left and right operands are equal
        /// </summary>
        /// <param name="a">The left operandd</param>
        /// <param name="b">The right operand</param>
        public static bit equal(VariedExpr a, VariedExpr b)
        {                
            var count = length(a.Vars, b.Vars);
            foreach(var vars in BitLogicSpec.bitcombo(count))
            {
                a.SetVars(vars);
                var x = LogicEngine.eval(a);
                var y = LogicEngine.eval(b);
                if(x != y)
                    return bit.Off;
            }                
            return bit.On;
        }


  }
}