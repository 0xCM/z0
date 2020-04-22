//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ICheckBinarySF128D<T> : ICheckSF
        where T : unmanaged
    {
        void CheckMatch<F>(F f)
            where F : ISVBinaryOp128DApi<T>;
    }
}