//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct Blit
    {
        [Free]
        public interface IBlock : IPrimitive
        {
            BlittableKind IPrimitive.TypeKind
                => BlittableKind.Block;
        }

        [Free]
        public interface IBlock<S> : IBlock, IPrimitive<S>
            where S : unmanaged, IDataBlock<S>
        {
            S Storage {get;}

            BitWidth IPrimitive.ContentWidth
                => core.width<S>();
        }
    }
}