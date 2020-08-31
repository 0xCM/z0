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

    public readonly struct ResDeclarationIndex
    {
        public readonly Assembly Owner;

        public readonly ResourceDeclarations[] Declarations;

        [MethodImpl(Inline)]
        public ResDeclarationIndex(Assembly src, ResourceDeclarations[] declarations)
        {
            Owner = src;
            Declarations = declarations;
        }

        public Type[] Hosts
        {
            [MethodImpl(Inline)]
            get => Declarations.Select(x => x.DeclaringType);
        }
    }
}