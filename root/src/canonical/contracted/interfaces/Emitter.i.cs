//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using static Root;

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
    public interface IFixedEmitter<F> : IFixedEmitter, IEmitter<F>
        where F : unmanaged, IFixed
    {
        NumericKind IFixedEmitter.SegmentKind 
            => typeof(F).NumericKind();
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IFixedEmitter<F,T> : IEmitter<F>, IFixedEmitter
        where F : unmanaged, IFixed
        where T : unmanaged
    {
        FunctionClass IFunc.Class => FunctionClass.Emitter | FunctionClass.Fixed;

        NumericKind IFixedEmitter.SegmentKind => typeof(T).NumericKind();
    }    

    /// <summary>
    /// Characterizes an emitter that shoots out spans
    /// </summary>
    /// <typeparam name="T">The span element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISpanEmitter<T> : ISpanFunc
    {
        Span<T> Invoke();

        FunctionClass IFunc.Class => FunctionClass.Emitter;

    }

    /// <summary>
    /// Characterizes an emitter that shoots out fixed spans
    /// </summary>
    /// <typeparam name="F">The fixed span element type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IFixedSpanEmitter<F> : ISpanFunc
        where F : unmanaged, IFixed
    {
        Span<F> Invoke();

        NumericKind SegmentKind 
            => typeof(F).NumericKind();

        FunctionClass IFunc.Class => FunctionClass.Emitter | FunctionClass.Fixed;
    }

    /// <summary>
    /// Characterizes an emitter that shoots out fixed F-celled spans over T-segments
    /// </summary>
    /// <typeparam name="F">The fixed span cell type</typeparam>
    /// <typeparam name="T">The cell segment type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IFixedSpanEmitter<F,T> : ISpanFunc, IFixedWidth
        where F : unmanaged, IFixed
        where T : unmanaged
   {
        Span<F> Invoke();

        FixedWidth IFixedWidth.FixedWidth => (FixedWidth)bitsize<F>();

        NumericKind SegmentKind => typeof(T).NumericKind();

        FunctionClass IFunc.Class => FunctionClass.Emitter | FunctionClass.Fixed;
    }

}