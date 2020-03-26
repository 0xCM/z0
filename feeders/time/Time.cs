//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Time)]

namespace Z0.Parts
{        
    public sealed class Time : Part<Time>
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

    using static Time;

    public static class Time 
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        internal const string Kernel32 = "kernel32.dll";
        
        internal static T[] array<T>(params T[] src)
            => src;
    }
}