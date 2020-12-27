//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    public readonly struct ApiComponent
    {
        public Assembly Assembly {get;}

        public FS.FilePath Location {get;}

        public PartId Id {get;}

        [MethodImpl(Inline)]
        public ApiComponent(Assembly src)
        {
            Assembly = src;
            Location = FS.path(Assembly.Location);
            Id = Assembly.Id();
        }
    }
}