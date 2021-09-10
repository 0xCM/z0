//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct BitFlow
    {
        [Free]
        public interface IPrimitive
        {
            BitWidth ContentWidth {get;}

            BitWidth StorageWidth {get;}

            BlittableKind TypeKind {get;}
        }

        [Free]
        public interface IPrimitive<S> : IPrimitive
            where S : unmanaged
        {
            BitWidth IPrimitive.StorageWidth
                => core.width<S>();
        }
    }
}