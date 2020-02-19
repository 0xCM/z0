//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Characterizes an element within a partition of a numeric field
    /// </summary>
    /// <typeparam name="T">The field type over which a partition is defined</typeparam>
    public interface INumericFieldSegment<T> : IFieldSegment<T>
        where T : unmanaged
    {

    }
}