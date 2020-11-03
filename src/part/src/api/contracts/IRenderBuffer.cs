//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    /// <summary>
    /// Characterizes a render buffer
    /// </summary>
    public interface IRenderBuffer
    {
        void Clear();
    }

    /// <summary>
    /// Characterizes an that produces accumulated content as T-cells
    /// </summary>
    /// <typeparam name="T">The emission target type</typeparam>
    public interface IRenderBuffer<T> : IRenderBuffer
    {
        T Emit(bool reset = true);
    }

    /// <summary>
    /// Characterizes an S-cell aggregator that produces accumulated S-cells as T-cells
    /// </summary>
    /// <typeparam name="S">The input source type</typeparam>
    /// <typeparam name="T">The emission target type</typeparam>
    public interface IRenderBuffer<S,T> : IRenderBuffer<T>
    {
        void Append(S src);

        void Append(params S[] src)
        {
            foreach(var item in src)
                Append(item);
        }
    }
}