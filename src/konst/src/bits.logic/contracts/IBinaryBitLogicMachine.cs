//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IBinaryBitLogicMachine<T>
        where T : unmanaged
    {
        T Evaluate<K>(T a, T b, K k = default)
            where K : unmanaged, IBitLogicKind;

        T Evaluate(T a, T b, BinaryBitLogicKind kind);
    }

    [Free]
    public interface IBinaryBitLogicMachine<H,T> : IBinaryBitLogicMachine<T>
        where H : struct, IBinaryBitLogicMachine<H,T>
        where T : unmanaged
    {

    }

    [Free]
    public interface IBinaryBitLogicMachine<H,W,T> : IBinaryBitLogicMachine<H,T>
        where H : struct, IBinaryBitLogicMachine<H,W,T>
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {

    }
}