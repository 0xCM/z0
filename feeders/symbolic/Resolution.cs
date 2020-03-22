//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Symbolic)]

namespace Z0.Parts
{
    public sealed class Symbolic : Resolution<Symbolic> {  }
}

namespace Z0
{
    using System.Runtime.CompilerServices;
    
    public static class Symbolic
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    }
}