//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ICheckUnarySF256D<T> : ICheckSF
        where T : unmanaged
    {
        void CheckMatch<F>(F f)
            where F : ISVUnaryOp256DApi<T>;
    }
}