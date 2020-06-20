//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Konst;
    using static Control;

    public readonly struct EnumDataset<E,T>
    {
        public MetadataToken Token {get;}

        public string Description {get;}

        public EnumScalarKind DataType {get;}
                
        public UserMetadata UserData {get;}

        public int EntryCount {get;}

        public MetadataToken[] Tokens {get;}
        
        public int[] Indices {get;}
        
        public string[] Names {get;}

        public E[] Literals {get;}

        public T[] Scalars {get;}

        public string[] Descriptions {get;}

        public UserMetadata[] EntryData {get;}

        public EnumDatasetEntry<E,T> this[int i]
        {
            [MethodImpl(Inline)]
            get => Entry(i);
        }

        [MethodImpl(Inline)]
        public EnumDatasetEntry<E,T> Entry(int i)
            => new EnumDatasetEntry<E,T>(Tokens[i], Token, 
                    Indices[i], Names[i], Literals[i], Scalars[i], Descriptions[i], EntryData[i]);

        public EnumDataset(MetadataToken token, string description, UserMetadata data, EnumScalarKind type, EnumDatasetEntry<E,T>[] entries)
        {
            Token = token;
            DataType = type;
            Description = description;
            UserData = data;
            EntryCount = entries.Length;
            Tokens = alloc<MetadataToken>(EntryCount);
            Indices = alloc<int>(EntryCount);
            Names = alloc<string>(EntryCount);
            Literals = alloc<E>(EntryCount);
            Scalars = alloc<T>(EntryCount);
            Descriptions = alloc<string>(EntryCount);
            EntryData = alloc<UserMetadata>(EntryCount);

            for(var i=0; i<entries.Length; i++)
            {
                Tokens[i] = entries[i].Token;                                
                Indices[i] = entries[i].Index;
                Names[i] = entries[i].Name;
                Literals[i] = entries[i].Literal;
                Scalars[i] = entries[i].Scalar;
                Descriptions[i] = entries[i].Description;
                EntryData[i] = entries[i].UserData;
            }
        }
                
        [MethodImpl(Inline)]
        public EnumDataset(MetadataToken token, string description, UserMetadata data,  EnumScalarKind type, MetadataToken[] tokens,  
            int[] indices, string[] names, E[] literals, T[] scalars, string[] descriptions, UserMetadata[] entrydata)
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