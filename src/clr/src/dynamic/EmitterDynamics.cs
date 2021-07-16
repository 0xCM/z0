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

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct EmitterDynamics
    {
        const NumericKind Closure = UInt64k;

        [Op, Closures(Closure)]
        public static unsafe Emitter<T> create<T>(Identifier name, byte* pCode)
            => create<T>(name, (MemoryAddress)pCode, out _);

        [Op, Closures(Closure)]
        public static unsafe Emitter<T> create<T>(OpIdentity id, ReadOnlySpan<byte> code)
            => create<T>(id.Format(), Buffers.liberate(code), out _);

        [Op, Closures(Closure)]
        public static unsafe Emitter<T> create<T>(Identifier name, ReadOnlySpan<byte> f)
            => create<T>(name, (MemoryAddress)Buffers.liberate(f), out _);

        [MethodImpl(Inline), Closures(Closure)]
        public static T eval<T>(Identifier name, ReadOnlySpan<byte> f)
            where T : unmanaged
                => create<T>(name, f)();

        static unsafe Emitter<T> create<T>(Identifier name, MemoryAddress f, out DynamicMethod method)
        {
            var tFunc = typeof(Emitter<T>);
            var tReturn = typeof(T);
            method = new DynamicMethod(name, tReturn, null, typeof(int).Module);
            var g = method.GetILGenerator();
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, tReturn, null);
            g.Emit(OpCodes.Ret);
            return (Emitter<T>)CellDelegate.define(name, f, method, method.CreateDelegate(tFunc));
        }
    }
}