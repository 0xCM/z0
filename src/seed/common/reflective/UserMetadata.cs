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
        public static UserMetadata Empty => new UserMetadata(MetadataToken.Empty, Control.array<byte>());

        public MetadataToken Token {get;}
        
        public byte[] Content {get;}

        [MethodImpl(Inline)]
        public UserMetadata(MetadataToken token, byte[] src)
        {
            Token = token;
            Content = src;
        }        
    }
}