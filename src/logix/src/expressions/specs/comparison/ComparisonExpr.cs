//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines an untyped comparison expression
    /// </summary>
    public readonly struct ComparisonExpr : IComparisonExpr
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public BinaryComparisonApiKey ComparisonKind {get;}

        /// <summary>
        /// The left operand
        /// </summary>
        public ILogicExpr Lhs {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        public ILogicExpr Rhs {get;}

        /// <summary>
        /// The variables upon which the operands depend
        /// </summary>
        public ILogicVarExpr[] Vars {get;}

        [MethodImpl(Inline)]
        public static ComparisonExpr<T> define<T>(BinaryComparisonApiKey kind, IExpr<T> lhs, IExpr<T> rhs, params IVarExpr<T>[] vars)
            where T : unmanaged
                => new ComparisonExpr<T>(kind,lhs,rhs,vars);

        [MethodImpl(Inline)]
        public static ComparisonExpr define(BinaryComparisonApiKey kind, ILogicExpr lhs, ILogicExpr rhs, params ILogicVarExpr[] vars)
            => new ComparisonExpr(kind,lhs,rhs,vars);

        internal ComparisonExpr(BinaryComparisonApiKey kind, ILogicExpr lhs, ILogicExpr rhs, params ILogicVarExpr[] vars)
        {
            ComparisonKind = kind;
            Lhs = lhs;
            Rhs = rhs;
            Vars = vars;
        }

        public void SetVars(params ILogicExpr[] values)
        {
            var count = Math.Min(Vars.Length, values.Length);
            for(var i=0; i<count; i++)
                Vars[i].Set(values[i]);
        }

        public void SetVars(ILiteralLogicSeqExpr values)
        {
            var count = Math.Min(Vars.Length, values.Length);
            for(var i=0; i<count; i++)
                Vars[i].Set(values[i]);
        }

        public void SetVars(params Bit32[] values)
        {
            var count = Math.Min(Vars.Length, values.Length);
            for(var i=0; i<count; i++)
                Vars[i].Set(values[i]);
        }

        [MethodImpl(Inline)]
        public void SetVar(Bit32 a)
        {
            Vars[0].Set(a);
        }

        [MethodImpl(Inline)]
        public void SetVars(Bit32 a, Bit32 b)
        {
            Vars[0].Set(a);
            Vars[1].Set(b);
        }

        [MethodImpl(Inline)]
        public void SetVars(Bit32 a, Bit32 b, Bit32 c)
        {
            Vars[0].Set(a);
            Vars[1].Set(b);
            Vars[2].Set(c);
        }

        public string Format()
            => Lhs.Format() + " == " + Rhs.Format();
    }
}