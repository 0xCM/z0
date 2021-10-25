//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    public abstract class EbnfRule: IProduction
    {
        public Label Name {get;}

        public EbnfInstance Grammar {get;}

        protected EbnfRule(EbnfInstance g)
        {
            Grammar = g;
        }

        public string Format()
        {
            return string.Empty;
        }
    }

    public abstract class EnbfRule<T> : EbnfRule
        where T : IExpr
    {
        protected EnbfRule(EbnfInstance g)
            : base(g)
        {

        }

        public abstract T Term {get;}
    }
}