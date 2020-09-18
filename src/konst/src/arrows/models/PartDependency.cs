//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct PartDependency
    {
        public static implicit operator Arrow<PartId>(PartDependency src)
            => src.Need;

        readonly ulong Data;

        [MethodImpl(Inline)]
        public PartDependency(PartId src, PartId dst)
            => Data = (ulong)((uint)src) | (((ulong)(uint)dst) << 32);

        public PartId Source
        {
            [MethodImpl(Inline)]
            get => (PartId)((uint)Data);
        }

        public PartId Target
        {
            [MethodImpl(Inline)]
            get => (PartId)(Data >> 32);
        }

        public Arrow<PartId> Need
        {
            [MethodImpl(Inline)]
            get => pair(Source, Target);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Need.Format();

        public override string ToString()
            => Format();
    }
}