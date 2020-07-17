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

    public readonly struct EnumDataset
    {
        public ArtifactIdentity Id {get;}

        public string Description {get;}

        public EnumScalarKind DataType {get;}
                
        public UserMetadata UserData {get;}

        public int EntryCount {get;}

        public ArtifactIdentity[] Tokens {get;}
        
        public uint[] Indices {get;}
        
        public string[] Names {get;}

        public variant[] Scalars {get;}

        public string[] Descriptions {get;}

        public UserMetadata[] EntryData {get;}

        public EnumDatasetEntry this[int i]
        {
            [MethodImpl(Inline)]
            get => Entry(i);
        }

        [MethodImpl(Inline)]
        public EnumDatasetEntry Entry(int i)
            => new EnumDatasetEntry(Tokens[i], Id, 
                    Indices[i], Names[i], Scalars[i], Descriptions[i], EntryData[i]);
                
        [MethodImpl(Inline)]
        public EnumDataset(ArtifactIdentity token, string description, UserMetadata data,  EnumScalarKind type, ArtifactIdentity[] tokens,  
            uint[] indices, string[] names, variant[] scalars, string[] descriptions, UserMetadata[] entrydata)
        {
            Id = token;
            DataType = type;
            EntryCount = tokens.Length;            
            Description = description;
            UserData = data;
            Tokens = tokens;
            Indices = indices;
            Scalars = scalars;
            Names = names;
            Descriptions = descriptions;
            EntryData = entrydata;
        }
    }
}
