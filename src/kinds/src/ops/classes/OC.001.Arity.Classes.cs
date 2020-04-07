//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using K = ArityClass;

    /// <summary>
    /// Classifies operations of arity 0
    /// </summary>
    public readonly struct A0 : ILiteralKind<A0,K>         
    { 
        public K Class => K.Nullary; 
    }

    /// <summary>
    /// Classifies operations of arity 0
    /// </summary>
    public readonly struct A1 : ILiteralKind<A1,K>
    { 
        public K Class => K.Unary; 
    }

    /// <summary>
    /// Classifies operations of arity 0
    /// </summary>
    public readonly struct A2 : ILiteralKind<A2,K>
    { 
        public K Class => K.Binary; 
    }

    /// <summary>
    /// Classifies operations of arity 0
    /// </summary>
    public readonly struct A3 : ILiteralKind<A3,K>
    { 
        public K Class => K.Ternary; 
    }    

    /// <summary>
    /// Classifies generic operations of arity 0
    /// </summary>
    public readonly struct A0<T> : ILiteralType<A0<T>,K,T> 
        where T : unmanaged 
    {
        public K Class => K.Nullary; 
    }

    /// <summary>
    /// Classifies parametric operations of arity 1
    /// </summary>
    public readonly struct A1<T> : ILiteralType<A1<T>,K,T> 
        where T : unmanaged 
    {
        public K Class => K.Unary; 
    }

    /// <summary>
    /// Classifies parametric operations of arity 2
    /// </summary>
    public readonly struct A2<T> : ILiteralType<A2<T>,K,T> 
        where T : unmanaged 
    {
        public K Class => K.Binary; 
    }

    /// <summary>
    /// Classifies parametric operations of arity 3
    /// </summary>
    public readonly struct A3<T> : ILiteralType<A3<T>,K,T> 
        where T : unmanaged 
    { 
        public K Class => K.Ternary; 
    }
}