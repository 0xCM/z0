//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial interface IWfShell
    {
        IRuntimeArchive RuntimeArchive()
            => Archives.runtime(this);
    }
}