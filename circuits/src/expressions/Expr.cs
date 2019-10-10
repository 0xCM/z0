//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static Bitwise;




    partial class Bitwise
    {

        public interface IExpr
        {
            ExprArity Arity {get;}
        }

        public interface IExpr<T> : IExpr
            where T : unmanaged
        {

        }
        public interface IBitExpr : IExpr
        {
            
        }

        public interface IScalarExpr : IExpr
        {

        }

        public interface IScalarExpr<T> : IExpr<T>, IScalarExpr
            where T : unmanaged
        {


        }

        public interface IBitExpr<T> : IExpr<T>,  IBitExpr
            where T : unmanaged
        {
            
        }


        public interface IBitLogicExpr : IBitExpr
        {

        }

        public interface IBitLogicExpr<T> : IBitLogicExpr
            where T : unmanaged
        {
            /// <summary>
            /// The operator
            /// </summary>
            LogicOpKind Operator {get;}


        }
        public interface IUnaryLogicExpr<T> : IBitLogicExpr<T>
            where T : unmanaged
        {
            /// <summary>
            /// The operand
            /// </summary>
            IBitwiseExpr<T> Operand {get;}

        }

        public interface IBinaryLogicExpr<T> : IBitLogicExpr<T>
            where T : unmanaged
        {

            /// <summary>
            /// The left operand
            /// </summary>
            IBitwiseExpr<T> Left {get;}

            /// <summary>
            /// The right operand
            /// </summary>
            IBitwiseExpr<T> Right {get;}


        }

        public interface ITernaryLogicExpr<T> : IBitLogicExpr<T>
            where T : unmanaged
        {

            /// <summary>
            /// The first operand
            /// </summary>
            IBitwiseExpr<T> First {get;}

            /// <summary>
            /// The second operand
            /// </summary>
            IBitwiseExpr<T> Second {get;}

            /// <summary>
            /// The third operand
            /// </summary>
            IBitwiseExpr<T> Third {get;}
        }

        public abstract class Expr<T> 
            where T : unmanaged
        {

        }

        public interface IBitwiseExpr : IBitExpr
        {
            /// <summary>
            /// The operator
            /// </summary>
            BitOpKind Operator {get;}

        }

        public interface IBitwiseExpr<T> : IBitwiseExpr
            where T : unmanaged
        {

        }

        public interface IUnaryBitwiseExpr<T> : IBitwiseExpr<T>
            where T : unmanaged
        {
            /// <summary>
            /// The left operand
            /// </summary>
            IBitwiseExpr<T> Operand {get;}

        }

        public interface IBinaryBitwiseExpr<T> : IBitwiseExpr<T>
            where T : unmanaged
        {
            /// <summary>
            /// The left operand
            /// </summary>
            IBitwiseExpr<T> Left {get;}

            /// <summary>
            /// The right operand
            /// </summary>
            IBitwiseExpr<T> Right {get;}
        }

        public interface IMixedBitwiseExpr<T> : IBitwiseExpr<T>
            where T : unmanaged
        {
            /// <summary>
            /// The left operand
            /// </summary>
            IBitwiseExpr<T> Left {get;}

            /// <summary>
            /// The right operand
            /// </summary>
            uint Right {get;}
        }

        public interface ITernaryBitwiseExpr<T> : IBitwiseExpr<T>
            where T : unmanaged
        {
            /// <summary>
            /// The first operand
            /// </summary>
            IBitwiseExpr<T> First {get;}

            /// <summary>
            /// The second operand
            /// </summary>
            IBitwiseExpr<T> Second {get;}

            /// <summary>
            /// The third operand
            /// </summary>
            IBitwiseExpr<T> Third {get;}

        }

    }

}