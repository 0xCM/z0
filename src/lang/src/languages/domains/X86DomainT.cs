//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace lang
{
    using System;

    using Z0;

    public abstract class X86Domain<T> : TypeDomain<T>
        where T : ILang, new()
    {
        protected X86Domain()
        {

        }

        public abstract ReadOnlySpan<TypeDef> TypeDefs {get;}
    }
}