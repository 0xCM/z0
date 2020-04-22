//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Vectors;


    public interface ISVTernaryOpMatch256D<T> : ICheckSF
        where T : unmanaged
    {
        void CheckMatch<F>(F f)
            where F : ISVTernaryOp256DApi<T>;
    }
}