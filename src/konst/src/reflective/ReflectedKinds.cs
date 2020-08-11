//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System.Runtime.CompilerServices;

    using static Konst;
    using static ArtifactClass;

    using K = ReflectedKind;

    public readonly partial struct ReflectedKinds
    {
        public ReflectedAssembly Assembly => default;
        
        public ReflectedModule Module => default;
        
        public ReflectedMethod Method => default;

        public ReflectedType Type => default;

        public ReflectedEnum Enum => default;

        public ReflectedEnumLiteral EnumLiteral => default;

        public ReflectedField Field => default;

        public ReflectedProperty Property => default;

        public readonly struct ReflectedAssembly
        {
            public ArtifactClass Class => ClrMetadata;

            public ReflectedKind Kind => K.Assembly;
        }

        public readonly struct ReflectedModule
        {
            public ArtifactClass Class => ClrMetadata;

            public ReflectedKind Kind => K.Module;
        }

        public readonly struct ReflectedMethod
        {
            public ArtifactClass Class => ClrMetadata;
            
            public ReflectedKind Kind => K.Method;
        }

        public readonly struct ReflectedType
        {
            public ArtifactClass Class => ClrMetadata;
            
            public ReflectedKind Kind => K.Type;
        }

        public readonly struct ReflectedEnum
        {
            public ArtifactClass Class => ClrMetadata;
            
            public ReflectedKind Kind => K.Enum;
        }

        public readonly struct ReflectedEnumLiteral
        {
            public ArtifactClass Class => ClrMetadata;
            
            public ReflectedKind Kind => K.EnumLiteral;
        }

        public readonly struct ReflectedField
        {
            public ArtifactClass Class => ClrMetadata;
            
            public ReflectedKind Kind => K.Field;
        }

        public readonly struct ReflectedProperty
        {
            public ArtifactClass Class => ClrMetadata;

            public ReflectedKind Kind => K.Property;
        }       
    }
}