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
    using static Iteratees;
    using static SFx;

    [ApiHost]
    public readonly partial struct AlgorithmDynamic
    {
        [MethodImpl(Inline), Op]
        public static unsafe DynamicAction action(string id, ReadOnlySpan<byte> f)
            => action(id, Buffers.liberate(f));

        [MethodImpl(Inline), Op]
        public static unsafe DynamicAction action(string id, MemoryAddress f)
        {
            var tFunc = typeof(Action);
            var method = new DynamicMethod(id, null, null, tFunc.Module);
            var g = method.GetILGenerator();
            g.Emit(OpCodes.Ldc_I8, f);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, null, null);
            g.Emit(OpCodes.Ret);
            return new DynamicAction(id, f, method, (Action)method.CreateDelegate(tFunc));
        }

        [MethodImpl(Inline)]
        public static void iter<F>(F f, uint m)
            where F : IAction<uint>
        {
            for(var i=0u; i<m; i++)
                f.Invoke(i);
        }

        [MethodImpl(Inline)]
        public static void iter<F>(F f, uint m, uint n)
            where F : IAction<uint,uint>
        {
            for(var i=0u; i<m; i++)
            for(var j=0u; j<n; j++)
                f.Invoke(i,j);
        }

        [MethodImpl(Inline)]
        public static void iter_32u<F>(F f, uint m, uint n, uint p)
            where F : IAction<uint,uint,uint>
        {
            for(var i=0u; i<m; i++)
            for(var j=0u; j<n; j++)
            for(var k=0u; k<p; k++)
                f.Invoke(i,j,k);
        }

        [MethodImpl(Inline), Op]
        public static Triple<uint> iter(Iteratee32 target)
        {
            iter_32u(target, 25u, 50u, 75u);
            return target.Current;
        }
    }
}