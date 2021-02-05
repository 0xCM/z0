//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    public static partial class LogicEngine
    {
        /// <summary>
        /// Evaluates an untyped expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [Op]
        public static bit eval(ILogicExpr expr)
            => LogicExprEval.eval(expr);

        /// <summary>
        /// Evaluates a typed logic expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [Op, Closures(UnsignedInts)]
        public static bit eval<T>(ILogicExpr<T> expr)
            where T : unmanaged
                => LogicExprEval.eval(expr);

        /// <summary>
        /// Evaluates a typed scalar expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [Op, Closures(UnsignedInts)]
        public static LiteralExpr<T> eval<T>(IExpr<T> expr)
            where T : unmanaged
                => ScalarExprEval.eval(expr);

        /// <summary>
        /// Evaluates a comparison expression, returning literal expression over the comparison type
        /// and the interpretation of this literal is type-dependent
        /// </summary>
        /// <param name="expr">The predicate to evaluate</param>
        /// <typeparam name="T">The type over which the comparison is defined</typeparam>
        [Op, Closures(UnsignedInts)]
        public static LiteralExpr<T> eval<T>(IComparisonExpr<T> expr)
            where T : unmanaged
                => CmpExprEval.eval(expr);

        /// <summary>
        /// Evaluates a comparison expression over 128-bit intrinsic vectors
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Op, Closures(UnsignedInts)]
        public static LiteralExpr<Vector128<T>> eval<T>(IComparisonExpr<Vector128<T>> expr)
            where T : unmanaged
                => CmpExprEval.eval(expr);

        /// <summary>
        /// Evaluates a comparison expression over 256-bit intrinsic vectors
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        /// <typeparam name="T">The cell type</typeparam>
        [Op, Closures(UnsignedInts)]
        public static LiteralExpr<Vector256<T>> eval<T>(IComparisonExpr<Vector256<T>> expr)
            where T : unmanaged
                => CmpExprEval.eval(expr);

        /// <summary>
        /// Evaluates a comparison predicate, returning an enabled bit if the comparison succeeds and
        /// a disabled bit otherwise
        /// </summary>
        /// <param name="expr">The predicate to evaluate</param>
        /// <typeparam name="T">The type over which the comparison is defined</typeparam>
        [Op, Closures(UnsignedInts)]
        public static bit eval<T>(IComparisonPredExpr<T> expr)
            where T : unmanaged
                => CmpExprEval.eval(expr);

        /// <summary>
        /// Evaluates a typed scalar expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [Op, Closures(UnsignedInts)]
        public static LiteralExpr<T> eval<T>(IArithmeticExpr<T> expr)
            where T : unmanaged
                => ArithExprEval.eval(expr);

        /// <summary>
        /// Evaluates a typed 128-bit intrinsic expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [Op, Closures(UnsignedInts)]
        public static LiteralExpr<Vector128<T>> eval<T>(IExpr<Vector128<T>> expr)
            where T : unmanaged
                => VectorExprEval.eval(expr);

        /// <summary>
        /// Evaluates a typed 256-bit intrinsic expression
        /// </summary>
        /// <param name="expr">The expression to evaluate</param>
        [Op, Closures(UnsignedInts)]
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
        [Op]
        public static bit satisfied(ComparisonExpr expr, bit a, bit b)
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
        [Op, Closures(Integers)]
        public static bit satisfied<T>(ComparisonExpr<T> expr, T a, T b)
            where T :unmanaged
        {
            expr.SetVars(a,b);
            return gmath.eq(LogicEngine.eval(expr).Value, Numeric.maxval<T>());
        }

        /// <summary>
        /// Returns an enabled bit if the equality expression is satisfied with
        /// specified variable values and a disabled bit otherwise
        /// </summary>
        /// <param name="expr">The expression to test</param>
        /// <param name="a">The first variable value</param>
        /// <param name="b">The second variable value</param>
        [Op, Closures(Integers)]
        public static bit satisfied<T>(ComparisonExpr<Vector128<T>> expr, Vector128<T> a, Vector128<T> b)
            where T :unmanaged
        {
            expr.SetVars(a,b);
            var result = eval(expr);
            return gvec.vtestc(result.Value, gcpu.vones<T>(n128));
        }

        /// <summary>
        /// Returns an enabled bit if the equality expression is satisfied with
        /// specified variable values and a disabled bit otherwise
        /// </summary>
        /// <param name="expr">The expression to test</param>
        /// <param name="a">The first variable value</param>
        /// <param name="b">The second variable value</param>
        [Op, Closures(Integers)]
        public static bit satisfied<T>(ComparisonExpr<Vector256<T>> expr, Vector256<T> a, Vector256<T> b)
            where T :unmanaged
        {
            expr.SetVars(a,b);
            var result = eval(expr);
            return gvec.vtestc(result.Value, gcpu.vones<T>(n256));
        }

        /// <summary>
        /// Determines by exhaustion whether the left and right operands are equal
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [Op]
        public static bit equal(VariedLogicExpr a, VariedLogicExpr b)
        {
            var count = a.Vars.Length;
            foreach(var vars in BitLogicSpec.bitcombo(count))
            {
                a.SetVars(vars);
                var x = LogicEngine.eval(a);
                var y = LogicEngine.eval(b);
                if(x != y)
                    return Z0.Bit32.Off;
            }
            return Z0.Bit32.On;
        }

        [Op, Closures(UnsignedInts)]
        public static IReadOnlyList<T> solve<T>(ComparisonExpr<T> expr, Interval<T> domain, int varyix)
            where T : unmanaged
        {
            var sln = new List<T>();
            var level0 = domain.Increments(default(T));
            var ones = Numeric.maxval<T>();
            for(var i=0; i<level0.Length; i++)
            {
                expr.SetVar(varyix, level0[i]);
                var result = LogicEngine.eval(expr);
                if(gmath.eq(result.Value, ones))
                    sln.Add(result);
            }
            return sln;
        }

        [Op, Closures(UnsignedInts)]
        public static IReadOnlyList<T> solve<T>(ComparisonExpr<T> expr, Interval<T> domain)
            where T : unmanaged
        {
            var sln = new List<T>();
            var level0 = domain.Increments(default(T));
            var level1 = domain.Increments(default(T));
            var ones = Numeric.maxval<T>();
            for(var i=0; i<level0.Length; i++)
            {
                expr.SetVar(0,level0[i]);
                for(var j=0; j<level1.Length; j++)
                {
                    expr.SetVar(1,level1[j]);

                    var result = LogicEngine.eval(expr);
                    if(gmath.eq(result.Value, ones))
                        sln.Add(result);
                }
            }
            return sln;
        }
    }
}