//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmSigs;

    public interface IAsmRel : ITextual
    {
        RelToken Kind {get;}

        string Name {get;}

        string ITextual.Format()
            => Name;
    }

    public interface IAsmRel<T> : IAsmRel
        where T : unmanaged
    {

    }
}