//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang.Cs
{
    using System;

    using R = System.Reflection;
    using CA = Microsoft.CodeAnalysis;

    using Microsoft.CodeAnalysis;

    partial struct DataModel
    {
        public struct Module : ICsRecord<Module>
        {
            public INamespaceSymbol GlobalNamespace;

            public Indexed<AssemblyIdentity> ReferencedAssemblies;

            public Indexed<IAssemblySymbol> ReferencedAssemblySymbols;

            public SymbolKind Kind;

            public string Language;

            public string Name;

            public string MetadataName;

            public CA.ISymbol ContainingSymbol;

            public IAssemblySymbol ContainingAssembly;

            public IModuleSymbol ContainingModule;

            public INamedTypeSymbol ContainingType;

            public INamespaceSymbol ContainingNamespace;

            public bool IsDefinition;

            public bool IsStatic;

            public bool IsVirtual;

            public bool IsOverride;

            public bool IsAbstract;

            public bool IsSealed;

            public bool IsExtern;

            public bool IsImplicitlyDeclared;

            public bool CanBeReferencedByName;

            public Indexed<Location> Locations;

            public Indexed<SyntaxReference> DeclaringSyntaxReferences;

            public Accessibility DeclaredAccessibility;

            public bool HasUnsupportedMetadata;
        }
    }
}