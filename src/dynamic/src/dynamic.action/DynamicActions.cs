//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Emit;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct DynamicActions
    {
        public static unsafe ActionDelegate define(string id, ReadOnlySpan<byte> f)
            => define(id, Buffers.liberate(f));

        public static unsafe ActionDelegate define(string id, MemoryAddress f)
        {
            var tFunc = typeof(Action);
            var method = new DynamicMethod(id, null, null, tFunc.Module);
            var g = method.GetILGenerator();
            g.Emit(OpCodes.Ldc_I8, f);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, null, null);
            g.Emit(OpCodes.Ret);
            return new ActionDelegate(id, f, method, (Action)method.CreateDelegate(tFunc));
        }
    }
}