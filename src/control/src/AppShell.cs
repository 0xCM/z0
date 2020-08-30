//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    readonly struct AppShell
    {
        public const PartId Id = PartId.Control;

        public const string AppName = nameof(PartId.Control);

        public const string ActorName = AppName + "/" + nameof(App);
    }
}