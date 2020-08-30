//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct UserMetadata
    {
        public ArtifactIdentifier Token {get;}

        public byte[] Content {get;}

        [MethodImpl(Inline)]
        public UserMetadata(ArtifactIdentifier token, byte[] src)
        {
            Token = token;
            Content = src;
        }

        public static UserMetadata Empty
            => new UserMetadata(ArtifactIdentifier.Empty, Array.Empty<byte>());
    }
}