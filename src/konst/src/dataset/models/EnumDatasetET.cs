//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    using static Konst;
    using static z;

    public readonly struct EnumDataset<E,T>
        where E : unmanaged, Enum
        where T : unmanaged
    {
        public ArtifactIdentifier Id {get;}

        public string Description {get;}

        public EnumScalarKind DataType {get;}

        public UserMetadata UserData {get;}

        public int EntryCount {get;}

        public ArtifactIdentifier[] Tokens {get;}

        public uint[] Indices {get;}

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
            => new EnumDatasetEntry<E,T>(Tokens[i], Id,
                    Indices[i], Names[i], Literals[i], Scalars[i], Descriptions[i], EntryData[i]);

        public EnumDataset(ArtifactIdentifier token, string description, UserMetadata data, EnumScalarKind type, EnumDatasetEntry<E,T>[] entries)
        {
            Id = token;
            DataType = type;
            Description = description;
            UserData = data;
            EntryCount = entries.Length;
            Tokens = sys.alloc<ArtifactIdentifier>(EntryCount);
            Indices = sys.alloc<uint>(EntryCount);
            Names = sys.alloc<string>(EntryCount);
            Literals = sys.alloc<E>(EntryCount);
            Scalars = sys.alloc<T>(EntryCount);
            Descriptions = sys.alloc<string>(EntryCount);
            EntryData = sys.alloc<UserMetadata>(EntryCount);

            for(var i=0; i<entries.Length; i++)
            {
                Tokens[i] = entries[i].Token;
                Indices[i] = entries[i].Position;
                Names[i] = entries[i].Name;
                Literals[i] = entries[i].Literal;
                Scalars[i] = entries[i].Scalar;
                Descriptions[i] = entries[i].Description;
                EntryData[i] = entries[i].UserData;
            }
        }

        [MethodImpl(Inline)]
        public EnumDataset(ArtifactIdentifier token, string description, UserMetadata data,  EnumScalarKind type, ArtifactIdentifier[] tokens,
            uint[] indices, string[] names, E[] literals, T[] scalars, string[] descriptions, UserMetadata[] entrydata)
        {
            Id = token;
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