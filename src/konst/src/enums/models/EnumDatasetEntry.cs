//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct EnumDatasetEntry
    {
        public ArtifactIdentity Id {get;}

        public ArtifactIdentity Declarer {get;}
        
        public uint Index {get;}

        public string Name {get;}

        public variant Scalar {get;}

        public string Description {get;}

        public UserMetadata UserData {get;}

        [MethodImpl(Inline)]
        public EnumDatasetEntry(ArtifactIdentity token, ArtifactIdentity declarer, 
            uint index, string identifier,  variant scalar, string description, UserMetadata user)
        {
            Id = token;
            Declarer = declarer;
            Index = index;
            Name = identifier;
            Scalar = scalar;
            Description = description;
            UserData = user;
        }    
    }
}