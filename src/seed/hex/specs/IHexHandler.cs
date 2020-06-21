//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    public interface IHexHandler
    {
        void OnHex(HexKind src);
    }

    public interface IHexHandler<H> : IHexHandler
        where H :unmanaged, IHexCode
    {
        void OnHex(H h);

        void IHexHandler.OnHex(HexKind src)
            => OnHex(default);
    }

    public interface IHexMapper<T>
    {
        T Map(HexKind src);
    }

    public interface IHexMapper<H,T> : IHexMapper<T>
        where H :unmanaged, IHexCode
    {
        T Map(H src);

        T IHexMapper<T>.Map(HexKind src)
            => Map(default);
    }
}