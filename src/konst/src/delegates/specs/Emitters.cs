//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Collections.Generic;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Defines the canonical shape of an emitter
    /// </summary>
    /// <typeparam name="T">The production type</typeparam>
    [Free]
    public delegate T Emitter<T>();

    /// <summary>
    /// Defines the canonical shape of an emitter
    /// </summary>
    /// <typeparam name="T">The production type</typeparam>
    /// <typeparam name="C">The cell type into which the production type is segmented</typeparam>
    [Free]
    public delegate T Emitter<T,C>();

    /// <summary>
    /// Characterizes a function that produces a stream of values
    /// </summary>
    /// <param name="count">If specified, the number of elements to produce</param>
    /// <typeparam name="T">The emission type</typeparam>
    [Free]
    public delegate IEnumerable<T> StreamEmitter<T>();

    /// <summary>
    /// Characterizes a function that produces a stream of values
    /// </summary>
    /// <param name="count">If specified, the number of elements to produce</param>
    /// <typeparam name="T">The emission type</typeparam>
    [Free]
    public delegate IEnumerable<T> ValueStreamEmitter<T>()
        where T : struct;


    [Free]
    public delegate bit Emitter1();

    [Free]
    public delegate Cell8 Emitter8();

    [Free]
    public delegate Cell16 Emitter16();

    [Free]
    public delegate Cell32 Emitter32();

    [Free]
    public delegate Cell64 Emitter64();

    [Free]
    public delegate Cell128 Emitter128();

    [Free]
    public delegate Cell256 Emitter256();

    [Free]
    public delegate Cell512 Emitter512();
}