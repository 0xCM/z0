//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public readonly struct Production<T> : IProduction<T>
        where T : IExpr
    {
        public Label Name {get;}

        public T Rhs {get;}

        [MethodImpl(Inline)]
        public Production(Label name, T exp)
        {
            Name = name;
            Rhs = exp;
        }

        public string Format()
            => lang.format(this);

        public override string ToString()
            => Format();
    }
}