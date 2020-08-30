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
        public ArtifactIdentifier Token {get;}

        public ArtifactIdentifier Declarer {get;}

        public uint Position {get;}

        public string Name {get;}

        public E Literal {get;}

        public T Scalar {get;}

        public string Description {get;}

        public UserMetadata UserData {get;}

        public static implicit operator EnumDatasetEntry(EnumDatasetEntry<E,T> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public EnumDatasetEntry(ArtifactIdentifier token, ArtifactIdentifier declarer,
            uint index, string identifier,  E literal, T numeric, string description, UserMetadata user)
        {
            Token = token;
            Declarer = declarer;
            Position = index;
            Name = identifier;
            Literal = literal;
            Scalar = numeric;
            Description = description;
            UserData = user;
        }

        public EnumDatasetEntry Untyped
        {
            [MethodImpl(Inline)]
            get => new EnumDatasetEntry(Token, Declarer, Position,Name,Variant.from(Scalar), Description, UserData);
        }
    }
}