//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmLabel : IAsmLineToken, ITextual, INullity
    {
        Identifier Name {get;}
    }
}