//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Blit
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IPrimitive
    {
        BitWidth ContentWidth {get;}

        BitWidth StorageWidth {get;}

        TypeKind TypeKind {get;}
    }

    [Free]
    public interface IPrimitive<S> : IPrimitive
        where S : unmanaged
    {
        BitWidth IPrimitive.StorageWidth
            => core.width<S>();
    }
}