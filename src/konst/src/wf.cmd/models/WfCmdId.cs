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

    public readonly struct WfCmdId
    {
        [MethodImpl(Inline)]
        public static WfCmdId from(Type handler)
            => new WfCmdId(handler.Assembly.Id(), handler.MetadataToken);

        readonly ulong Data;

        [MethodImpl(Inline)]
        public WfCmdId(ulong src)
            => Data = src;

        [MethodImpl(Inline)]
        public WfCmdId(PartId part, ClrArtifactKey handler)
            => Data = (ulong)part | ((ulong)handler << 32);

        public PartId Part
            => (PartId)Data;

        public ClrArtifactKey Handler
            => (ClrArtifactKey)Data >> 32;
    }
}