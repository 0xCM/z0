//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    public readonly struct KindIdentity : IModelIdentity<KindIdentity>
    {
        [MethodImpl(Inline)]
        public static implicit operator KindIdentity(in Pair<ArtifactIdentifier> src)
            => new KindIdentity(src);

        [MethodImpl(Inline)]
        public KindIdentity(in Pair<ArtifactIdentifier> src)
            => Components = (ulong)src.Left | ((ulong)src.Right << 32);

        readonly ulong Components;

        public ArtifactIdentifier Host
        {
            [MethodImpl(Inline)]
            get => (uint)Components;
        }

        public ArtifactIdentifier Kind
        {
            [MethodImpl(Inline)]
            get => (uint)(Components >> 32);
        }

        public BinaryCode Identifier
        {
            [MethodImpl(Inline)]
            get => bytes(Components);
        }
    }

    public readonly struct DirectiveIdentity : IModelIdentity<DirectiveIdentity>
    {
        readonly Vector128<uint> Components;

        [MethodImpl(Inline)]
        public static implicit operator DirectiveIdentity(in ConstQuad<ArtifactIdentifier> src)
            => new DirectiveIdentity(src);

        [MethodImpl(Inline)]
        public DirectiveIdentity(in ConstQuad<ArtifactIdentifier> src)
            => Components = vparts(n128,(uint)src.First, (uint)src.Second, (uint)src.Third, (uint)src.Fourth);

        public ArtifactIdentifier Kind
        {
            [MethodImpl(Inline)]
            get => vcell(Components,0);
        }

        public ArtifactIdentifier Command
        {
            [MethodImpl(Inline)]
            get => vcell(Components,1);
        }

        public ArtifactIdentifier Response
        {
            [MethodImpl(Inline)]
            get => vcell(Components,2);
        }

        public ArtifactIdentifier Host
        {
            [MethodImpl(Inline)]
            get => vcell(Components,3);
        }

        public BinaryCode Identifier
        {
            [MethodImpl(Inline)]
            get => bytes(Components);
        }
    }

    public readonly struct ActorIdentity: IModelIdentity<ActorIdentity>
    {
        [MethodImpl(Inline)]
        public static implicit operator ActorIdentity(in ConstQuad<ArtifactIdentifier> src)
            => new ActorIdentity(src);

        [MethodImpl(Inline)]
        public ActorIdentity(in ConstQuad<ArtifactIdentifier> src)
            => Components = vparts(n128,(uint)src.First, (uint)src.Second, (uint)src.Third, (uint)src.Fourth);

        readonly Vector128<uint> Components;

        public ArtifactIdentifier Kind
        {
            [MethodImpl(Inline)]
            get => vcell(Components,0);
        }

        public ArtifactIdentifier Command
        {
            [MethodImpl(Inline)]
            get => vcell(Components,1);
        }

        public ArtifactIdentifier Response
        {
            [MethodImpl(Inline)]
            get => vcell(Components,2);
        }

        public ArtifactIdentifier Host
        {
            [MethodImpl(Inline)]
            get => vcell(Components,3);
        }

        public BinaryCode Identifier
        {
            [MethodImpl(Inline)]
            get => bytes(Components);
        }
    }
}