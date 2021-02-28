//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface ISyntaxNode
    {
        Identifier NodeName {get;}

        SyntaxNodeKey NodeKey {get;}
    }

    public interface ISyntaxNode<T> : ISyntaxNode, IEquatable<T>
        where T : ISyntaxNode<T>, new()
    {
        bool IEquatable<T>.Equals(T src)
            => NodeKey.Equals(src.NodeKey);
    }

    public readonly struct SyntaxNodeKey : IDataTypeEquatable<SyntaxNodeKey>
    {
        public ulong Value {get;}

        [MethodImpl(Inline)]
        public SyntaxNodeKey(ulong value)
            => Value = value;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Value == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Value != 0;
        }

        [MethodImpl(Inline)]
        public bool Equals(SyntaxNodeKey src)
            => Value == src.Value;

        public override bool Equals(object src)
            => src is SyntaxNodeKey x && Equals(x);

        public override int GetHashCode()
            => Value.GetHashCode();

        public string Format()
            => Value.FormatHex(zpad:false, specifier:true, prespec: false);

        public override string ToString()
            => Format();

        public static implicit operator SyntaxNodeKey(ulong src)
            => new SyntaxNodeKey(src);

        public static SyntaxNodeKey Empty
            => default;
    }

    public readonly partial struct ClangAst
    {
        public readonly struct TranslationUnitDecl
        {
            public readonly SyntaxNodeKey Key {get;}

            public const string NodeName = nameof(TranslationUnitDecl);
        }

        // |-TypedefDecl 0x2021fd872f0 <<invalid sloc>> <invalid sloc> implicit referenced __builtin_va_list 'char *'
        // |-TypedefDecl 0x2021fdc12e8 <line:117:1, line:209:3> col:3 referenced xed_attribute_enum_t 'enum xed_attribute_enum_t':'xed_attribute_enum_t'
        public struct TypeDefDecl
        {
            public const string SyntaxName = nameof(TypeDefDecl);

            public SyntaxNodeKey NodeKey {get;}

            public SyntaxNodeKey ParentKey {get;}

            public GridPoint Position {get;}

            public TextBlock Qualifier {get;}

            public TextBlock Source {get;}

            public TextBlock Target {get;}

            public Identifier NodeName
                => SyntaxName;

        }

        // | `-PointerType 0x2021fd87240 'char *'
        public struct PointerType
        {
            public const string SyntaxName = nameof(PointerType);

            public SyntaxNodeKey NodeKey {get;}

            public SyntaxNodeKey ParentKey {get;}

            public GridPoint Position {get;}

            public TextBlock Data {get;}

            public PointerType(SyntaxNodeKey key, SyntaxNodeKey pKey, GridPoint pos, TextBlock data)
            {
                NodeKey = key;
                ParentKey = pKey;
                Position = pos;
                Data = data;
            }

            public Identifier NodeName
                => SyntaxName;

        }

        // |   `-BuiltinType 0x2021fb1c470 'char'
        public struct BuiltinType
        {
            public const string SyntaxName = nameof(BuiltinType);

            public SyntaxNodeKey NodeKey {get;}

            public SyntaxNodeKey Parent {get;}

            public Identifier Data {get;}

            public BuiltinType(SyntaxNodeKey key, SyntaxNodeKey pKey, Identifier name)
            {
                Parent = pKey;
                NodeKey = key;
                Data = name;
            }

            public Identifier NodeName
                => SyntaxName;
        }

        // |-EnumDecl 0x2021fd873a8 <C:\Dev\labs\xed\kit\include\xed/xed-attribute-enum.h:117:9, line:209:1> line:117:9
        public struct EnumDecl
        {
            public const string SyntaxName = nameof(EnumDecl);

            public SyntaxNodeKey NodeKey {get;}

            public FS.FilePath Location {get;}

            public GridPoint Position {get;}

            public Identifier NodeName
                => SyntaxName;
        }

        // | |-EnumConstantDecl 0x2022031a418 <line:8063:3, col:29> col:3 XED_IFORM_RDSSPD_GPR32u32 'xed_iform_enum_t'
        // | |-EnumConstantDecl 0x2021fdc1b28 <line:33:3, col:25> col:3 referenced XED_ADDRESS_WIDTH_16b 'xed_address_width_enum_t'
        public struct EnumConstantDecl
        {
            public const string SyntaxName = nameof(EnumConstantDecl);

            public SyntaxNodeKey NodeKey {get;}

            public SyntaxNodeKey ParentKey {get;}

            public GridPoint Poisition {get;}

            public Identifier ParentName {get;}

            public Identifier Name {get;}

            public EnumConstantDecl(SyntaxNodeKey key, SyntaxNodeKey pKey, GridPoint pos, Identifier name, Identifier pName)
            {
                NodeKey = key;
                ParentKey = pKey;
                Poisition = pos;
                Name = name;
                ParentName = pName;
            }

            public Identifier NodeName
                => SyntaxName;
        }


        public struct ConstantExpr
        {
            public const string SyntaxName = nameof(ConstantExpr);

            public SyntaxNodeKey NodeKey {get;}

            public TextBlock Value {get;}

            public Identifier NodeName
                => SyntaxName;
        }

        // | | | `-IntegerLiteral 0x2021fdc1ae0 <col:25> 'int' 2
        public struct IntegerLiteral
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

        }

        public struct CXXRecordDecl
        {
            public const string SyntaxName = nameof(CXXRecordDecl);

            public SyntaxNodeKey NodeKey {get;}

            public SyntaxNodeKey ParentKey {get;}

            public Identifier NodeName
                => SyntaxName;
        }
    }
}