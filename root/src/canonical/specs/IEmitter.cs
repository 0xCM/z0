//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.Intrinsics;

    /// <summary>
    /// Chracterizes an operation that produces a value that does not depend on arguments
    /// </summary>
    /// <typeparam name="A">The emission type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IEmitter<A> : IFunc<A>
    {
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IFixedEmitter : IFunc
    {
        NumericKind SegmentKind {get;}
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IFixedEmitter<F,T> : IEmitter<F>, IFixedEmitter
        where F : unmanaged, IFixed
        where T : unmanaged
    {
        FunctionClass IFunc.Class => FunctionClass.Emitter | FunctionClass.Fixed;

        NumericKind IFixedEmitter.SegmentKind => typeof(T).NumericKind();
    }


}