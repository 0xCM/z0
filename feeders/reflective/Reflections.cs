//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Reflective)]

namespace Z0.Parts
{        
    public sealed class Reflective : Part<Reflective>
    {


    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    public static partial class Reflective
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
    }

    public static partial class XTend
    {

    }

}
