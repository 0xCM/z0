//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    using static Components;
    
    /// <summary>
    /// Characterizes a higher-kinded function representation
    /// </summary>
    public interface IFuncType : ILiteralKind<FunctionClass>
    {

    }

    /// <summary>
    /// Characterizes a R-parametric emitter emitter
    /// </summary>
    /// <typeparam name="R">The emission type</typeparam>
    public interface IFuncType<R> : IEmitterFuncType
    {
    
    }

    public interface IFuncType<T1,R> : IFTUnary
    {
    
    }

    public interface IFuncType<T1,T2,R> : IFTBinary
    {
    
    }

    public interface IFuncType<T1,T2,T3,R> : IFTTernary
    {
    
    }

    public interface IEmitterFuncType : IFuncType
    {

    }

    public interface IFTUnary : IFuncType
    {

    }

    public interface IFTBinary : IFuncType
    {

        
    }

    public interface IFTTernary : IFuncType
    {

        
    }

    /// <summary>
    /// Identifies an operator function kind
    /// </summary>
    public interface IFTOperator : IFuncType
    {

    }

    public interface IFTUnaryOp : IFTOperator
    {

    }

    public interface IFTBinaryOp : IFTOperator
    {

        
    }

    public interface IFTTernaryOp : IFTOperator
    {

        
    }

    /// <summary>
    /// Characterizes an operator function kind with parametric arity A
    /// </summary>
    /// <typeparam name="A">The arity type</typeparam>
    public interface IOperatorFuncType<A> : IFTOperator
        where A : unmanaged, ITypeNat
    {

    }

    /// <summary>
    /// Characterizes a T-parametric operator function kind with parametric arity A
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    /// <typeparam name="A">The arity type</typeparam>
    public interface IOperatorFuncType<A,T> : IOperatorFuncType<A>, IFTOperator
        where A : unmanaged, ITypeNat
    {

    }
}