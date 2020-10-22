//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using SQ = AsmSizeQualifiers;

    [ApiHost]
    public readonly partial struct AsmLang
    {
        public static SQ.Byte @byte()
            => default;

        public static SQ.Word word()
            => default;

        public static SQ.DWord dword()
            => default;

        public static SQ.QWord qword()
            => default;

        public static SQ.XmmWord xmmword()
            => default;

        public static SQ.YmmWord ymmword()
            => default;

        public static SQ.ZmmWord zmmword()
            => default;

        [MethodImpl(Inline), Op]
        public static AsmTokens tokens(in AsmTokenIndex index)
            => new AsmTokens(index);

        [MethodImpl(Inline), Op]
        public static string definition(in AsmTokens tokens, AsmTokenKind id)
            => tokens.Definitions[(int)id];

        [MethodImpl(Inline), Op]
        public static string meaning(in AsmTokens tokens, AsmTokenKind id)
            => tokens.Meanings[(int)id];

        [MethodImpl(Inline), Op]
        public static ref readonly TokenRecord token(in AsmTokens tokens, AsmTokenKind id)
            => ref tokens.Models[(int)id];

        [MethodImpl(Inline), Op]
        public static string identifier(in AsmTokens tokens, AsmTokenKind id)
            => tokens.Identity[id];

        public interface IElement : ITextual
        {
            string RenderPattern {get;}
        }

        public interface IElement<T> : IElement
        {

        }

        public interface IElement<H,T> : IElement
            where H : IElement<H,T>
        {

        }


        public interface ISyntaxAtom : IElement
        {

        }

        public interface ISyntaxAtom<K> : ISyntaxAtom
            where K : unmanaged
        {
            K Code {get;}

            string ITextual.Format()
                => string.Format(RenderPattern,Code);

            string IElement.RenderPattern
                => "{0:g}";
        }

        public interface ISyntaxAtom<H,K> : ISyntaxAtom<K>, IElement<H,K>
            where K : unmanaged
            where H : struct, ISyntaxAtom<H,K>
        {

        }

        public interface IExpression : IElement
        {

        }

        public interface IExpression<T> : IExpression
        {
            T Subject {get;}

            string ITextual.Format()
                => string.Format(RenderPattern, Subject);
        }

        public interface IExpression<H,T> : IExpression<T>
            where H : struct, IExpression<H,T>
        {

        }
    }
}