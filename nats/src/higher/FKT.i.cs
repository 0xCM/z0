//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    using static Root;
    using static Nats;

    /// <summary>
    /// Characterizes a class of unary operators over a primal operands where
    /// membership within a specific class is discriminated by a natural number
    /// </summary>
    /// <typeparam name="T">The primal operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface INatUnaryOp<N,T> : ISFUnaryOpApi<T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        N Discrimintator => default(N);
    }
    
    /// <summary>
    /// Characterizes a function with known arity
    /// </summary>
    /// <typeparam name="N">The arity type</typeparam>
    public interface IFuncArity<N>
        where N : unmanaged, ITypeNat
    {
        int Arity 
        {            
            [MethodImpl(Inline)]
            get => (int)nateval<N>();
        }            
    }

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

    public interface IFuncType<T1,R> : IUnaryFuncType
    {
    
    }

    public interface IFuncType<T1,T2,R> : IBinaryFuncType
    {
    
    }

    public interface IFuncType<T1,T2,T3,R> : ITernaryFuncType
    {
    
    }

    public interface IEmitterFuncType : IFuncType, IFuncArity<N0>
    {

    }

    public interface IUnaryFuncType : IFuncType, IFuncArity<N1>
    {

    }

    public interface IBinaryFuncType : IFuncType, IFuncArity<N2>
    {

        
    }

    public interface ITernaryFuncType : IFuncType, IFuncArity<N3>
    {

        
    }

    /// <summary>
    /// Identifies an operator function kind
    /// </summary>
    public interface IOperatorFuncType : IFuncType
    {

    }

    /// <summary>
    /// Characterizes an operator function kind with parametric arity A
    /// </summary>
    /// <typeparam name="A">The arity type</typeparam>
    public interface IOperatorFuncType<A> : IOperatorFuncType, IFuncArity<A> 
        where A : unmanaged, ITypeNat
    {

    }

    /// <summary>
    /// Characterizes a T-parametric operator function kind with parametric arity A
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    /// <typeparam name="A">The arity type</typeparam>
    public interface IOperatorFuncType<A,T> : IOperatorFuncType<A>, IOperatorFuncType
        where A : unmanaged, ITypeNat
    {

    }
}