//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.IO;

    using static zfunc;

    /// <summary>
    /// Encloses a pointer to the native definition of a dynamic delegate
    /// </summary>
    public unsafe readonly struct DynamicPointer
    {
        [MethodImpl(Inline)]
        public DynamicPointer(DynamicDelegate dynamicOp, byte* pointer)
        {
            Pointer = pointer;
            Op = dynamicOp;
        }

        readonly DynamicDelegate Op;

        public readonly byte* Pointer;

        public Delegate DynamicOp 
            => Op.DynamicOp;
        public MethodInfo SourceMethod
            => Op.SourceMethod;

        public MethodInfo DynamicMethod
            => Op.DynamicMethod;
    }
}