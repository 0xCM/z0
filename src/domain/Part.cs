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
    [ApiHost]
    class Runtime
    {
        [MethodImpl(Inline), Op]
        public static ref readonly PartBox box()
            => ref RT.Box;

        [MethodImpl(Inline)]
        internal static ref T slot<T>(byte index, Func<T> factory)
            => ref RT.Box.Slot(index,factory);

        [MethodImpl(Inline)]
        internal static ref T slot<T>(byte index)
            => ref RT.Box.Slot<T>(index);

        static readonly Runtime RT = new Runtime();
        
        readonly PartBox Box;

        [MethodImpl(Inline), Op]
        Runtime()
        {
            Box = new PartBox();
        }    
    }

    public static partial class XTend{}
}