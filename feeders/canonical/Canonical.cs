//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Canonical)]

namespace Z0.Parts
{        
    public sealed class Canonical : Resolution<Canonical>
    {

    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static class Canonical
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    }

    public static partial class CanonicalOps    
    {

    }
}
