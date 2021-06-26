//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Text;
    using System.Runtime.CompilerServices;

    using C = AsciCode;

    public readonly partial struct AsmProcessors
    {
       public static MsgPattern<C> MarkerCodeNotFound => "Markier '{0}' not found";
    }
}