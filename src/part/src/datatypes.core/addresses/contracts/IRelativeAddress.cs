//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IRelativeAdress : ITextual, INullity
    {
        uint Offset {get;}

        DataWidth Grain {get;}
    }

    public interface IRelativeAddress<T>: IRelativeAdress, INullary<T>, ITextual, INullity
        where T : unmanaged, IRelativeAddress<T>
    {

    }
}