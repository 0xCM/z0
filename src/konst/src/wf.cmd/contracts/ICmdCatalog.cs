//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    public interface ICmdCatalog
    {
        IWfShell Wf {get;}
    }

    public interface ICmdCatalog<H> : ICmdCatalog
        where H : ICmdCatalog<H>, new()
    {

    }
}