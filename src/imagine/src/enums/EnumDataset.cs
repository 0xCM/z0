//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;

    public readonly struct EnumDataset
    {
        public MetadataToken Token {get;}

        public string Description {get;}

        public EnumScalarKind DataType {get;}
                
        public UserMetadata UserData {get;}

        public int EntryCount {get;}

        public MetadataToken[] Tokens {get;}
        
        public int[] Indices {get;}
        
        public string[] Names {get;}

        public Enum[] Literals {get;}

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
            => new EnumDatasetEntry(Tokens[i], Token, 
                    Indices[i], Names[i], Literals[i], Scalars[i], Descriptions[i], EntryData[i]);
                
        [MethodImpl(Inline)]
        public EnumDataset(MetadataToken token, string description, UserMetadata data,  EnumScalarKind type, MetadataToken[] tokens,  
            int[] indices, string[] names, Enum[] literals, variant[] scalars, string[] descriptions, UserMetadata[] entrydata)
        {
            Token = token;
            DataType = type;
            EntryCount = tokens.Length;            
            Description = description;
            UserData = data;
            Tokens = tokens;
            Indices = indices;
            Literals = literals;
            Scalars = scalars;
            Names = names;
            Descriptions = descriptions;
            EntryData = entrydata;
        }
    }
}
