//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using K = ClangAst.AstNodeKind;

    public readonly partial struct ClangAst
    {
        public struct TranslationUnitDecl : IDeclNode<TranslationUnitDecl>
        {
            public const string SyntaxName = nameof(TranslationUnitDecl);

            public SyntaxNodeKey NodeKey {get;}

            public FS.FilePath SourceFile {get;}

            public Identifier Name
                => SourceFile.FileName.WithoutExtension.Name.Format();

            public GridPoint Location
                => GridPoint.Empty;

            public Identifier NodeName
                => SyntaxName;

            public K NodeKind
                => K.TranslationUnitDecl;
        }

        public struct TypeDefDecl : IDeclNode<TypeDefDecl>
        {
            public const string SyntaxName = nameof(TypeDefDecl);

            public SyntaxNodeKey NodeKey {get;}

            public GridPoint Location {get;}

            public Identifier Name {get;}

            public Identifier NodeName
                => SyntaxName;

            public K NodeKind
                => K.TypeDefDecl;
        }

        public struct PointerType : IAstNode<PointerType>
        {
            public const string SyntaxName = nameof(PointerType);

            public SyntaxNodeKey NodeKey {get;}

            public GridPoint Position {get;}

            public TextBlock Data {get;}

            public PointerType(SyntaxNodeKey key, GridPoint pos, TextBlock data)
            {
                NodeKey = key;
                Position = pos;
                Data = data;
            }

            public Identifier NodeName
                => SyntaxName;

            public K NodeKind
                => K.PointerType;
        }

        public struct BuiltinType : IAstNode<BuiltinType>
        {
            public const string SyntaxName = nameof(BuiltinType);

            public SyntaxNodeKey NodeKey {get;}

            public Identifier Data {get;}

            public BuiltinType(SyntaxNodeKey key, Identifier name)
            {
                NodeKey = key;
                Data = name;
            }

            public Identifier NodeName
                => SyntaxName;

            public K NodeKind
                => K.BuiltinType;
        }

        public struct EnumDecl : IDeclNode<EnumDecl>
        {
            public const string SyntaxName = nameof(EnumDecl);

            public SyntaxNodeKey NodeKey {get;}

            public GridPoint Location {get;}

            public Identifier Name {get;}

            public Identifier NodeName
                => SyntaxName;

            public K NodeKind
                => K.EnumDecl;
        }

        public struct EnumConstantDecl : IDeclNode<EnumConstantDecl>
        {
            public const string SyntaxName = nameof(EnumConstantDecl);

            public SyntaxNodeKey NodeKey {get;}

            public GridPoint Location {get;}

            public Identifier Name {get;}

            public EnumConstantDecl(SyntaxNodeKey key, GridPoint location, Identifier name)
            {
                NodeKey = key;
                Location = location;
                Name = name;
            }

            public Identifier NodeName
                => SyntaxName;

            public K NodeKind
                => K.EnumConstantDecl;
        }

        public struct ConstantExpr : IAstNode<ConstantExpr>
        {
            public const string SyntaxName = nameof(ConstantExpr);

            public SyntaxNodeKey NodeKey {get;}

            public TextBlock Value {get;}

            public Identifier NodeName
                => SyntaxName;

            public K NodeKind
                => K.ConstantExpr;
        }

        public struct IntegerLiteral : IAstNode<IntegerLiteral>
        {
            public const string SyntaxName = nameof(IntegerLiteral);

            public SyntaxNodeKey NodeKey {get;}

            public Identifier Type {get;}

            public ulong Value {get;}

            public IntegerLiteral(SyntaxNodeKey key, Identifier type, ulong value)
            {
                NodeKey = key;
                Type = type;
                Value = value;
            }

            public Identifier NodeName
                => SyntaxName;

            public K NodeKind
                => K.IntegerLiteral;
        }

        public struct CXXRecordDecl : IDeclNode<CXXRecordDecl>
        {
            public const string SyntaxName = nameof(CXXRecordDecl);

            public SyntaxNodeKey NodeKey {get;}

            public GridPoint Location {get;}

            public Identifier Name {get;}

            public Identifier NodeName
                => SyntaxName;

            public K NodeKind
                => K.CXXRecordDecl;
        }

        public struct TextComment : IAstNode<TextComment>
        {
            public const string SyntaxName = nameof(TextComment);

            public SyntaxNodeKey NodeKey {get;}

            public Identifier NodeName
                => SyntaxName;

            public K NodeKind
                => K.TextComment;
        }
    }
}