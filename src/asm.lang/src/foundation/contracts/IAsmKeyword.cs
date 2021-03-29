//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Z0.Lang;

    public interface IAsmKeyword : IKeyword
    {

    }

    public interface IAsmKeyword<T,K> : IAsmKeyword, IKeyword<AsmLang,K>
        where T : unmanaged, IAsmKeyword<T,K>
        where K : unmanaged
    {

    }
}