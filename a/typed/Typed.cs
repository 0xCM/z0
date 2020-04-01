//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Typed)]

namespace Z0.Parts
{        
    public sealed class Typed : Part<Typed>
    {


    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;    

    public static partial class Typed
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;




    }

    public static partial class XTend
    {

    }

}
