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
        public CliArtifactKey Token {get;}

        public byte[] Content {get;}

        [MethodImpl(Inline)]
        public UserMetadata(CliArtifactKey token, byte[] src)
        {
            Token = token;
            Content = src;
        }

        public static UserMetadata Empty
            => new UserMetadata(CliArtifactKey.Empty, Array.Empty<byte>());
    }
}