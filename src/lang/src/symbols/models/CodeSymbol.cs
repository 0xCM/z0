//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Immutable;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Threading;
    using Microsoft.CodeAnalysis;

    using static Root;

    public readonly struct CodeSymbol : ICodeSymbol
    {
        public ISymbol Symbol {get;}

        [MethodImpl(Inline)]
        internal CodeSymbol(CodeSymbols src, uint index)
        {
            Symbol = src.Lookup(index).Symbol;
        }

        [MethodImpl(Inline)]
        public CodeSymbol(ISymbol src)
        {
           Symbol = src;
        }

        /// <inheritdoc cref='ISymbol.Kind'/>
        public SymbolKind Kind
        {
            [MethodImpl(Inline)]
            get => Symbol.Kind;
        }

        /// <inheritdoc cref='ISymbol.Language'/>
        public string Language
        {
            [MethodImpl(Inline)]
            get => Symbol.Language;
        }

        /// <inheritdoc cref='ISymbol.Name'/>
        public string Name
        {
            [MethodImpl(Inline)]
            get => Symbol.Name;
        }

        /// <inheritdoc cref='ISymbol.MetadataName'/>
        public string MetadataName
        {
            [MethodImpl(Inline)]
            get => Symbol.MetadataName;
        }


        /// <inheritdoc cref='ISymbol.ContainingSymbol'/>
        public ISymbol ContainingSymbol
        {
            [MethodImpl(Inline)]
            get => Symbol.ContainingSymbol;
        }

        /// <inheritdoc cref='ISymbol.ContainingAssembly'/>
        public IAssemblySymbol ContainingAssembly
        {
            [MethodImpl(Inline)]
            get => Symbol.ContainingAssembly;
        }

        /// <inheritdoc cref='ISymbol.ContainingModule'/>
        public IModuleSymbol ContainingModule
        {
            [MethodImpl(Inline)]
            get => Symbol.ContainingModule;
        }

        /// <inheritdoc cref='ISymbol.ContainingType'/>
        public INamedTypeSymbol ContainingType
        {
            [MethodImpl(Inline)]
            get => Symbol.ContainingType;
        }

        /// <inheritdoc cref='ISymbol.ContainingNamespace'/>
        public INamespaceSymbol ContainingNamespace
        {
            [MethodImpl(Inline)]
            get => Symbol.ContainingNamespace;
        }

        /// <inheritdoc cref='ISymbol.IsDefinition'/>
        public bool IsDefinition
        {
            [MethodImpl(Inline)]
            get => Symbol.IsDefinition;
        }

        /// <inheritdoc cref='ISymbol.IsStatic'/>
        public bool IsStatic
        {
            [MethodImpl(Inline)]
            get => Symbol.IsStatic;
        }

        /// <inheritdoc cref='ISymbol.IsVirtual'/>
        public bool IsVirtual
        {
            [MethodImpl(Inline)]
            get => Symbol.IsVirtual;
        }

        /// <inheritdoc cref='ISymbol.IsOverride'/>
        public bool IsOverride
        {
            [MethodImpl(Inline)]
            get => Symbol.IsOverride;
        }

        /// <inheritdoc cref='ISymbol.IsAbstract'/>
        public bool IsAbstract
        {
            [MethodImpl(Inline)]
            get => Symbol.IsAbstract;
        }

        /// <inheritdoc cref='ISymbol.IsSealed'/>
        public bool IsSealed
        {
            [MethodImpl(Inline)]
            get => Symbol.IsSealed;
        }

        /// <inheritdoc cref='ISymbol.IsExtern'/>
        public bool IsExtern
        {
            [MethodImpl(Inline)]
            get => Symbol.IsExtern;
        }

        /// <inheritdoc cref='ISymbol.IsImplicitlyDeclared'/>
        public bool IsImplicitlyDeclared
        {
            [MethodImpl(Inline)]
            get => Symbol.IsImplicitlyDeclared;
        }

        /// <inheritdoc cref='ISymbol.CanBeReferencedByName'/>
        public bool CanBeReferencedByName
        {
            [MethodImpl(Inline)]
            get => Symbol.CanBeReferencedByName;
        }

        /// <inheritdoc cref='ISymbol.Locations'/>
        public ImmutableArray<Location> Locations
        {
            [MethodImpl(Inline)]
            get => Symbol.Locations;
        }

        /// <inheritdoc cref='ISymbol.ContainingModule'/>
        public ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            [MethodImpl(Inline)]
            get => Symbol.DeclaringSyntaxReferences;
        }

        public Accessibility DeclaredAccessibility
        {
            [MethodImpl(Inline)]
            get => Symbol.DeclaredAccessibility;
        }

        public ISymbol OriginalDefinition
        {
            [MethodImpl(Inline)]
            get => Symbol.OriginalDefinition;
        }

        public bool HasUnsupportedMetadata
        {
            [MethodImpl(Inline)]
            get => Symbol.HasUnsupportedMetadata;
        }

        [MethodImpl(Inline)]
        public ImmutableArray<AttributeData> GetAttributes()
            => Symbol.GetAttributes();

        [MethodImpl(Inline)]
        public void Accept(SymbolVisitor visitor)
            => Symbol.Accept(visitor);

        [MethodImpl(Inline)]
        public TResult Accept<TResult>(SymbolVisitor<TResult> visitor)
            => Symbol.Accept(visitor);

        [MethodImpl(Inline)]
        public string GetDocumentationCommentId()
            => Symbol.GetDocumentationCommentId();

        [MethodImpl(Inline)]
        public string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default)
            => Symbol.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken);

        [MethodImpl(Inline)]
        public string ToDisplayString(SymbolDisplayFormat format = null)
            => Symbol.ToDisplayString(format);

        [MethodImpl(Inline)]
        public ImmutableArray<SymbolDisplayPart> ToDisplayParts(SymbolDisplayFormat format = null)
            => Symbol.ToDisplayParts(format);

        [MethodImpl(Inline)]
        public string ToMinimalDisplayString(SemanticModel semanticModel, int position, SymbolDisplayFormat format = null)
            => Symbol.ToMinimalDisplayString(semanticModel, position, format);

        [MethodImpl(Inline)]
        public ImmutableArray<SymbolDisplayPart> ToMinimalDisplayParts(SemanticModel semanticModel, int position, SymbolDisplayFormat format = null)
            => Symbol.ToMinimalDisplayParts(semanticModel, position, format);

        // [MethodImpl(Inline)]
        // public bool Equals([NotNullWhen(true)] ISymbol other, SymbolEqualityComparer equalityComparer)
        //     => Symbol.Equals(other, equalityComparer);

        [MethodImpl(Inline)]
        public bool Equals(CodeSymbol src)
            => Symbol.Equals(src.Symbol);
    }
}