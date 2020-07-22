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

        public readonly struct ReflectedAssembly : IArtifactKind<ReflectedKind>
        {
            public ArtifactClass Class => ClrMetadata;

            public ReflectedKind Kind => K.Assembly;
        }

        public readonly struct ReflectedModule : IArtifactKind<ReflectedKind>
        {
            public ArtifactClass Class => ClrMetadata;

            public ReflectedKind Kind => K.Module;
        }

        public readonly struct ReflectedMethod : IArtifactKind<ReflectedKind>
        {
            public ArtifactClass Class => ClrMetadata;
            
            public ReflectedKind Kind => K.Method;
        }

        public readonly struct ReflectedType : IArtifactKind<ReflectedKind>
        {
            public ArtifactClass Class => ClrMetadata;
            
            public ReflectedKind Kind => K.Type;
        }

        public readonly struct ReflectedEnum : IArtifactKind<ReflectedKind>
        {
            public ArtifactClass Class => ClrMetadata;
            
            public ReflectedKind Kind => K.Enum;
        }

        public readonly struct ReflectedEnumLiteral : IArtifactKind<ReflectedKind>
        {
            public ArtifactClass Class => ClrMetadata;
            
            public ReflectedKind Kind => K.EnumLiteral;
        }

        public readonly struct ReflectedField : IArtifactKind<ReflectedKind>
        {
            public ArtifactClass Class => ClrMetadata;
            
            public ReflectedKind Kind => K.Field;
        }

        public readonly struct ReflectedProperty : IArtifactKind<ReflectedKind>
        {
            public ArtifactClass Class => ClrMetadata;

            public ReflectedKind Kind => K.Property;
        }       
    }
}