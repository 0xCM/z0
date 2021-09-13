//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using lang;

    public abstract class Lang<T> :  ILang
        where T : Lang<T>, new()
    {
        public LangIdentifier Identifier {get;}

        protected Lang(LangIdentifier identifier)
        {
            Identifier = identifier;
        }
    }
}