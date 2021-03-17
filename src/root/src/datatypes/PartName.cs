//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct PartName : ITextual
    {
        public PartId Id {get;}

        [MethodImpl(Inline)]
        public PartName(PartId id)
        {
            Id = id;
        }

        public string Name
        {
            [MethodImpl(Inline)]
            get => Id.Format();
        }

        [MethodImpl(Inline)]
        public string Format()
            => Name;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator PartName(PartId id)
            => new PartName(id);

        [MethodImpl(Inline)]
        public static implicit operator PartId(PartName name)
            => name.Id;
    }
}