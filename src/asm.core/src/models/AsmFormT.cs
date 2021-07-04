//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;


    public readonly struct AsmForms
    {


    }

    public readonly ref struct AsmForm
    {

        public readonly ReadOnlySpan<byte> Definition;


        [MethodImpl(Inline)]
        internal AsmForm(ReadOnlySpan<byte> def)
        {
            Definition = def;
        }

    }


    public readonly struct AsmForm<A>
        where A : unmanaged
    {

    }

    public readonly struct AsmForm<A,B>
        where A : unmanaged
        where B : unmanaged
    {

    }


}