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
        public MetadataToken Token {get;}

        public MetadataToken Declarer {get;}
        
        public int Index {get;}

        public string Name {get;}

        public Enum Literal {get;}

        public variant Scalar {get;}

        public string Description {get;}

        public UserMetadata UserData {get;}

        [MethodImpl(Inline)]
        public EnumDatasetEntry(MetadataToken token, MetadataToken declarer, 
            int index, string identifier,  Enum literal, variant scalar, string description, UserMetadata user)
        {
            Token = token;
            Declarer = declarer;
            Index = index;
            Name = identifier;
            Literal = literal;
            Scalar = scalar;
            Description = description;
            UserData = user;
        }    
    }
}