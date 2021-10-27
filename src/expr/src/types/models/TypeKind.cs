//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Types
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct TypeKind : IExpr
    {
        string Data {get;}

        [MethodImpl(Inline)]
        public TypeKind(string spec)
        {
            Data = spec;
        }

        public string Spec
        {
            [MethodImpl(Inline)]
            get => Data ?? EmptyString;
        }

        public string Format()
            => Spec;

        public override string ToString()
            => Format();
    }
}