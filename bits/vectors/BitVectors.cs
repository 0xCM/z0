//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.BitVectors)]

namespace Z0.Parts
{        
    public sealed class BitVectors : Part<BitVectors>
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

    using static Core;    

    [ApiHost("api")]
    public static partial class BitVector 
    {   

        [MethodImpl(Inline)]
        internal static Span<byte> bytes<T>(T src)
            where T : struct
                => Bytes.from(src);
    }
}