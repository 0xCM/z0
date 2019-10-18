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

    /// <summary>
    /// Characterizes an expression
    /// </summary>
    public interface IExpr
    {
        string Format();   
    }

    /// <summary>
    /// Characterizes an expression over an unmanaged type
    /// </summary>
    /// <typeparam name="T">The type over which the expression is defined</typeparam>
    public interface IExpr<T> : IExpr
        where T : unmanaged
    {

    }

    public interface ILiteral : IExpr
    {
        
    }

    public interface ILiteral<T> : ILiteral, IExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The value of the literal
        /// </summary>
        T Value {get;}                
    }

    /// <summary>
    /// Characterizes an expression defined via an operator
    /// </summary>
    public interface IOpExpr : IExpr
    {
        //OpArityKind Arity {get;}
    }

    /// <summary>
    /// Characterizes a typed expression defined via an operator
    /// </summary>
    /// <typeparam name="T">The type over which the expression is defined</typeparam>
    public interface IOpExpr<T> : IExpr<T>, IOpExpr
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a typed expression defined via an operator of specified kind
    /// </summary>
    /// <typeparam name="T">The type over which the expression is defined</typeparam>
    /// <typeparam name="K">The operator classifier</typeparam>
    public interface IOpExpr<T,K> : IOpExpr<T>
        where T : unmanaged
        where K : Enum
    {
        K OpKind {get;}
    }

    /// <summary>
    /// Characterizes a logic expression over a bit
    /// </summary>
    public interface ILogicExpr : ILogicExpr<bit>
    {
        
    }

    /// <summary>
    /// Characterizes a typed logic expression 
    /// </summary>
    /// <typeparam name="T">The type over which the expression is defined</typeparam>
    public interface ILogicExpr<T> : IExpr<T>
        where T : unmanaged
    {

    }

    public interface ILogicOp : ILogicExpr, IOpExpr
    {

    }

    public interface ILogicOp<K> : ILogicOp
        where K : Enum
    {
        K OpKind {get;}
    }


    /// <summary>
    /// Characterizes a unary operator
    /// </summary>
    public interface IUnaryOp : IOpExpr
    {
        
    }

    /// <summary>
    /// Characterizes a typed unary operator
    /// </summary>
    /// <typeparam name="T">The type over which the operator is defined</typeparam>
    public interface IUnaryOp<T> : IOpExpr<T>, IUnaryOp
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a typed unary operator of specified kind
    /// </summary>
    /// <typeparam name="T">The type over which the operator is defined</typeparam>
    /// <typeparam name="K">The operator classifier</typeparam>
    public interface IUnaryOp<T,K> : IOpExpr<T,K>, IUnaryOp<T>
        where T : unmanaged
        where K : Enum
    {
        
    }

    /// <summary>
    /// Characterizes a binary operator
    /// </summary>
    public interface IBinaryOp : IOpExpr
    {
        
    }

    /// <summary>
    /// Characterizes a typed binary operator
    /// </summary>
    /// <typeparam name="T">The type over which the operator is defined</typeparam>
    public interface IBinaryOp<T> : IOpExpr<T>, IBinaryOp
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a typed binary operator of specified kind
    /// </summary>
    /// <typeparam name="T">The type over which the operator is defined</typeparam>
    /// <typeparam name="K">The operator classifier</typeparam>
    public interface IBinaryOp<T,K> : IOpExpr<T,K>, IBinaryOp<T>
        where T : unmanaged
        where K : Enum
    {
        
    }

    /// <summary>
    /// Characterizes a ternary operator
    /// </summary>
    public interface ITernaryOp : IOpExpr
    {
        
    }

    /// <summary>
    /// Characterizes a typed ternary operator
    /// </summary>
    /// <typeparam name="T">The type over which the operator is defined</typeparam>
    public interface ITernaryOp<T> : IOpExpr<T>, ITernaryOp
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a typed ternary operator of specified kind
    /// </summary>
    /// <typeparam name="T">The type over which the operator is defined</typeparam>
    /// <typeparam name="K">The operator classifier</typeparam>
    public interface ITernaryOp<T,K> : IOpExpr<T,K>, ITernaryOp<T>
        where T : unmanaged
        where K : Enum
    {
        
    }

    /// <summary>
    /// Characterizes an untyped variable expression
    /// </summary>
    public interface IVariable : IExpr
    {
        /// <summary>
        /// The name of the variable
        /// </summary>
        string Name {get;}            

        void Set(IExpr value);

        IExpr Value {get;}
    }

    /// <summary>
    /// Characterizes a typed variable expression
    /// </summary>
    public interface IVariable<T> : IVariable, IExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// Gets the current value of the variable
        /// </summary>
        new IExpr<T> Value {get;}

        /// <summary>
        /// Sets the variable value
        /// </summary>
        void Set(IExpr<T> value);
    }

    public interface IVariedExpr : IExpr
    {

    }

    public interface IVariedExpr<T> : IVariedExpr
        where T : unmanaged
    {
        Variable<T>[] Vars {get;}

        IExpr<T> BaseExpr {get;}
    }

    public interface IVariedExpr<E,V> : IVariedExpr
        where E : IExpr
        where V : IVariable
    {

        E BaseExpr {get;}        

        V[] Vars {get;}        

        void SetVarValues(params E[] values);        
    }

    public interface IVariedExpr<N,E,V> : IVariedExpr<E,V>
        where E : IExpr
        where V : IVariable
        where N : unmanaged, ITypeNat
    {
        
    }

    public interface INodeExpr : IExpr
    {

    }

    public interface INodeExpr<T> : IExpr<T>, INodeExpr
        where T : unmanaged
    {

    }

    public interface INodeExpr<T,E> : INodeExpr<T>
        where T : unmanaged
    {
        E[] Terms {get;}
    }

}