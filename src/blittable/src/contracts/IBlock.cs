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
        public interface IBlock : IBlittable
        {
            BlittableKind IBlittable.TypeKind
                => BlittableKind.Block;
        }

        [Free]
        public interface IBlock<S> : IBlock, IBlittable<S>
            where S : unmanaged, IDataBlock<S>
        {
            S Storage {get;}

            BitWidth IBlittable.ContentWidth
                => core.width<S>();
        }
    }
}