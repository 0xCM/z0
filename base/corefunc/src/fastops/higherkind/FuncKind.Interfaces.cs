//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public interface IFuncArity<A>
        where A : unmanaged, ITypeNat
    {
        int Arity 
        {            
            [MethodImpl(Inline)]
            get => (int)nateval<A>();
        }
            
    }

    /// <summary>
    /// Characterizes a higher-kinded function representation
    /// </summary>
    public interface IFuncKind : IKind<FunctionKind>
    {

    }

    public interface IEmitterFuncKind : IFuncKind, IFuncArity<N0>
    {

    }

    public interface IUnaryFuncKind : IFuncKind, IFuncArity<N1>
    {

    }

    public interface IBinaryFuncKind : IFuncKind, IFuncArity<N2>
    {

        
    }

    public interface ITernaryFuncKind : IFuncKind, IFuncArity<N3>
    {

        
    }

    /// <summary>
    /// Characterizes a R-parametric emitter emitter
    /// </summary>
    /// <typeparam name="R">The emission type</typeparam>
    public interface IFuncKind<R> : IEmitterFuncKind
    {
    
    }

    public interface IFuncKind<T1,R> : IUnaryFuncKind
    {
    
    }

    public interface IFuncKind<T1,T2,R> : IBinaryFuncKind
    {
    
    }

    public interface IFuncKind<T1,T2,T3,R> : ITernaryFuncKind
    {
    
    }

    /// <summary>
    /// Identifies an operator function kind
    /// </summary>
    public interface IOperatorFuncKind : IFuncKind
    {

    }

    /// <summary>
    /// Characterizes an operator function kind with parametric arity A
    /// </summary>
    /// <typeparam name="A">The arity type</typeparam>
    public interface IOperatorFuncKind<A> : IOperatorFuncKind, IFuncArity<A> 
        where A : unmanaged, ITypeNat
    {

    }

    /// <summary>
    /// Characterizes a T-parametric operator function kind with parametric arity A
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    /// <typeparam name="A">The arity type</typeparam>
    public interface IOperatorFuncKind<A,T> : IOperatorFuncKind<A>, IOperatorFuncKind
        where A : unmanaged, ITypeNat
    {

    }
}