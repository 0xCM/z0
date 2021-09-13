//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct LangIdentifier
    {
        public StringAddress Name {get;}

        public LangKind Kind {get;}

        [MethodImpl(Inline)]
        public LangIdentifier(LangKind kind, string name)
        {
            Name = name;
            Kind = kind;
        }
    }
}