//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IBlittable
    {
        BitWidth ContentWidth {get;}

        BitWidth StorageWidth {get;}

        BlittableKind TypeKind {get;}
    }

    [Free]
    public interface IBlittable<S> : IBlittable
        where S : unmanaged
    {
        BitWidth IBlittable.StorageWidth
            => core.width<S>();
    }
}