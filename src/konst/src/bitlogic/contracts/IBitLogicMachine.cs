//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IUnaryBitLogicMachine<H,T>
        where H : struct, IUnaryBitLogicMachine<H,T>
        where T : unmanaged
    {
        T Evaluate<K>(T a, K k = default)
            where K : unmanaged, IBitLogicKind;
    }

    [Free]
    public interface ITernaryBitLogicMachine<H,T>
        where H : struct, ITernaryBitLogicMachine<H,T>
        where T : unmanaged
    {
        T Evaluate<K>(T a, T b, T c, K k = default)
            where K : unmanaged, IBitLogicKind;
    }
}