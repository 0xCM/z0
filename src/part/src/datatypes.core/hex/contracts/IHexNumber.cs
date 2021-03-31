//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IHexNumber : IByte
    {

    }

    public interface IHexNumber<K> : IHexNumber
        where K : unmanaged
    {
        new K Value {get;}

        byte IByte.Value
            => (byte)(object)Value;
    }

    public interface IHexNumber<F,K> : IHexNumber<K>, IByte<F>
        where F : unmanaged, IHexNumber<F,K>
        where K : unmanaged
    {

    }

    public interface IHexNumber<F,W,K> : IHexNumber<F,K>, IDataTypeComparable<F>
        where F : unmanaged, IHexNumber<F,W,K>
        where K : unmanaged
        where W : unmanaged, IDataWidth
    {
        BitWidth ISized.Width
            => default(W).BitWidth;
    }
}