//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Immutable;
    using System.Globalization;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using Microsoft.CodeAnalysis;

    using static Root;

    using api = CodeSymbols;

    partial struct CodeSymbolics
    {
        /// <summary>
        /// Represents an array type
        /// </summary>
        public readonly struct ArrayTypeSymbol : ICodeSymbol<ArrayTypeSymbol,IArrayTypeSymbol>
        {
            public IArrayTypeSymbol Source {get;}

            [MethodImpl(Inline)]
            public ArrayTypeSymbol(IArrayTypeSymbol src)
            {
                Source = src;
            }

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Source == null;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => Source != null;
            }

            public int Rank => Source.Rank;

            public bool IsSZArray => Source.IsSZArray;

            public ImmutableArray<int> LowerBounds => Source.LowerBounds;

            public ImmutableArray<int> Sizes => Source.Sizes;

            public ITypeSymbol ElementType => Source.ElementType;

            public NullableAnnotation ElementNullableAnnotation
                => Source.ElementNullableAnnotation;

            public ReadOnlySpan<CustomModifier> CustomModifiers
                => Source.CustomModifiers.AsSpan();

            public TypeKind TypeKind => Source.TypeKind;

            public INamedTypeSymbol BaseType => Source.BaseType;

            public ImmutableArray<INamedTypeSymbol> Interfaces => Source.Interfaces;

            public ImmutableArray<INamedTypeSymbol> AllInterfaces => Source.AllInterfaces;

            public bool IsReferenceType => Source.IsReferenceType;

            public bool IsValueType => Source.IsValueType;

            public bool IsAnonymousType => Source.IsAnonymousType;

            public bool IsTupleType => Source.IsTupleType;

            public bool IsNativeIntegerType => Source.IsNativeIntegerType;

            public ITypeSymbol OriginalDefinition => Source.OriginalDefinition;

            public SpecialType SpecialType => Source.SpecialType;

            public bool IsRefLikeType => Source.IsRefLikeType;

            public bool IsUnmanagedType => Source.IsUnmanagedType;

            public bool IsReadOnly => Source.IsReadOnly;

            public NullableAnnotation NullableAnnotation
                => Source.NullableAnnotation;

            public bool IsNamespace => Source.IsNamespace;

            public bool IsType => Source.IsType;

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


            [MethodImpl(Inline)]
            public static implicit operator ArrayTypeSymbol(CodeSymbol<IArrayTypeSymbol> src)
                => new ArrayTypeSymbol(src.Source);

            public bool Equals(IArrayTypeSymbol other)
            {
                return Source.Equals(other);
            }

            public ISymbol FindImplementationForInterfaceMember(ISymbol interfaceMember)
            {
                return Source.FindImplementationForInterfaceMember(interfaceMember);
            }

            public string ToDisplayString(NullableFlowState topLevelNullability, SymbolDisplayFormat format = null)
            {
                return Source.ToDisplayString(topLevelNullability, format);
            }

            public ImmutableArray<SymbolDisplayPart> ToDisplayParts(NullableFlowState topLevelNullability, SymbolDisplayFormat format = null)
            {
                return Source.ToDisplayParts(topLevelNullability, format);
            }

            public string ToMinimalDisplayString(SemanticModel semanticModel, NullableFlowState topLevelNullability, int position, SymbolDisplayFormat format = null)
            {
                return Source.ToMinimalDisplayString(semanticModel, topLevelNullability, position, format);
            }

            public ImmutableArray<SymbolDisplayPart> ToMinimalDisplayParts(SemanticModel semanticModel, NullableFlowState topLevelNullability, int position, SymbolDisplayFormat format = null)
            {
                return Source.ToMinimalDisplayParts(semanticModel, topLevelNullability, position, format);
            }

            public ITypeSymbol WithNullableAnnotation(NullableAnnotation nullableAnnotation)
            {
                return Source.WithNullableAnnotation(nullableAnnotation);
            }

            public ImmutableArray<ISymbol> GetMembers()
            {
                return Source.GetMembers();
            }

            public ImmutableArray<ISymbol> GetMembers(string name)
            {
                return Source.GetMembers(name);
            }

            public ImmutableArray<INamedTypeSymbol> GetTypeMembers()
            {
                return Source.GetTypeMembers();
            }

            public ImmutableArray<INamedTypeSymbol> GetTypeMembers(string name)
            {
                return Source.GetTypeMembers(name);
            }

            public ImmutableArray<INamedTypeSymbol> GetTypeMembers(string name, int arity)
            {
                return Source.GetTypeMembers(name, arity);
            }

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

            public bool Equals(ArrayTypeSymbol src)
                => Source.Equals(src.Source);

             public string Format()
                => api.format(this);

            public override string ToString()
                => Format();
        }
    }
}