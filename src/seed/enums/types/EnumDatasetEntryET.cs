//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct EnumDatasetEntry<E,T>
        where E : unmanaged, Enum
        where T : unmanaged
    {
        public MetadataToken Token {get;}

        public MetadataToken Declarer {get;}
        
        public int Index {get;}

        public string Name {get;}

        public E Literal {get;}

        public T Scalar {get;}

        public string Description {get;}

        public UserMetadata UserData {get;}

        public static implicit operator EnumDatasetEntry(EnumDatasetEntry<E,T> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public EnumDatasetEntry(MetadataToken token, MetadataToken declarer, 
            int index, string identifier,  E literal, T numeric, string description, UserMetadata user)
        {
            Token = token;
            Declarer = declarer;
            Index = index;
            Name = identifier;
            Literal = literal;
            Scalar = numeric;
            Description = description;
            UserData = user;
        }    

        public EnumDatasetEntry Untyped
        {
            [MethodImpl(Inline)]
            get => new EnumDatasetEntry(Token, Declarer, Index,Name, Literal, Variant.from(Scalar), Description, UserData);
        }
    }
}