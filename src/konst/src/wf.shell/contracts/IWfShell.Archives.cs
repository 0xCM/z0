//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial interface IWfShell
    {
        IRuntimeArchive RuntimeArchive()
            => WfShell.RuntimeArchive(this);
    }
}