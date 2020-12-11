//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a render buffer
    /// </summary>
    [Free]
    public interface IRenderBuffer
    {
        void Clear();
    }

    /// <summary>
    /// Characterizes an that produces accumulated content as T-cells
    /// </summary>
    /// <typeparam name="T">The emission target type</typeparam>
    [Free]
    public interface IRenderBuffer<T> : IRenderBuffer
    {
        T Emit(bool reset = true);
    }

    /// <summary>
    /// Characterizes an S-cell aggregator that produces accumulated S-cells as T-cells
    /// </summary>
    /// <typeparam name="S">The input source type</typeparam>
    /// <typeparam name="T">The emission target type</typeparam>
    [Free]
    public interface IRenderBuffer<S,T> : IRenderBuffer<T>
    {
        void Append(S src);

        void Append(params S[] src)
        {
            foreach(var item in src)
                Append(item);
        }
    }

    /// <summary>
    /// Characterizes an S-cell aggregator that produces accumulated S-cells as T-cells
    /// </summary>
    /// <typeparam name="S">The input source type</typeparam>
    /// <typeparam name="T">The emission target type</typeparam>
    [Free]
    public interface IRenderBuffer<H,S,T> : IRenderBuffer<S,T>, IService<H,IRenderBuffer<S,T>,S,T>
        where H : IRenderBuffer<H,S,T>
    {

    }
}