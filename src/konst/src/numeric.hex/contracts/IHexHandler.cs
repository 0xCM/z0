//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IHexHandler
    {
        void OnHex(Hex8Seq src);
    }

    public interface IHexHandler<H> : IHexHandler
        where H :unmanaged, IHexType
    {
        void OnHex(H h);

        void IHexHandler.OnHex(Hex8Seq src)
            => OnHex(default);
    }

    public interface IHexMapper<T>
    {
        T Map(Hex8Seq src);
    }

    public interface IHexMapper<H,T> : IHexMapper<T>
        where H:unmanaged, IHexType
    {
        T Map(H src);

        T IHexMapper<T>.Map(Hex8Seq src)
            => Map(default);
    }
}