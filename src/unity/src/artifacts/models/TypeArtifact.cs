//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct TypeArtifact
    {
        readonly Type Subject;

        [MethodImpl(Inline)]
        public TypeArtifact(Type src)
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
    }
}