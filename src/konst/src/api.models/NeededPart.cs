//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct NeededPart
    {
        public static implicit operator Need<PartId>(NeededPart src)
            => src.Need;

        readonly ulong Data;

        [MethodImpl(Inline)]
        public NeededPart(PartId src, PartId dst)
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

        public Need<PartId> Need
        {
            [MethodImpl(Inline)]
            get => z.pair(Source, Target);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Need.Format();

        public override string ToString()
            => Format();
    }
}