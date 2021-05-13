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

    using api = CodeSymbols;

    partial struct CodeSymbolics
    {
        public readonly struct FieldSymbol : ICodeSymbol<FieldSymbol,IFieldSymbol>
        {
            public IFieldSymbol Source {get;}

            [MethodImpl(Inline)]
            public FieldSymbol(IFieldSymbol src)
            {
                Source = src;
            }

            public ISymbol AssociatedSymbol
                => Source.AssociatedSymbol;

            public bool IsConst => Source.IsConst;

            public bool IsReadOnly => Source.IsReadOnly;

            public bool IsVolatile => Source.IsVolatile;

            public bool IsFixedSizeBuffer => Source.IsFixedSizeBuffer;

            public ITypeSymbol Type => Source.Type;

            public NullableAnnotation NullableAnnotation => Source.NullableAnnotation;

            public bool HasConstantValue => Source.HasConstantValue;

            public object ConstantValue => Source.ConstantValue;

            public ImmutableArray<CustomModifier> CustomModifiers => Source.CustomModifiers;

            public IFieldSymbol OriginalDefinition => Source.OriginalDefinition;

            public IFieldSymbol CorrespondingTupleField => Source.CorrespondingTupleField;

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

            public ImmutableArray<Location> Locations => Source.Locations;

            public ImmutableArray<SyntaxReference> DeclaringSyntaxReferences => Source.DeclaringSyntaxReferences;

            public Accessibility DeclaredAccessibility => Source.DeclaredAccessibility;


            public bool HasUnsupportedMetadata => Source.HasUnsupportedMetadata;

            public ImmutableArray<AttributeData> GetAttributes()
            {
                return Source.GetAttributes();
            }

            public void Accept(SymbolVisitor visitor)
            {
                Source.Accept(visitor);
            }

            public TResult Accept<TResult>(SymbolVisitor<TResult> visitor)
            {
                return Source.Accept(visitor);
            }

            public string GetDocumentationCommentId()
            {
                return Source.GetDocumentationCommentId();
            }

            public string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default)
            {
                return Source.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken);
            }

            public string ToDisplayString(SymbolDisplayFormat format = null)
            {
                return Source.ToDisplayString(format);
            }

            public ImmutableArray<SymbolDisplayPart> ToDisplayParts(SymbolDisplayFormat format = null)
            {
                return Source.ToDisplayParts(format);
            }

            public string ToMinimalDisplayString(SemanticModel semanticModel, int position, SymbolDisplayFormat format = null)
            {
                return Source.ToMinimalDisplayString(semanticModel, position, format);
            }

            public ImmutableArray<SymbolDisplayPart> ToMinimalDisplayParts(SemanticModel semanticModel, int position, SymbolDisplayFormat format = null)
            {
                return Source.ToMinimalDisplayParts(semanticModel, position, format);
            }

            public bool Equals(FieldSymbol src)
                => Source.Equals(src.Source);

            public override string ToString()
                => ToDisplayString();

            [MethodImpl(Inline)]
            public static implicit operator FieldSymbol(CodeSymbol<IFieldSymbol> src)
                => new FieldSymbol(src.Source);
         }
    }
}