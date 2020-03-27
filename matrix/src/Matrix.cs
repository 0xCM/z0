//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Matrix)]

namespace Z0.Parts
{
    public sealed class Matrix : Part<Matrix>
    {
            
        
    }
}

namespace Z0
{
    using System.Runtime.CompilerServices;

    static class Root
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;    

        public const MethodImplOptions NotInline = MethodImplOptions.NoInlining;        


    }

}