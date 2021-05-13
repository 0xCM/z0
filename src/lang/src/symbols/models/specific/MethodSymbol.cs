//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Immutable;
    using System.Globalization;
    using System.Reflection.Metadata;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using Microsoft.CodeAnalysis;

    using static Root;

    using api = CodeSymbols;

    partial struct CodeSymbolics
    {
        public readonly struct MethodSymbol : ICodeSymbol<MethodSymbol,IMethodSymbol>
        {
            public IMethodSymbol Source {get;}

            [MethodImpl(Inline)]
            public MethodSymbol(IMethodSymbol src)
            {
                Source = src;
            }

            public MethodKind MethodKind
                => Source.MethodKind;

            public int Arity
                => Source.Arity;

            public bool IsGenericMethod
                => Source.IsGenericMethod;

            public bool IsExtensionMethod
                => Source.IsExtensionMethod;

            public bool IsAsync
                => Source.IsAsync;

            public bool IsVararg
                => Source.IsVararg;

            public bool IsCheckedBuiltin
                => Source.IsCheckedBuiltin;

            public bool HidesBaseMethodsByName
                => Source.HidesBaseMethodsByName;

            public bool ReturnsVoid
                => Source.ReturnsVoid;

            public bool ReturnsByRef
                => Source.ReturnsByRef;

            public bool ReturnsByRefReadonly
                => Source.ReturnsByRefReadonly;

            public RefKind RefKind
                => Source.RefKind;

            public ITypeSymbol ReturnType
                => Source.ReturnType;

            public NullableAnnotation ReturnNullableAnnotation
                => Source.ReturnNullableAnnotation;

            public ImmutableArray<ITypeSymbol> TypeArguments
                => Source.TypeArguments;

            public ImmutableArray<NullableAnnotation> TypeArgumentNullableAnnotations
                => Source.TypeArgumentNullableAnnotations;

            public ImmutableArray<ITypeParameterSymbol> TypeParameters
                => Source.TypeParameters;

            public ImmutableArray<IParameterSymbol> Parameters
                => Source.Parameters;

            public IMethodSymbol ConstructedFrom
                => Source.ConstructedFrom;

            public bool IsReadOnly
                => Source.IsReadOnly;

            public bool IsInitOnly
                => Source.IsInitOnly;

            public IMethodSymbol OriginalDefinition
                => Source.OriginalDefinition;

            public IMethodSymbol OverriddenMethod
                => Source.OverriddenMethod;

            public ITypeSymbol ReceiverType
                => Source.ReceiverType;

            public NullableAnnotation ReceiverNullableAnnotation
                => Source.ReceiverNullableAnnotation;

            public IMethodSymbol ReducedFrom
                => Source.ReducedFrom;

            public ImmutableArray<IMethodSymbol> ExplicitInterfaceImplementations
                => Source.ExplicitInterfaceImplementations;

            public ImmutableArray<CustomModifier> ReturnTypeCustomModifiers
                => Source.ReturnTypeCustomModifiers;

            public ImmutableArray<CustomModifier> RefCustomModifiers
                => Source.RefCustomModifiers;

            public SignatureCallingConvention CallingConvention
                => Source.CallingConvention;

            public ImmutableArray<INamedTypeSymbol> UnmanagedCallingConventionTypes
                => Source.UnmanagedCallingConventionTypes;

            public ISymbol AssociatedSymbol
                => Source.AssociatedSymbol;

            public IMethodSymbol PartialDefinitionPart
                => Source.PartialDefinitionPart;

            public IMethodSymbol PartialImplementationPart
                => Source.PartialImplementationPart;

            public INamedTypeSymbol AssociatedAnonymousDelegate
                => Source.AssociatedAnonymousDelegate;

            public bool IsConditional
                => Source.IsConditional;

            public SymbolKind Kind
                => Source.Kind;

            public string Language
                => Source.Language;

            public string Name
                => Source.Name;

            public string MetadataName
                => Source.MetadataName;

            public ISymbol ContainingSymbol
                => Source.ContainingSymbol;

            public IAssemblySymbol ContainingAssembly
                => Source.ContainingAssembly;

            public IModuleSymbol ContainingModule
                => Source.ContainingModule;

            public INamedTypeSymbol ContainingType
                => Source.ContainingType;

            public INamespaceSymbol ContainingNamespace
                => Source.ContainingNamespace;

            public bool IsDefinition
                => Source.IsDefinition;

            public bool IsStatic
                => Source.IsStatic;

            public bool IsVirtual
                => Source.IsVirtual;

            public bool IsOverride
                => Source.IsOverride;

            public bool IsAbstract
                => Source.IsAbstract;

            public bool IsSealed
                => Source.IsSealed;

            public bool IsExtern
                => Source.IsExtern;

            public bool IsImplicitlyDeclared
                => Source.IsImplicitlyDeclared;

            public bool CanBeReferencedByName
                => Source.CanBeReferencedByName;

            public ImmutableArray<Location> Locations
                => Source.Locations;

            public ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
                => Source.DeclaringSyntaxReferences;

            public Accessibility DeclaredAccessibility => Source.DeclaredAccessibility;

            public bool HasUnsupportedMetadata
                => Source.HasUnsupportedMetadata;

            public ITypeSymbol GetTypeInferredDuringReduction(ITypeParameterSymbol reducedFromTypeParameter)
                =>  Source.GetTypeInferredDuringReduction(reducedFromTypeParameter);

            public IMethodSymbol ReduceExtensionMethod(ITypeSymbol receiverType)
            {
                return Source.ReduceExtensionMethod(receiverType);
            }

            public ImmutableArray<AttributeData> GetReturnTypeAttributes()
                => Source.GetReturnTypeAttributes();

            public IMethodSymbol Construct(params ITypeSymbol[] typeArguments)
                => Source.Construct(typeArguments);

            public IMethodSymbol Construct(ImmutableArray<ITypeSymbol> typeArguments, ImmutableArray<NullableAnnotation> typeArgumentNullableAnnotations)
            {
                return Source.Construct(typeArguments, typeArgumentNullableAnnotations);
            }

            public DllImportData GetDllImportData()
                => Source.GetDllImportData();

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

            public bool Equals(MethodSymbol src)
                => Source.Equals(src.Source);

            public override string ToString()
                => ToDisplayString();

            [MethodImpl(Inline)]
            public static implicit operator MethodSymbol(CodeSymbol<IMethodSymbol> src)
                => new MethodSymbol(src.Source);
        }
    }
}