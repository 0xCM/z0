//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IHashFunction<S,T>
        where T : unmanaged
    {
        T Compute(in S src);
    }
}