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


    using R = System.Reflection;

    partial struct ClrViews
    {
        public readonly struct FieldView : IClrArtifact<FieldView>
        {
            readonly FieldInfo Subject;

            [MethodImpl(Inline)]
            public FieldView(FieldInfo src)
                => Subject = src;

            [MethodImpl(Inline)]
            public static implicit operator FieldView(FieldInfo src)
                => new FieldView(src);

            [MethodImpl(Inline)]
            public static implicit operator FieldInfo(FieldView src)
                => src.Subject;

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
                get => ClrArtifactKind.Field;
            }

            public R.FieldAttributes Attributes
            {
                [MethodImpl(Inline)]
                get => Subject.Attributes;
            }

            public TypeView FieldType
            {
                [MethodImpl(Inline)]
                get => Subject.FieldType;
            }

            public TypeView DeclaringType
            {
                [MethodImpl(Inline)]
                get => Subject.DeclaringType;
            }

            public MemoryAddress Address
            {
                [MethodImpl(Inline)]
                get => Subject.FieldHandle.Value;
            }

            public bool IsStatic
            {
                [MethodImpl(Inline)]
                get => Subject.IsStatic;
            }
        }
    }
}