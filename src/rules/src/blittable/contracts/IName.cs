//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.BZ
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IName : IPrimitive
    {
        BlittableKind IPrimitive.TypeKind
            => BlittableKind.Name;
    }

    [Free]
    public interface IName<T> : IName
        where T : unmanaged
    {

    }

    public interface IName<F,T> : IName<T>
        where T : unmanaged
        where F : unmanaged, IName<F,T>
    {
        uint Length {get;}

        byte PointSize {get;}

        BitWidth IPrimitive.StorageWidth
            => core.width<F>();

        BitWidth IPrimitive.ContentWidth
            => Length*PointSize;
    }
}