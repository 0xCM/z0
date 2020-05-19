//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    public interface IBank<F,W,N> : ISized<W>
        where F : struct
        where W : unmanaged, ITypeWidth
        where N : unmanaged, ITypeNat
    {

    }

}