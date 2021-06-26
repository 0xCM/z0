//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmPrefix
    {
        byte Encoded {get;}

        bit IsEmtpy => Encoded == 0;

        bit IsNonEmpty => Encoded != 0;
    }

    public interface IAsmPrefix<P> : IAsmPrefix
        where P : unmanaged
    {

    }

    public interface IAsmPrefix<P,T> : IAsmPrefix<P>
        where P : unmanaged, IAsmPrefix<P,T>
        where T : unmanaged
    {
        new T Encoded {get;}

        byte IAsmPrefix.Encoded
            => core.u8(Encoded);
    }
}