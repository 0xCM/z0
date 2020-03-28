//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using C = ArityClass;

    /// <summary>
    /// Classifies operations of arity 0
    /// </summary>
    public readonly struct A0 : ILiteral<A0,C>         
    { 
        public C Class => C.Nullary; 
    }

    /// <summary>
    /// Classifies operations of arity 0
    /// </summary>
    public readonly struct A1 : ILiteral<A1,C>
    { 
        public C Class => C.Unary; 
    }

    /// <summary>
    /// Classifies operations of arity 0
    /// </summary>
    public readonly struct A2 : ILiteral<A2,C>
    { 
        public C Class => C.Binary; 
    }

    /// <summary>
    /// Classifies operations of arity 0
    /// </summary>
    public readonly struct A3 : ILiteral<A3,C>
    { 
        public C Class => C.Ternary; 
    }    

    /// <summary>
    /// Classifies generic operations of arity 0
    /// </summary>
    public readonly struct A0<T> : ILiteral<A0<T>,C,T> 
        where T : unmanaged 
    {
        public C Class => C.Nullary; 
    }

    /// <summary>
    /// Classifies parametric operations of arity 1
    /// </summary>
    public readonly struct A1<T> : ILiteral<A1<T>,C,T> 
        where T : unmanaged 
    {
        public C Class => C.Unary; 
    }

    /// <summary>
    /// Classifies parametric operations of arity 2
    /// </summary>
    public readonly struct A2<T> : ILiteral<A2<T>,C,T> 
        where T : unmanaged 
    {
        public C Class => C.Binary; 
    }

    /// <summary>
    /// Classifies parametric operations of arity 3
    /// </summary>
    public readonly struct A3<T> : ILiteral<A3<T>,C,T> 
        where T : unmanaged 
    { 
        public C Class => C.Ternary; 
    }
}