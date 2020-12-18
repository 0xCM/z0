#pragma once
#include <cassert>
#include <cstddef>
#include <cstdint>
#include <iterator>
#include <utility>
#include <algorithm>
#include <cassert>
#include <cstring>
#include <string>
#include <tuple>
#include <utility>

#include "llvm/Support/DataTypes.h"
#include "llvm/Support/ErrorHandling.h"
#include "llvm/Support/SwapByteOrder.h"
#include "llvm/Support/type_traits.h"
#include "llvm/Support/Compiler.h"
#include "llvm/Support/Allocator.h"
#include "llvm/Support/raw_ostream.h"

#include "llvm/ADT/APInt.h"
#include "llvm/ADT/APSInt.h"
#include "llvm/ADT/ArrayRef.h"
#include "llvm/ADT/Hashing.h"
#include "llvm/ADT/DenseMapInfo.h"
#include "llvm/ADT/DenseMap.h"
#include "llvm/ADT/iterator.h"
#include "llvm/ADT/StringRef.h"

#include "clang/Basic/SourceLocation.h"
#include "clang/Basic/TokenKinds.h"
#include "clang/Basic/LangOptions.h"
#include "clang/Basic/SourceLocation.h"
#include "clang/Basic/SourceManager.h"
#include "clang/Basic/TokenKinds.h"
#include "clang/Tooling/Syntax/Tokens.h"
#include "clang/Basic/TokenKinds.h"
#include "clang/Lex/Token.h"
#include "clang/Tooling/Syntax/Tokens.h"
#include "clang/Tooling/Syntax/Tree.h"
#include "clang/Tooling/Syntax/Nodes.h"

//===- Nodes.h - syntax nodes for C/C++ grammar constructs ----*- C++ -*-=====//
//
// Part of the LLVM Project, under the Apache License v2.0 with LLVM Exceptions.
// See https://llvm.org/LICENSE.txt for license information.
// SPDX-License-Identifier: Apache-2.0 WITH LLVM-exception
//
//===----------------------------------------------------------------------===//
// Syntax tree nodes for C, C++ and Objective-C grammar constructs.
//
// Nodes provide access to their syntactic components, e.g. IfStatement provides
// a way to get its condition, then and else branches, tokens for 'if' and
// 'else' keywords.
// When using the accessors, please assume they can return null. This happens
// because:
//   - the corresponding subnode is optional in the C++ grammar, e.g. an else
//     branch of an if statement,
//   - syntactic errors occurred while parsing the corresponding subnode.
// One notable exception is "introducer" keywords, e.g. the accessor for the
// 'if' keyword of an if statement will never return null.
//===----------------------------------------------------------------------===//
namespace notes
{
    static inline unsigned combineHashValue(unsigned a, unsigned b) {
    uint64_t key = (uint64_t)a << 32 | (uint64_t)b;
    key += ~(key << 32);
    key ^= (key >> 22);
    key += ~(key << 13);
    key ^= (key >> 8);
    key += (key << 3);
    key ^= (key >> 15);
    key += ~(key << 27);
    key ^= (key >> 31);
    return (unsigned)key;
    }

    ///
    /// A relation between a parent and child node, e.g. 'left-hand-side of
    /// a binary expression'. Used for implementing accessors.
    ///
    /// In general `NodeRole`s should be named the same as their accessors.
    ///
    /// Some roles describe parent/child relations that occur multiple times in
    /// language grammar. We define only one role to describe all instances of such
    /// recurring relations. For example, grammar for both "if" and "while"
    /// statements requires an opening paren and a closing paren. The opening
    /// paren token is assigned the OpenParen role regardless of whether it appears
    /// as a child of IfStatement or WhileStatement node. More generally, when
    /// grammar requires a certain fixed token (like a specific keyword, or an
    /// opening paren), we define a role for this token and use it across all
    /// grammar rules with the same requirement. Names of such reusable roles end
    /// with a ~Token or a ~Keyword suffix.
    enum class NodeRole : uint8_t {
    // Roles common to multiple node kinds.
    /// A node without a parent
    Detached,
    /// Children of an unknown semantic nature, e.g. skipped tokens, comments.
    Unknown,
    /// An opening parenthesis in argument lists and blocks, e.g. '{', '(', etc.
    OpenParen,
    /// A closing parenthesis in argument lists and blocks, e.g. '}', ')', etc.
    CloseParen,
    /// A keywords that introduces some grammar construct, e.g. 'if', 'try', etc.
    IntroducerKeyword,
    /// A token that represents a literal, e.g. 'nullptr', '1', 'true', etc.
    LiteralToken,
    /// Tokens or Keywords.
    ArrowToken,
    ExternKeyword,
    TemplateKeyword,
    /// An inner statement for those that have only a single child of kind
    /// statement, e.g. loop body for while, for, etc; inner statement for case,
    /// default, etc.
    BodyStatement,
    /// List API roles.
    ListElement,
    ListDelimiter,

