//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly partial struct AsmLang
    {
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