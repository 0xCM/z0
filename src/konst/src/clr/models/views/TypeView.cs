//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Konst;

    using S = System;

    partial struct ClrViews
    {
        public readonly struct TypeView : IClrArtifact<TypeView>
        {
            readonly S.Type Subject;

            [MethodImpl(Inline)]
            public static implicit operator TypeView(S.Type src)
                => new TypeView(src);

            [MethodImpl(Inline)]
            public static implicit operator S.Type(TypeView src)
                => src.Subject;

            [MethodImpl(Inline)]
            public TypeView(S.Type src)
                => Subject = src;

            public string Name
            {
                [MethodImpl(Inline)]
                get => Subject.Name;
            }

            public CliArtifactKey Key
            {
                [MethodImpl(Inline)]
                get => Subject.MetadataToken;
            }

            public ClrArtifactKind Kind
            {
                [MethodImpl(Inline)]
                get => ClrArtifactKind.Type;
            }
        }
    }
}