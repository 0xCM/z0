//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using R = System.Reflection;
    using S = System;

    partial struct ClrArtifacts
    {
        public readonly struct Field : IClrArtifact<Field>
        {
            readonly R.FieldInfo Subject;

            [MethodImpl(Inline)]
            public Field(R.FieldInfo src)
                => Subject = src;

            [MethodImpl(Inline)]
            public static implicit operator Field(R.FieldInfo src)
                => new Field(src);

            [MethodImpl(Inline)]
            public static implicit operator R.FieldInfo(Field src)
                => src.Subject;

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

            public ClrArtifactKind Kind
            {
                [MethodImpl(Inline)]
                get => ClrArtifactKind.Field;
            }

            public R.FieldAttributes Attributes
            {
                [MethodImpl(Inline)]
                get => Subject.Attributes;
            }

            public Type FieldType
            {
                [MethodImpl(Inline)]
                get => Subject.FieldType;
            }


            public Type DeclaringType
            {
                [MethodImpl(Inline)]
                get => Subject.DeclaringType;
            }

            public MemoryAddress Address
            {
                [MethodImpl(Inline)]
                get => Subject.FieldHandle.Value;
            }

        }
    }
}