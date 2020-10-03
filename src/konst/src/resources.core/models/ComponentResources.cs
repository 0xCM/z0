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

    public readonly struct ComponentResources
    {
        public readonly Assembly Owner;

        public readonly ResourceDeclarations[] Declarations;

        [MethodImpl(Inline)]
        public ComponentResources(Assembly src, ResourceDeclarations[] declarations)
        {
            Owner = src;
            Declarations = declarations;
        }
    }
}