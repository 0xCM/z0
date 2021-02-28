//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    readonly partial struct ClangAst
    {
        public enum AstNodeKind : ushort
        {
            TranslationUnitDecl,

            TypeDefDecl,

            PointerType,

            BuiltinType,

            EnumDecl,

            EnumConstantDecl,

            ConstantExpr,

            IntegerLiteral,

            CXXRecordDecl,

            TextComment,
        }
    }
}