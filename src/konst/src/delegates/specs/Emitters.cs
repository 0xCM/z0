//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the canonical shape of an emitter
    /// </summary>
    /// <typeparam name="T">The production type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T Emitter<T>();

    /// <summary>
    /// Defines the canonical shape of an emitter
    /// </summary>
    /// <typeparam name="T">The production type</typeparam>
    /// <typeparam name="C">The cell type into which the production type is segmented</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T Emitter<T,C>();

    /// <summary>
    /// Characterizes a function that produces a stream of values
    /// </summary>
    /// <param name="count">If specified, the number of elements to produce</param>
    /// <typeparam name="T">The emission type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate IEnumerable<T> StreamEmitter<T>();

    /// <summary>
    /// Characterizes a function that produces a stream of values
    /// </summary>
    /// <param name="count">If specified, the number of elements to produce</param>
    /// <typeparam name="T">The emission type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate IEnumerable<T> ValueStreamEmitter<T>()
        where T : struct;


    [SuppressUnmanagedCodeSecurity]
    public delegate bit Emitter1();

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell8 Emitter8();

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell16 Emitter16();

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell32 Emitter32();

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell64 Emitter64();

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell128 Emitter128();

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell256 Emitter256();

    [SuppressUnmanagedCodeSecurity]
    public delegate Cell512 Emitter512();
}