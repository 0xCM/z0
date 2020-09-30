//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    /// <summary>
    /// Characterizes a device that accepts S-cells and emits a T-cell that represents the S-cell aggregate
    /// </summary>
    /// <typeparam name="S"></typeparam>
    /// <typeparam name="T"></typeparam>
    public interface IBuffered<S,T>
    {
        T Emit(bool reset = true);

        void Append(S src);

        void Clear();

        void Append(params S[] src)
            => iter(src, Append);
    }
}