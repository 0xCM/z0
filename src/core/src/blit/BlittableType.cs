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
        public readonly DataKind Kind;

        /// <summary>
        /// The physical bit width
        /// </summary>
        public readonly uint StorageWidth;

        /// <summary>
        /// The count of used bits
        /// </summary>
        public readonly uint ContentWidth;

        [MethodImpl(Inline)]
        public BlittableType(DataKind kind, uint storage, uint content)
        {
            Kind = kind;
            StorageWidth = storage;
            ContentWidth = content;
        }

        BitWidth IBlittable.ContentWidth
            => ContentWidth;

        BitWidth IBlittable.StorageWidth
            => StorageWidth;

        DataKind IBlittable.TypeKind
            => Kind;
    }
}