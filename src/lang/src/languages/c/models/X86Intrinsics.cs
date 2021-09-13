//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace lang.c
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0;
    using static Z0.core;
    using static Z0.Root;

    public sealed class X86Domain : X86Domain<CLang>
    {
        readonly Index<TypeDef> Defs;

        public X86Domain()
        {
            Defs = alloc<TypeDef>(25);
        }

        public override ReadOnlySpan<TypeDef> TypeDefs
        {
            [MethodImpl(Inline)]
            get => Defs.View;
        }
    }
}