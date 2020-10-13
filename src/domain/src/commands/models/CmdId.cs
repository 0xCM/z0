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

    public readonly struct CmdId : ITextual
    {
        [MethodImpl(Inline)]
        public static CmdId from(Type spec)
            => new CmdId(spec.Assembly.Id(), spec.MetadataToken);

        [MethodImpl(Inline)]
        public static CmdId from<T>()
            where T : struct
                => from(typeof(T));

        readonly ulong Data;

        [MethodImpl(Inline)]
        public CmdId(ulong src)
            => Data = src;

        [MethodImpl(Inline)]
        public CmdId(PartId part, ClrArtifactKey spec)
            => Data = (ulong)part | ((ulong)spec << 32);

        public PartId Part
        {
            [MethodImpl(Inline)]
            get => (PartId)Data;
        }

        public ClrArtifactKey Spec
        {
            [MethodImpl(Inline)]
            get => (ClrArtifactKey)Data >> 32;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Data != 0;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdId(Type spec)
            => from(spec);

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(RP.SlotDot2, Part.Format(), Spec.Format());

        public static CmdId Empty => default;

    }
}