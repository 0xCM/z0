//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using System.Reflection;
using static Z0.Part;

[assembly: AssemblyDescription("Sequences of bits covered with semantic fabric")]
[assembly: PartId(PartId.Domain)]
namespace Z0.Parts
{        
    public sealed class Domain : Part<Domain> 
    {


    }
}

namespace Z0
{
    public readonly struct Domain<T>
    {
        readonly Runtime Rt;

        [MethodImpl(Inline)]
        internal Domain(Runtime rt)
            => Rt = rt;
    }

    [ApiHost]
    public readonly partial struct Domain
    {
        readonly Runtime Rt;

        [MethodImpl(Inline), Op]
        Domain(Runtime rt)
        {
            Rt = rt;
        }

        [MethodImpl(Inline)]
        public static Domain<T> runtime<T>()
            => new Domain<T>(Parts.Domain.Resolved.Runtime);
        
        [MethodImpl(Inline), Op]
        public static Domain runtime()
            => new Domain(Parts.Domain.Resolved.Runtime);
    }
}