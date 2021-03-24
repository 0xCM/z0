//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmOpContent : ISized
    {
        dynamic Content {get;}
    }

    public interface IAsmOpContent<T> : IAsmOpContent
        where T : struct
    {
        new T Content {get;}

        dynamic IAsmOpContent.Content
            => Content;
    }

    public interface IAsmOpContent<W,T> : IAsmOpContent<T>
        where T : struct
        where W : unmanaged
    {

    }
}