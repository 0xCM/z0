//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace lang
{
    public abstract class TypeDomain<T> : ITypeDomain<T>
        where T : ILang, new()
    {
        public T Lang {get;}

        protected TypeDomain()
        {
            Lang = new T();
        }
    }
}