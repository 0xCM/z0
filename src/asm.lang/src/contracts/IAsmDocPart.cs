//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface IAsmDocPart : ITextual
    {
        AsmDocPartKind Kind {get;}
    }

    public interface IAsmDocPart<T> : IAsmDocPart
        where T : IAsmDocPart<T>
    {

    }
}