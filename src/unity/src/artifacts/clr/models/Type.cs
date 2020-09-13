//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Konst;

    using S = System;

    partial struct ClrArtifacts
    {
        public readonly struct Type : IClrArtifact<Type,S.Type>
        {
            readonly S.Type Subject;

            [MethodImpl(Inline)]
            public static implicit operator Type(S.Type src)
                => new Type(src);

            [MethodImpl(Inline)]
            public static implicit operator S.Type(Type src)
                => src.Subject;

            [MethodImpl(Inline)]
            public Type(S.Type src)
                => Subject = src;

            public string Name
            {
                [MethodImpl(Inline)]
                get => Subject.Name;
            }

            public ArtifactIdentifier Id
            {
                [MethodImpl(Inline)]
                get => Subject.MetadataToken;
            }

            S.Type IClrArtifact<S.Type>.Subject
            {
                get => Subject;
            }
        }
    }
}