    // Roles specific to particular node kinds.
    OperatorToken,
    Operand,
    LeftHandSide,
    RightHandSide,
    ReturnValue,
    CaseValue,
    ThenStatement,
    ElseKeyword,
    ElseStatement,
    Expression,
    Statement,
    Condition,
    Message,
    Declarator,
    Declaration,
    Size,
    Parameters,
    TrailingReturn,
    UnqualifiedId,
    Qualifier,
    SubExpression,
    Object,
    AccessToken,
    Member,
    Callee,
    Arguments,
    Declarators
    };

    class Node;
    class Leaf;
    class Tree;
    class ArraySubscript;
    class Declaration;
    class EmptyDeclaration;
    class ExplicitTemplateInstantiation;
    class LinkageSpecificationDeclaration;
    class NamespaceAliasDefinition;
    class NamespaceDefinition;
    class SimpleDeclaration;
    class StaticAssertDeclaration;
    class TemplateDeclaration;
    class TypeAliasDeclaration;
    class UnknownDeclaration;
    class UsingDeclaration;
    class UsingNamespaceDirective;
    class Declarator;
    class ParenDeclarator;
    class SimpleDeclarator;
    class Expression;
    class BinaryOperatorExpression;
    class CallExpression;
    class IdExpression;
    class LiteralExpression;
    class BoolLiteralExpression;
    class CharacterLiteralExpression;
    class CxxNullPtrExpression;
    class FloatingLiteralExpression;
    class IntegerLiteralExpression;
    class StringLiteralExpression;
    class UserDefinedLiteralExpression;
    class CharUserDefinedLiteralExpression;
    class FloatUserDefinedLiteralExpression;
    class IntegerUserDefinedLiteralExpression;
    class StringUserDefinedLiteralExpression;
    class MemberExpression;
    class ParenExpression;
    class ThisExpression;
    class UnknownExpression;
    class List;
    class CallArguments;
    class DeclaratorList;
    class NestedNameSpecifier;
    class ParameterDeclarationList;
    class MemberPointer;
    class NameSpecifier;
    class DecltypeNameSpecifier;
    class GlobalNameSpecifier;
    class IdentifierNameSpecifier;
    class SimpleTemplateNameSpecifier;
    class ParametersAndQualifiers;
    class Statement;
    class BreakStatement;
    class CaseStatement;
    class CompoundStatement;
    class ContinueStatement;
    class DeclarationStatement;
    class DefaultStatement;
    class EmptyStatement;
    class ExpressionStatement;
    class ForStatement;
    class IfStatement;
    class RangeBasedForStatement;
    class ReturnStatement;
    class SwitchStatement;
    class UnknownStatement;
    class WhileStatement;
    class TrailingReturnType;
    class TranslationUnit;
    class UnaryOperatorExpression;
    class PostfixUnaryOperatorExpression;
    class PrefixUnaryOperatorExpression;
    class UnqualifiedId;
}

