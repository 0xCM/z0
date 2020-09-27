//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IBitLogicMachine<T>
        where T : struct, IBinaryBitLogic<T>
    {
        T Evaluate<K>(T a, K k = default)
            where K : unmanaged, IBitLogicKind;

        T Evaluate<K>(T a, T b, K k = default)
            where K : unmanaged, IBitLogicKind;

        T Evaluate<K>(T a, T b, T c, K k = default)
            where K : unmanaged, IBitLogicKind;
    }
}