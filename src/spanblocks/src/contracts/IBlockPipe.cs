//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IBlockPipe<W,S,T>
        where W : unmanaged, ITypeWidth
        where S : unmanaged
        where T : unmanaged
    {

    }

    [Free]
    public interface IBlockPipe128<S,T> : IBlockPipe<W128,S,T>, IBlockSource128<S>, IBlockSink128<T>
        where S : unmanaged
        where T : unmanaged
    {

    }

    [Free]
    public interface IBlockPipe256<S,T> : IBlockPipe<W256,S,T>, IBlockSource256<S>, IBlockSink256<T>
        where S : unmanaged
        where T : unmanaged
    {

    }

    [Free]
    public interface IBlockPipe512<S,T> : IBlockPipe<W512,S,T>, IBlockSource512<S>, IBlockSink512<T>
        where S : unmanaged
        where T : unmanaged
    {

    }
}