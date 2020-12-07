//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.CodeAnalysis.Models
{
    using System;

    using CA = Microsoft.CodeAnalysis;

    using Microsoft.CodeAnalysis;

    public struct Module : ILanguageTable<Module>
    {
        public INamespaceSymbol GlobalNamespace;

        public Index<AssemblyIdentity> ReferencedAssemblies;

        public Index<IAssemblySymbol> ReferencedAssemblySymbols;

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

        public Index<Location> Locations;

        public Index<SyntaxReference> DeclaringSyntaxReferences;

        public Accessibility DeclaredAccessibility;

        public bool HasUnsupportedMetadata;
    }

}