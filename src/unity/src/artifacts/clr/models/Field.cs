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
        public readonly struct Field : IClrArtifact<Field,R.FieldInfo>
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

            public MemoryAddress Address
            {
                [MethodImpl(Inline)]
                get => Subject.FieldHandle.Value;
            }

            R.FieldInfo IClrArtifact<R.FieldInfo>.Subject
                => Subject;
        }
    }
}