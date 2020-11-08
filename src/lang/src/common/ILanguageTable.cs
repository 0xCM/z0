//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ILanguageTable
    {

    }

    [Free]
    public interface ILanguageTable<R> : ILanguageTable
        where R : struct, ILanguageTable<R>
    {

    }
}