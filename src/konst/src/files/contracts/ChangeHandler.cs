//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using static Konst;

    partial struct FS
    {
        public delegate void ChangeHandler(FsEntry subject, ChangeKind kind);
    }
}