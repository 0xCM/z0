//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Konst;
    using static ReflectedClass;

    using K = ReflectedKind;

    public readonly partial struct ReflectedKinds
    {
        public AssemblyKind Assembly => default;

        public ModuleKind Module => default;

        public MethodKind Method => default;

        public TypeKind Type => default;

        public EnumKind Enum => default;

        public EnumLiteralKind EnumLiteral => default;

        public FieldKind Field => default;

        public PropertyKind Property => default;

        public readonly struct AssemblyKind
        {
            public ReflectedClass Class => ClrMetadata;

            public ReflectedKind Kind => K.Assembly;
        }

        public readonly struct ModuleKind
        {
            public ReflectedClass Class => ClrMetadata;

            public ReflectedKind Kind => K.Module;
        }

        public readonly struct MethodKind
        {
            public ReflectedClass Class => ClrMetadata;

            public ReflectedKind Kind => K.Method;
        }

        public readonly struct TypeKind
        {
            public ReflectedClass Class => ClrMetadata;

            public ReflectedKind Kind => K.Type;
        }

        public readonly struct EnumKind
        {
            public ReflectedClass Class => ClrMetadata;

            public ReflectedKind Kind => K.Enum;
        }

        public readonly struct EnumLiteralKind
        {
            public ReflectedClass Class => ClrMetadata;

            public ReflectedKind Kind => K.EnumLiteral;
        }

        public readonly struct FieldKind
        {
            public ReflectedClass Class => ClrMetadata;

            public ReflectedKind Kind => K.Field;
        }

        public readonly struct PropertyKind
        {
            public ReflectedClass Class => ClrMetadata;

            public ReflectedKind Kind => K.Property;
        }
    }
}