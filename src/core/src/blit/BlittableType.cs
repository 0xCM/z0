//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct BlittableType : IBlittable
    {
        public DataKind TypeKind {get;}

        /// <summary>
        /// The physical bit width
        /// </summary>
        public uint StorageWidth {get;}

        /// <summary>
        /// The count of used bits
        /// </summary>
        public uint ContentWidth {get;}

        [MethodImpl(Inline)]
        public BlittableType(DataKind kind, uint storage, uint content)
        {
            TypeKind = kind;
            StorageWidth = storage;
            ContentWidth = content;
        }

        BitWidth IBlittable.ContentWidth
            => ContentWidth;

        BitWidth IBlittable.StorageWidth
            => StorageWidth;

        DataKind IBlittable.TypeKind
            => TypeKind;
    }
}