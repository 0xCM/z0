//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmLayoutPart
    {
        AsmLayoutPart Kind {get;}
    }

    public interface IAsmLayoutPart<T> : IAsmLayoutPart
        where T : unmanaged, IAsmLayoutPart<T>
    {

    }
}