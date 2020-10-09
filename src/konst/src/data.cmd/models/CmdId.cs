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
        public static CmdId from(Type handler)
            => new CmdId(handler.Assembly.Id(), handler.MetadataToken);

        readonly ulong Data;

        [MethodImpl(Inline)]
        public CmdId(ulong src)
            => Data = src;

        [MethodImpl(Inline)]
        public CmdId(PartId part, ClrArtifactKey handler)
            => Data = (ulong)part | ((ulong)handler << 32);

        public PartId Part
        {
            [MethodImpl(Inline)]
            get => (PartId)Data;
        }

        public ClrArtifactKey Handler
        {
            [MethodImpl(Inline)]
            get => (ClrArtifactKey)Data >> 32;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(RP.SlotDot2, Part.Format(), Handler.Format());
    }
}