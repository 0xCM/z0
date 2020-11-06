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

    public readonly struct CliIdentityVector
    {
        readonly Vector128<uint> Components;

        [MethodImpl(Inline)]
        public static implicit operator CliIdentityVector(in ConstQuad<ClrArtifactKey> src)
            => new CliIdentityVector(src);

        [MethodImpl(Inline)]
        public CliIdentityVector(in ConstQuad<ClrArtifactKey> src)
            => Components = vparts(n128,(uint)src.First, (uint)src.Second, (uint)src.Third, (uint)src.Fourth);

        public ClrArtifactKey Kind
        {
            [MethodImpl(Inline)]
            get => vcell(Components,0);
        }

        public ClrArtifactKey Command
        {
            [MethodImpl(Inline)]
            get => vcell(Components,1);
        }

        public ClrArtifactKey Response
        {
            [MethodImpl(Inline)]
            get => vcell(Components,2);
        }

        public ClrArtifactKey Host
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

    public readonly struct ActorIdentity
    {
        [MethodImpl(Inline)]
        public static implicit operator ActorIdentity(in ConstQuad<ClrArtifactKey> src)
            => new ActorIdentity(src);

        [MethodImpl(Inline)]
        public ActorIdentity(in ConstQuad<ClrArtifactKey> src)
            => Components = vparts(n128,(uint)src.First, (uint)src.Second, (uint)src.Third, (uint)src.Fourth);

        readonly Vector128<uint> Components;

        public ClrArtifactKey Kind
        {
            [MethodImpl(Inline)]
            get => vcell(Components,0);
        }

        public ClrArtifactKey Command
        {
            [MethodImpl(Inline)]
            get => vcell(Components,1);
        }

        public ClrArtifactKey Response
        {
            [MethodImpl(Inline)]
            get => vcell(Components,2);
        }

        public ClrArtifactKey Host
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