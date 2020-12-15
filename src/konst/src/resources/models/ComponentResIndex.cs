//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct ComponentResIndex
    {
        public readonly Assembly Owner;

        public readonly ResDeclarations[] Declarations;

        [MethodImpl(Inline)]
        public ComponentResIndex(Assembly src, ResDeclarations[] declarations)
        {
            Owner = src;
            Declarations = declarations;
        }
    }
}