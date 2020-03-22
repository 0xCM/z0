//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Components)]

namespace Z0.Parts
{        
    public sealed class Components : Part<Components>
    {


    }
}

//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static class Components
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        internal static NotSupportedException unsupported<T>()
            => new NotSupportedException($"The type {typeof(T).Name} is not supported in the current context");
    }

}
