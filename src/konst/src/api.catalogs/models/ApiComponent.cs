//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    public readonly struct ApiComponent
    {
        public Assembly Assembly {get;}

        [MethodImpl(Inline)]
        public ApiComponent(Assembly src)
            => Assembly = src;

        public FS.FilePath Location
            => FS.path(Assembly.Location);

        public PartId Id
            => Assembly.Id();
    }
}