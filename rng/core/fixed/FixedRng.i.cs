//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static Root;

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