//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmCodes;

    public interface IAsmRel : ITextual
    {
        RelKind Kind {get;}

        string Name {get;}

        string ITextual.Format()
            => Name;
    }

    public interface IAsmRel<T> : IAsmRel
        where T : unmanaged
    {

    }
}