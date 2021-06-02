//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Reflection;

    using static Root;
    using static FS;

    public abstract class AsciLineProcessor<T> : TextProcessor<T>
    {
        protected AsciLineProcessor(IEventSink sink)
            : base(sink)
        {
        }

    }
}