/*
##===----------------------------------------------------------------------===##
## Language keywords.
##===----------------------------------------------------------------------===##

## These define members of the tok::* namespace.

TOK(unknown)             // Not a token.
TOK(eof)                 // End of file.
TOK(eod)                 // End of preprocessing directive (end of line inside a
                         // directive).
TOK(code_completion)     // Code completion marker

## C99 6.4.9: Comments.
TOK(comment)             ## Comment (only in -E -C[C] mode)

## C99 6.4.2: Identifiers.
TOK(identifier)          ## abcde123
TOK(raw_identifier)      ## Used only in raw lexing mode.

## C99 6.4.4.1: Integer Constants
## C99 6.4.4.2: Floating Constants
TOK(numeric_constant)    ## 0x123

## C99 6.4.4: Character Constants
TOK(char_constant)       ## 'a'
TOK(wide_char_constant)  ## L'b'

## C++17 Character Constants
TOK(utf8_char_constant)  ## u8'a'

## C++11 Character Constants
TOK(utf16_char_constant) ## u'a'
TOK(utf32_char_constant) ## U'a'

## C99 6.4.5: String Literals.
TOK(string_literal)      ## "foo"
TOK(wide_string_literal) ## L"foo"

##  C11 6.4.7: Header Names
TOK(header_name)         ## <foo>, or "foo" lexed as a header-name

##  C++11 String Literals.
TOK(utf8_string_literal) ## u8"foo"
TOK(utf16_string_literal)## u"foo"
TOK(utf32_string_literal)## U"foo"

##  C99 6.4.6: Punctuators.
PUNCTUATOR(l_square,            "[")
PUNCTUATOR(r_square,            "]")
PUNCTUATOR(l_paren,             "(")
PUNCTUATOR(r_paren,             ")")
PUNCTUATOR(l_brace,             "{")
PUNCTUATOR(r_brace,             "}")
PUNCTUATOR(period,              ".")
PUNCTUATOR(ellipsis,            "...")
PUNCTUATOR(amp,                 "&")
PUNCTUATOR(ampamp,              "&&")
PUNCTUATOR(ampequal,            "&=")
PUNCTUATOR(star,                "*")
PUNCTUATOR(starequal,           "*=")
PUNCTUATOR(plus,                "+")
PUNCTUATOR(plusplus,            "++")
PUNCTUATOR(plusequal,           "+=")
PUNCTUATOR(minus,               "-")
PUNCTUATOR(arrow,               "->")
PUNCTUATOR(minusminus,          "--")
PUNCTUATOR(minusequal,          "-=")
PUNCTUATOR(tilde,               "~")
PUNCTUATOR(exclaim,             "!")
PUNCTUATOR(exclaimequal,        "!=")
PUNCTUATOR(slash,               "/")
PUNCTUATOR(slashequal,          "/=")
PUNCTUATOR(percent,             "%")
PUNCTUATOR(percentequal,        "%=")
PUNCTUATOR(less,                "<")
PUNCTUATOR(lessless,            "<<")
PUNCTUATOR(lessequal,           "<=")
PUNCTUATOR(lesslessequal,       "<<=")
PUNCTUATOR(spaceship,           "<=>")
PUNCTUATOR(greater,             ">")
PUNCTUATOR(greatergreater,      ">>")
PUNCTUATOR(greaterequal,        ">=")
PUNCTUATOR(greatergreaterequal, ">>=")
PUNCTUATOR(caret,               "^")
PUNCTUATOR(caretequal,          "^=")
PUNCTUATOR(pipe,                "|")
PUNCTUATOR(pipepipe,            "||")
PUNCTUATOR(pipeequal,           "|=")
PUNCTUATOR(question,            "?")
PUNCTUATOR(colon,               ":")
PUNCTUATOR(semi,                ";")
PUNCTUATOR(equal,               "=")
PUNCTUATOR(equalequal,          "==")
PUNCTUATOR(comma,               ",")
PUNCTUATOR(hash,                "#")
PUNCTUATOR(hashhash,            "##")
PUNCTUATOR(hashat,              "#@")

## C++ Support
PUNCTUATOR(periodstar,          ".*")
PUNCTUATOR(arrowstar,           "->*")
PUNCTUATOR(coloncolon,          "::")

## Objective C support.
PUNCTUATOR(at,                  "@")

## CUDA support.
PUNCTUATOR(lesslessless,          "<<<")
PUNCTUATOR(greatergreatergreater, ">>>")

## CL support
PUNCTUATOR(caretcaret,            "^^")

C99 6.4.1: Keywords.  These turn into kw_* tokens.
Flags allowed:
  KEYALL   - This is a keyword in all variants of C and C++, or it
             is a keyword in the implementation namespace that should
             always be treated as a keyword
  KEYC99   - This is a keyword introduced to C in C99
  KEYC11   - This is a keyword introduced to C in C11
  KEYCXX   - This is a C++ keyword, or a C++-specific keyword in the
             implementation namespace
  KEYNOCXX - This is a keyword in every non-C++ dialect.
  KEYCXX11 - This is a C++ keyword introduced to C++ in C++11
  KEYCXX20 - This is a C++ keyword introduced to C++ in C++20
  KEYCONCEPTS - This is a keyword if the C++ extensions for concepts
                are enabled.
  KEYMODULES - This is a keyword if the C++ extensions for modules
               are enabled.
  KEYGNU   - This is a keyword if GNU extensions are enabled
  KEYMS    - This is a keyword if Microsoft extensions are enabled
  KEYMSCOMPAT - This is a keyword if Microsoft compatibility mode is enabled
  KEYNOMS18 - This is a keyword that must never be enabled under
              MSVC <= v18.
  KEYOPENCLC   - This is a keyword in OpenCL C
  KEYOPENCLCXX - This is a keyword in C++ for OpenCL
  KEYNOOPENCL  - This is a keyword that is not supported in OpenCL
  KEYALTIVEC - This is a keyword in AltiVec
  KEYZVECTOR - This is a keyword for the System z vector extensions,
               which are heavily based on AltiVec
  KEYBORLAND - This is a keyword if Borland extensions are enabled
  KEYCOROUTINES - This is a keyword if support for C++ coroutines is enabled
  BOOLSUPPORT - This is a keyword if 'bool' is a built-in type
  HALFSUPPORT - This is a keyword if 'half' is a built-in type
  WCHARSUPPORT - This is a keyword if 'wchar_t' is a built-in type
  CHAR8SUPPORT - This is a keyword if 'char8_t' is a built-in type

KEYWORD(auto                        , KEYALL)
KEYWORD(break                       , KEYALL)
KEYWORD(case                        , KEYALL)
KEYWORD(char                        , KEYALL)
KEYWORD(const                       , KEYALL)
KEYWORD(continue                    , KEYALL)
KEYWORD(default                     , KEYALL)
KEYWORD(do                          , KEYALL)
KEYWORD(double                      , KEYALL)
KEYWORD(else                        , KEYALL)
KEYWORD(enum                        , KEYALL)
KEYWORD(extern                      , KEYALL)
KEYWORD(float                       , KEYALL)
KEYWORD(for                         , KEYALL)
KEYWORD(goto                        , KEYALL)
KEYWORD(if                          , KEYALL)
KEYWORD(inline                      , KEYC99|KEYCXX|KEYGNU)
KEYWORD(int                         , KEYALL)
KEYWORD(_ExtInt                     , KEYALL)
KEYWORD(long                        , KEYALL)
KEYWORD(register                    , KEYALL)
KEYWORD(restrict                    , KEYC99)
KEYWORD(return                      , KEYALL)
KEYWORD(short                       , KEYALL)
KEYWORD(signed                      , KEYALL)
UNARY_EXPR_OR_TYPE_TRAIT(sizeof, SizeOf, KEYALL)
KEYWORD(static                      , KEYALL)
KEYWORD(struct                      , KEYALL)
KEYWORD(switch                      , KEYALL)
KEYWORD(typedef                     , KEYALL)
KEYWORD(union                       , KEYALL)
KEYWORD(unsigned                    , KEYALL)
KEYWORD(void                        , KEYALL)
KEYWORD(volatile                    , KEYALL)
KEYWORD(while                       , KEYALL)
KEYWORD(_Alignas                    , KEYALL)
KEYWORD(_Alignof                    , KEYALL)
KEYWORD(_Atomic                     , KEYALL|KEYNOOPENCL)
KEYWORD(_Bool                       , KEYNOCXX)
KEYWORD(_Complex                    , KEYALL)
KEYWORD(_Generic                    , KEYALL)
KEYWORD(_Imaginary                  , KEYALL)
KEYWORD(_Noreturn                   , KEYALL)
KEYWORD(_Static_assert              , KEYALL)
KEYWORD(_Thread_local               , KEYALL)
KEYWORD(__func__                    , KEYALL)
KEYWORD(__objc_yes                  , KEYALL)
KEYWORD(__objc_no                   , KEYALL)


## C++ 2.11p1: Keywords.
KEYWORD(asm                         , KEYCXX|KEYGNU)
KEYWORD(bool                        , BOOLSUPPORT)
KEYWORD(catch                       , KEYCXX)
KEYWORD(class                       , KEYCXX)
KEYWORD(const_cast                  , KEYCXX)
KEYWORD(delete                      , KEYCXX)
KEYWORD(dynamic_cast                , KEYCXX)
KEYWORD(explicit                    , KEYCXX)
KEYWORD(export                      , KEYCXX)
KEYWORD(false                       , BOOLSUPPORT)
KEYWORD(friend                      , KEYCXX)
KEYWORD(mutable                     , KEYCXX)
KEYWORD(namespace                   , KEYCXX)
KEYWORD(new                         , KEYCXX)
KEYWORD(operator                    , KEYCXX)
KEYWORD(private                     , KEYCXX)
KEYWORD(protected                   , KEYCXX)
KEYWORD(public                      , KEYCXX)
KEYWORD(reinterpret_cast            , KEYCXX)
KEYWORD(static_cast                 , KEYCXX)
KEYWORD(template                    , KEYCXX)
KEYWORD(this                        , KEYCXX)
KEYWORD(throw                       , KEYCXX)
KEYWORD(true                        , BOOLSUPPORT)
KEYWORD(try                         , KEYCXX)
KEYWORD(typename                    , KEYCXX)
KEYWORD(typeid                      , KEYCXX)
KEYWORD(using                       , KEYCXX)
KEYWORD(virtual                     , KEYCXX)
KEYWORD(wchar_t                     , WCHARSUPPORT)

## C++ 2.5p2: Alternative Representations.
CXX_KEYWORD_OPERATOR(and     , ampamp)
CXX_KEYWORD_OPERATOR(and_eq  , ampequal)
CXX_KEYWORD_OPERATOR(bitand  , amp)
CXX_KEYWORD_OPERATOR(bitor   , pipe)
CXX_KEYWORD_OPERATOR(compl   , tilde)
CXX_KEYWORD_OPERATOR(not     , exclaim)
CXX_KEYWORD_OPERATOR(not_eq  , exclaimequal)
CXX_KEYWORD_OPERATOR(or      , pipepipe)
CXX_KEYWORD_OPERATOR(or_eq   , pipeequal)
CXX_KEYWORD_OPERATOR(xor     , caret)
CXX_KEYWORD_OPERATOR(xor_eq  , caretequal)

## C++11 keywords
CXX11_KEYWORD(alignas               , 0)
## alignof and _Alignof return the required ABI alignment
CXX11_UNARY_EXPR_OR_TYPE_TRAIT(alignof, AlignOf, 0)
CXX11_KEYWORD(char16_t              , KEYNOMS18)
CXX11_KEYWORD(char32_t              , KEYNOMS18)
CXX11_KEYWORD(constexpr             , 0)
CXX11_KEYWORD(decltype              , 0)
CXX11_KEYWORD(noexcept              , 0)
CXX11_KEYWORD(nullptr               , 0)
CXX11_KEYWORD(static_assert         , KEYMSCOMPAT)
CXX11_KEYWORD(thread_local          , 0)

## C++20 keywords
CONCEPTS_KEYWORD(concept)
CONCEPTS_KEYWORD(requires)

## C++20 / coroutines TS keywords
COROUTINES_KEYWORD(co_await)
COROUTINES_KEYWORD(co_return)
COROUTINES_KEYWORD(co_yield)

## C++ modules TS keywords
MODULES_KEYWORD(module)
MODULES_KEYWORD(import)

## C++20 keywords.
CXX20_KEYWORD(consteval             , 0)
CXX20_KEYWORD(constinit             , 0)
## Not a CXX20_KEYWORD because it is disabled by -fno-char8_t.
KEYWORD(char8_t                     , CHAR8SUPPORT)

## C11 Extension
KEYWORD(_Float16                    , KEYALL)

## ISO/IEC JTC1 SC22 WG14 N1169 Extension
KEYWORD(_Accum                      , KEYNOCXX)
KEYWORD(_Fract                      , KEYNOCXX)
KEYWORD(_Sat                        , KEYNOCXX)

## GNU Extensions (in impl-reserved namespace)
KEYWORD(_Decimal32                  , KEYALL)
KEYWORD(_Decimal64                  , KEYALL)
KEYWORD(_Decimal128                 , KEYALL)
KEYWORD(__null                      , KEYCXX)
## __alignof returns the preferred alignment of a type, the alignment
## clang will attempt to give an object of the type if allowed by ABI.
UNARY_EXPR_OR_TYPE_TRAIT(__alignof, PreferredAlignOf, KEYALL)
KEYWORD(__attribute                 , KEYALL)
KEYWORD(__builtin_choose_expr       , KEYALL)
KEYWORD(__builtin_offsetof          , KEYALL)
KEYWORD(__builtin_FILE              , KEYALL)
KEYWORD(__builtin_FUNCTION          , KEYALL)
KEYWORD(__builtin_LINE              , KEYALL)
KEYWORD(__builtin_COLUMN            , KEYALL)

## __builtin_types_compatible_p is a GNU C extension that we handle like a C++
## type trait.
TYPE_TRAIT_2(__builtin_types_compatible_p, TypeCompatible, KEYNOCXX)
KEYWORD(__builtin_va_arg            , KEYALL)
KEYWORD(__extension__               , KEYALL)
KEYWORD(__float128                  , KEYALL)
KEYWORD(__imag                      , KEYALL)
KEYWORD(__int128                    , KEYALL)
KEYWORD(__label__                   , KEYALL)
KEYWORD(__real                      , KEYALL)
KEYWORD(__thread                    , KEYALL)
KEYWORD(__FUNCTION__                , KEYALL)
KEYWORD(__PRETTY_FUNCTION__         , KEYALL)
KEYWORD(__auto_type                 , KEYALL)

## GNU Extensions (outside impl-reserved namespace)
KEYWORD(typeof                      , KEYGNU)

## MS Extensions
KEYWORD(__FUNCDNAME__               , KEYMS)
KEYWORD(__FUNCSIG__                 , KEYMS)
KEYWORD(L__FUNCTION__               , KEYMS)
KEYWORD(L__FUNCSIG__                , KEYMS)
TYPE_TRAIT_1(__is_interface_class, IsInterfaceClass, KEYMS)
TYPE_TRAIT_1(__is_sealed, IsSealed, KEYMS)

## MSVC12.0 / VS2013 Type Traits
TYPE_TRAIT_1(__is_destructible, IsDestructible, KEYMS)
TYPE_TRAIT_1(__is_trivially_destructible, IsTriviallyDestructible, KEYCXX)
TYPE_TRAIT_1(__is_nothrow_destructible, IsNothrowDestructible, KEYMS)
TYPE_TRAIT_2(__is_nothrow_assignable, IsNothrowAssignable, KEYCXX)
TYPE_TRAIT_N(__is_constructible, IsConstructible, KEYCXX)
TYPE_TRAIT_N(__is_nothrow_constructible, IsNothrowConstructible, KEYCXX)

## MSVC14.0 / VS2015 Type Traits
TYPE_TRAIT_2(__is_assignable, IsAssignable, KEYCXX)

## MSVC Type Traits of unknown vintage
TYPE_TRAIT_1(__has_nothrow_move_assign, HasNothrowMoveAssign, KEYCXX)
TYPE_TRAIT_1(__has_trivial_move_assign, HasTrivialMoveAssign, KEYCXX)
TYPE_TRAIT_1(__has_trivial_move_constructor, HasTrivialMoveConstructor, KEYCXX)

## GNU and MS Type Traits
TYPE_TRAIT_1(__has_nothrow_assign, HasNothrowAssign, KEYCXX)
TYPE_TRAIT_1(__has_nothrow_copy, HasNothrowCopy, KEYCXX)
TYPE_TRAIT_1(__has_nothrow_constructor, HasNothrowConstructor, KEYCXX)
TYPE_TRAIT_1(__has_trivial_assign, HasTrivialAssign, KEYCXX)
TYPE_TRAIT_1(__has_trivial_copy, HasTrivialCopy, KEYCXX)
TYPE_TRAIT_1(__has_trivial_constructor, HasTrivialDefaultConstructor, KEYCXX)
TYPE_TRAIT_1(__has_trivial_destructor, HasTrivialDestructor, KEYCXX)
TYPE_TRAIT_1(__has_virtual_destructor, HasVirtualDestructor, KEYCXX)
TYPE_TRAIT_1(__is_abstract, IsAbstract, KEYCXX)
TYPE_TRAIT_1(__is_aggregate, IsAggregate, KEYCXX)
TYPE_TRAIT_2(__is_base_of, IsBaseOf, KEYCXX)
TYPE_TRAIT_1(__is_class, IsClass, KEYCXX)
TYPE_TRAIT_2(__is_convertible_to, IsConvertibleTo, KEYCXX)
TYPE_TRAIT_1(__is_empty, IsEmpty, KEYCXX)
TYPE_TRAIT_1(__is_enum, IsEnum, KEYCXX)
TYPE_TRAIT_1(__is_final, IsFinal, KEYCXX)
TYPE_TRAIT_1(__is_literal, IsLiteral, KEYCXX)
## Name for GCC 4.6 compatibility - people have already written libraries using
## this name unfortunately.
ALIAS("__is_literal_type", __is_literal, KEYCXX)
TYPE_TRAIT_1(__is_pod, IsPOD, KEYCXX)
TYPE_TRAIT_1(__is_polymorphic, IsPolymorphic, KEYCXX)
TYPE_TRAIT_1(__is_standard_layout, IsStandardLayout, KEYCXX)
TYPE_TRAIT_1(__is_trivial, IsTrivial, KEYCXX)
TYPE_TRAIT_2(__is_trivially_assignable, IsTriviallyAssignable, KEYCXX)
TYPE_TRAIT_N(__is_trivially_constructible, IsTriviallyConstructible, KEYCXX)
TYPE_TRAIT_1(__is_trivially_copyable, IsTriviallyCopyable, KEYCXX)
TYPE_TRAIT_1(__is_union, IsUnion, KEYCXX)
TYPE_TRAIT_1(__has_unique_object_representations,
             HasUniqueObjectRepresentations, KEYCXX)
KEYWORD(__underlying_type           , KEYCXX)

## Clang-only C++ Type Traits
TYPE_TRAIT_2(__reference_binds_to_temporary, ReferenceBindsToTemporary, KEYCXX)

## Embarcadero Expression Traits
EXPRESSION_TRAIT(__is_lvalue_expr, IsLValueExpr, KEYCXX)
EXPRESSION_TRAIT(__is_rvalue_expr, IsRValueExpr, KEYCXX)

## Embarcadero Unary Type Traits
TYPE_TRAIT_1(__is_arithmetic, IsArithmetic, KEYCXX)
TYPE_TRAIT_1(__is_floating_point, IsFloatingPoint, KEYCXX)
TYPE_TRAIT_1(__is_integral, IsIntegral, KEYCXX)
TYPE_TRAIT_1(__is_complete_type, IsCompleteType, KEYCXX)
TYPE_TRAIT_1(__is_void, IsVoid, KEYCXX)
TYPE_TRAIT_1(__is_array, IsArray, KEYCXX)
TYPE_TRAIT_1(__is_function, IsFunction, KEYCXX)
TYPE_TRAIT_1(__is_reference, IsReference, KEYCXX)
TYPE_TRAIT_1(__is_lvalue_reference, IsLvalueReference, KEYCXX)
TYPE_TRAIT_1(__is_rvalue_reference, IsRvalueReference, KEYCXX)
TYPE_TRAIT_1(__is_fundamental, IsFundamental, KEYCXX)
TYPE_TRAIT_1(__is_object, IsObject, KEYCXX)
TYPE_TRAIT_1(__is_scalar, IsScalar, KEYCXX)
TYPE_TRAIT_1(__is_compound, IsCompound, KEYCXX)
TYPE_TRAIT_1(__is_pointer, IsPointer, KEYCXX)
TYPE_TRAIT_1(__is_member_object_pointer, IsMemberObjectPointer, KEYCXX)
TYPE_TRAIT_1(__is_member_function_pointer, IsMemberFunctionPointer, KEYCXX)
TYPE_TRAIT_1(__is_member_pointer, IsMemberPointer, KEYCXX)
TYPE_TRAIT_1(__is_const, IsConst, KEYCXX)
TYPE_TRAIT_1(__is_volatile, IsVolatile, KEYCXX)
TYPE_TRAIT_1(__is_signed, IsSigned, KEYCXX)
TYPE_TRAIT_1(__is_unsigned, IsUnsigned, KEYCXX)

## Embarcadero Binary Type Traits
TYPE_TRAIT_2(__is_same, IsSame, KEYCXX)
TYPE_TRAIT_2(__is_convertible, IsConvertible, KEYCXX)
ARRAY_TYPE_TRAIT(__array_rank, ArrayRank, KEYCXX)
ARRAY_TYPE_TRAIT(__array_extent, ArrayExtent, KEYCXX)
## Name for GCC 6 compatibility.
ALIAS("__is_same_as", __is_same, KEYCXX)

## Apple Extension.
KEYWORD(__private_extern__          , KEYALL)
KEYWORD(__module_private__          , KEYALL)

## Extension that will be enabled for Microsoft, Borland and PS4, but can be
## disabled via '-fno-declspec'.
KEYWORD(__declspec                  , 0)

## Microsoft Extension.
KEYWORD(__cdecl                     , KEYALL)
KEYWORD(__stdcall                   , KEYALL)
KEYWORD(__fastcall                  , KEYALL)
KEYWORD(__thiscall                  , KEYALL)
KEYWORD(__regcall                   , KEYALL)
KEYWORD(__vectorcall                , KEYALL)
KEYWORD(__forceinline               , KEYMS)
KEYWORD(__unaligned                 , KEYMS)
KEYWORD(__super                     , KEYMS)

## OpenCL address space qualifiers
KEYWORD(__global                    , KEYOPENCLC | KEYOPENCLCXX)
KEYWORD(__local                     , KEYOPENCLC | KEYOPENCLCXX)
KEYWORD(__constant                  , KEYOPENCLC | KEYOPENCLCXX)
KEYWORD(__private                   , KEYOPENCLC | KEYOPENCLCXX)
KEYWORD(__generic                   , KEYOPENCLC | KEYOPENCLCXX)
ALIAS("global", __global            , KEYOPENCLC | KEYOPENCLCXX)
ALIAS("local", __local              , KEYOPENCLC | KEYOPENCLCXX)
ALIAS("constant", __constant        , KEYOPENCLC | KEYOPENCLCXX)
ALIAS("private", __private          , KEYOPENCLC)
ALIAS("generic", __generic          , KEYOPENCLC | KEYOPENCLCXX)
## OpenCL function qualifiers
KEYWORD(__kernel                    , KEYOPENCLC | KEYOPENCLCXX)
ALIAS("kernel", __kernel            , KEYOPENCLC | KEYOPENCLCXX)
## OpenCL access qualifiers
KEYWORD(__read_only                 , KEYOPENCLC | KEYOPENCLCXX)
KEYWORD(__write_only                , KEYOPENCLC | KEYOPENCLCXX)
KEYWORD(__read_write                , KEYOPENCLC | KEYOPENCLCXX)
ALIAS("read_only", __read_only      , KEYOPENCLC | KEYOPENCLCXX)
ALIAS("write_only", __write_only    , KEYOPENCLC | KEYOPENCLCXX)
ALIAS("read_write", __read_write    , KEYOPENCLC | KEYOPENCLCXX)
## OpenCL builtins
KEYWORD(__builtin_astype            , KEYOPENCLC | KEYOPENCLCXX)
UNARY_EXPR_OR_TYPE_TRAIT(vec_step, VecStep, KEYOPENCLC | KEYOPENCLCXX | KEYALTIVEC | KEYZVECTOR)
#define GENERIC_IMAGE_TYPE(ImgType, Id) KEYWORD(ImgType##_t, KEYOPENCLC | KEYOPENCLCXX)
#include "clang/Basic/OpenCLImageTypes.def"
KEYWORD(pipe                        , KEYOPENCLC | KEYOPENCLCXX)
## C++ for OpenCL s2.3.1: addrspace_cast operator
KEYWORD(addrspace_cast              , KEYOPENCLCXX)

## OpenMP Type Traits
UNARY_EXPR_OR_TYPE_TRAIT(__builtin_omp_required_simd_align, OpenMPRequiredSimdAlign, KEYALL)

## Borland Extensions.
KEYWORD(__pascal                    , KEYALL)

## Altivec Extension.
KEYWORD(__vector                    , KEYALTIVEC|KEYZVECTOR)
KEYWORD(__pixel                     , KEYALTIVEC)
KEYWORD(__bool                      , KEYALTIVEC|KEYZVECTOR)

## ARM NEON extensions.
ALIAS("__fp16", half                , KEYALL)
KEYWORD(__bf16                      , KEYALL)

## OpenCL Extension.
KEYWORD(half                        , HALFSUPPORT)

## Objective-C ARC keywords.
KEYWORD(__bridge                     , KEYOBJC)
KEYWORD(__bridge_transfer            , KEYOBJC)
KEYWORD(__bridge_retained            , KEYOBJC)
KEYWORD(__bridge_retain              , KEYOBJC)

## Objective-C keywords.
KEYWORD(__covariant                  , KEYOBJC)
KEYWORD(__contravariant              , KEYOBJC)
KEYWORD(__kindof                     , KEYOBJC)

## Alternate spelling for various tokens.  There are GCC extensions in all
## languages, but should not be disabled in strict conformance mode.
ALIAS("__alignof__"  , __alignof  , KEYALL)
ALIAS("__asm"        , asm        , KEYALL)
ALIAS("__asm__"      , asm        , KEYALL)
ALIAS("__attribute__", __attribute, KEYALL)
ALIAS("__complex"    , _Complex   , KEYALL)
ALIAS("__complex__"  , _Complex   , KEYALL)
ALIAS("__const"      , const      , KEYALL)
ALIAS("__const__"    , const      , KEYALL)
ALIAS("__decltype"   , decltype   , KEYCXX)
ALIAS("__imag__"     , __imag     , KEYALL)
ALIAS("__inline"     , inline     , KEYALL)
ALIAS("__inline__"   , inline     , KEYALL)
ALIAS("__nullptr"    , nullptr    , KEYCXX)
ALIAS("__real__"     , __real     , KEYALL)
ALIAS("__restrict"   , restrict   , KEYALL)
ALIAS("__restrict__" , restrict   , KEYALL)
ALIAS("__signed"     , signed     , KEYALL)
ALIAS("__signed__"   , signed     , KEYALL)
ALIAS("__typeof"     , typeof     , KEYALL)
ALIAS("__typeof__"   , typeof     , KEYALL)
ALIAS("__volatile"   , volatile   , KEYALL)
ALIAS("__volatile__" , volatile   , KEYALL)

## Type nullability.
KEYWORD(_Nonnull                 , KEYALL)
KEYWORD(_Nullable                , KEYALL)
KEYWORD(_Nullable_result         , KEYALL)
KEYWORD(_Null_unspecified        , KEYALL)

## Microsoft extensions which should be disabled in strict conformance mode
KEYWORD(__ptr64                       , KEYMS)
KEYWORD(__ptr32                       , KEYMS)
KEYWORD(__sptr                        , KEYMS)
KEYWORD(__uptr                        , KEYMS)
KEYWORD(__w64                         , KEYMS)
KEYWORD(__uuidof                      , KEYMS | KEYBORLAND)
KEYWORD(__try                         , KEYMS | KEYBORLAND)
KEYWORD(__finally                     , KEYMS | KEYBORLAND)
KEYWORD(__leave                       , KEYMS | KEYBORLAND)
KEYWORD(__int64                       , KEYMS)
KEYWORD(__if_exists                   , KEYMS)
KEYWORD(__if_not_exists               , KEYMS)
KEYWORD(__single_inheritance          , KEYMS)
KEYWORD(__multiple_inheritance        , KEYMS)
KEYWORD(__virtual_inheritance         , KEYMS)
KEYWORD(__interface                   , KEYMS)
ALIAS("__int8"           , char       , KEYMS)
ALIAS("_int8"            , char       , KEYMS)
ALIAS("__int16"          , short      , KEYMS)
ALIAS("_int16"           , short      , KEYMS)
ALIAS("__int32"          , int        , KEYMS)
ALIAS("_int32"           , int        , KEYMS)
ALIAS("_int64"           , __int64    , KEYMS)
ALIAS("__wchar_t"        , wchar_t    , KEYMS)
ALIAS("_asm"             , asm        , KEYMS)
ALIAS("_alignof"         , __alignof  , KEYMS)
ALIAS("__builtin_alignof", __alignof  , KEYMS)
ALIAS("_cdecl"           , __cdecl    , KEYMS | KEYBORLAND)
ALIAS("_fastcall"        , __fastcall , KEYMS | KEYBORLAND)
ALIAS("_stdcall"         , __stdcall  , KEYMS | KEYBORLAND)
ALIAS("_thiscall"        , __thiscall , KEYMS)
ALIAS("_vectorcall"      , __vectorcall, KEYMS)
ALIAS("_uuidof"          , __uuidof   , KEYMS | KEYBORLAND)
ALIAS("_inline"          , inline     , KEYMS)
ALIAS("_declspec"        , __declspec , KEYMS)

## Borland Extensions which should be disabled in strict conformance mode.
ALIAS("_pascal"      , __pascal   , KEYBORLAND)

## Clang Extensions.
KEYWORD(__builtin_convertvector     , KEYALL)
ALIAS("__char16_t"   , char16_t     , KEYCXX)
ALIAS("__char32_t"   , char32_t     , KEYCXX)
KEYWORD(__builtin_bit_cast          , KEYALL)
KEYWORD(__builtin_available         , KEYALL)

## Clang-specific keywords enabled only in testing.
TESTING_KEYWORD(__unknown_anytype , KEYALL)

*/