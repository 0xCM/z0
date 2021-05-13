//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Immutable;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using Microsoft.CodeAnalysis;

    using static Root;

    partial struct CodeSymbolics
    {
        public readonly struct ParameterSymbol : ICodeSymbol<ParameterSymbol,IParameterSymbol>
        {
            public IParameterSymbol Source {get;}

            [MethodImpl(Inline)]
            public ParameterSymbol(IParameterSymbol src)
            {
                Source = src;
            }

            public RefKind RefKind => Source.RefKind;

            public bool IsParams => Source.IsParams;

            public bool IsOptional => Source.IsOptional;

            public bool IsThis => Source.IsThis;

            public bool IsDiscard => Source.IsDiscard;

            public ITypeSymbol Type => Source.Type;

            public NullableAnnotation NullableAnnotation => Source.NullableAnnotation;

            public ImmutableArray<CustomModifier> CustomModifiers => Source.CustomModifiers;

            public ImmutableArray<CustomModifier> RefCustomModifiers => Source.RefCustomModifiers;

            public int Ordinal => Source.Ordinal;

            public bool HasExplicitDefaultValue => Source.HasExplicitDefaultValue;

            public object ExplicitDefaultValue => Source.ExplicitDefaultValue;

            public IParameterSymbol OriginalDefinition => Source.OriginalDefinition;

            public SymbolKind Kind => Source.Kind;

            public string Language => Source.Language;

            public string Name => Source.Name;

            public string MetadataName => Source.MetadataName;

            public ISymbol ContainingSymbol => Source.ContainingSymbol;

            public IAssemblySymbol ContainingAssembly => Source.ContainingAssembly;

            public IModuleSymbol ContainingModule => Source.ContainingModule;

            public INamedTypeSymbol ContainingType => Source.ContainingType;

            public INamespaceSymbol ContainingNamespace => Source.ContainingNamespace;

            public bool IsDefinition => Source.IsDefinition;

            public bool IsStatic => Source.IsStatic;

            public bool IsVirtual => Source.IsVirtual;

            public bool IsOverride => Source.IsOverride;

            public bool IsAbstract => Source.IsAbstract;

            public bool IsSealed => Source.IsSealed;

            public bool IsExtern => Source.IsExtern;

            public bool IsImplicitlyDeclared => Source.IsImplicitlyDeclared;

            public bool CanBeReferencedByName => Source.CanBeReferencedByName;

            public ImmutableArray<Location> Locations
                => Source.Locations;

            public ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
                => Source.DeclaringSyntaxReferences;

            public Accessibility DeclaredAccessibility => Source.DeclaredAccessibility;

            public bool HasUnsupportedMetadata => Source.HasUnsupportedMetadata;


            public ReadOnlySpan<AttributeData> GetAttributes()
                => Source.GetAttributes().AsSpan();

            public void Accept(SymbolVisitor visitor)
                => Source.Accept(visitor);

            public TResult Accept<TResult>(SymbolVisitor<TResult> visitor)
                => Source.Accept(visitor);

            public string GetDocumentationCommentId()
                => Source.GetDocumentationCommentId();

            public string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default)
                => Source.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken);

            public string ToDisplayString(SymbolDisplayFormat format = null)
                => Source.ToDisplayString(format);

            public ReadOnlySpan<SymbolDisplayPart> ToDisplayParts(SymbolDisplayFormat format = null)
                => Source.ToDisplayParts(format).AsSpan();

            public string ToMinimalDisplayString(SemanticModel semanticModel, int position, SymbolDisplayFormat format = null)
                => Source.ToMinimalDisplayString(semanticModel, position, format);

            public ReadOnlySpan<SymbolDisplayPart> ToMinimalDisplayParts(SemanticModel semanticModel, int position, SymbolDisplayFormat format = null)
                => Source.ToMinimalDisplayParts(semanticModel, position, format).AsSpan();

            public bool Equals(ParameterSymbol src)
                => Source.Equals(src.Source);

            public override string ToString()
                => ToDisplayString();

            [MethodImpl(Inline)]
            public static implicit operator ParameterSymbol(CodeSymbol<IParameterSymbol> src)
                => new ParameterSymbol(src.Source);
        }
    }
}