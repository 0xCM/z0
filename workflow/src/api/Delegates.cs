//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static zfunc;

    public delegate void ObjectReceiver<T>(in T src)
        where T : class;

    /// <summary>
    /// Characterizes a function that receives/emits an object without modification
    /// </summary>
    /// <param name="src">The source object</param>
    /// <typeparam name="T">The object type</typeparam>
    public delegate ref readonly T ObjectRelay<T>(in T src)
        where T : class;

    /// <summary>
    /// Characterizes a function that produces T-objects from S-objects
    /// </summary>
    /// <param name="src">The source object</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    public delegate T ObjectTransformer<S,T>(in S src)
        where S : class        
        where T : class;

    /// <summary>
    /// Characterizes a function that produces T-values from S-values
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    public delegate T ValueTransformer<S,T>(in S src)
        where S : struct        
        where T : struct;

    /// <summary>
    /// Characterizes a function that emits a value identical to that which was received
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The value type</typeparam>
    public delegate ref readonly T ValueRelay<T>(in T src)
        where T : struct;

    /// <summary>
    /// Characterizes a function that emits a potentially modified receipt value
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The value type</typeparam>
    public delegate ref T ValueEditor<T>(ref T src)
        where T : struct;

    public delegate void SpanReceiver<T>(Span<T> src);

    public delegate void StreamReceiver<T>(IEnumerable<T> src);

    public delegate void PointReceiver<T>(in T src);

    public delegate void PointReceiver<A,B>(in A a, in B b);

    public delegate void PointReceiver<A,B,C>(in A a, in B b, in C c);

    /// <summary>
    /// Characterizes a function that produces a stream of values
    /// </summary>
    /// <typeparam name="T">The emission type</typeparam>
    public delegate IEnumerable<T> ValueEmitter<T>()
        where T : struct;    

}