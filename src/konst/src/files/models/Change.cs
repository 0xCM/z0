//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    partial struct FS
    {
        public struct Change
        {
            public PathPart ObjectName {get;}

            public FS.ObjectKind ObjectKind {get;}

            public FS.ChangeKind ChangeKind {get;}

            public Change(PathPart name, FS.ObjectKind objkind, FS.ChangeKind kind)
            {
                ChangeKind = kind;
                ObjectKind = objkind;
                ObjectName = name;
            }
        }
    }
}