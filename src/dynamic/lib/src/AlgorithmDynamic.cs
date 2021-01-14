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

    using static Part;
    using static z;
    using static Iteratees;

    using static SFx;

    [ApiHost(ApiNames.Algorithms, true)]
    public readonly partial struct AlgorithmDynamic
    {
        [MethodImpl(Inline), Op]
        public static unsafe DynamicAction action(string id, ReadOnlySpan<byte> f)
            => action(id, memory.liberate(f));

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

        [MethodImpl(Inline)]
        public static void spin<F,T>(F f, T m, T n, T p)
            where F : IAction<T,T,T>
            where T : unmanaged
        {
            if(size<T>() == 1)
                iter8u(f,m,n,p);
            else if(size<T>() == 2)
                iter16u(f,m,n,p);
            if(size<T>() == 4)
                iter32u(f,m,n,p);
            else if(size<T>() == 8)
                iter64u(f,m,n,p);
        }

        [MethodImpl(Inline), Op]
        public static Triple<uint> iter(Iteratee32 target)
        {
            iter_32u(target, 25u, 50u, 75u);
            return target.Current;
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public void iter<T>(Iteratee<T> target, T m, T n, T p)
            where T : unmanaged
        {
            spin(target,m,n,p);
        }

        [MethodImpl(Inline)]
        static void invoke<F,T>(F f, byte i, byte j, byte k)
            where T : unmanaged
            where F : IAction<T,T,T>
        {
            ref readonly var _i = ref @as<byte,T>(i);
            ref readonly var _j = ref @as<byte,T>(j);
            ref readonly var _k = ref @as<byte,T>(k);
            f.Invoke(_i, _j, _k);
        }

        [MethodImpl(Inline)]
        static void invoke<F,T>(F f, ushort i, ushort j, ushort k)
            where T : unmanaged
            where F : IAction<T,T,T>
        {
            ref readonly var _i = ref @as<ushort,T>(i);
            ref readonly var _j = ref @as<ushort,T>(j);
            ref readonly var _k = ref @as<ushort,T>(k);
            f.Invoke(_i, _j, _k);
        }

        [MethodImpl(Inline)]
        static void invoke<F,T>(F f, uint i, uint j, uint k)
            where T : unmanaged
            where F : IAction<T,T,T>
        {
            ref readonly var _i = ref @as<uint,T>(i);
            ref readonly var _j = ref @as<uint,T>(j);
            ref readonly var _k = ref @as<uint,T>(k);
            f.Invoke(_i, _j, _k);
        }

        [MethodImpl(Inline)]
        static void invoke<F,T>(F f, ulong i, ulong j, ulong k)
            where T : unmanaged
            where F : IAction<T,T,T>
        {
            ref readonly var _i = ref @as<ulong,T>(i);
            ref readonly var _j = ref @as<ulong,T>(j);
            ref readonly var _k = ref @as<ulong,T>(k);
            f.Invoke(_i, _j, _k);
        }

        [MethodImpl(Inline)]
        static void iter8u<F,T>(F f, T m, T n, T p)
            where F : IAction<T,T,T>
            where T : unmanaged
        {
            ref readonly var _m = ref @as<T,byte>(m);
            ref readonly var _n = ref @as<T,byte>(n);
            ref readonly var _p = ref @as<T,byte>(p);

            for(byte i=0; i<_m; i++)
            for(byte j=0; j<_n; j++)
            for(byte k=0; k<_p; k++)
                invoke<F,T>(f,i,j,k);
        }

        [MethodImpl(Inline)]
        static void iter16u<F,T>(F f, T m, T n, T p)
            where F : IAction<T,T,T>
            where T : unmanaged
        {
            ref readonly var _m = ref @as<T,ushort>(m);
            ref readonly var _n = ref @as<T,ushort>(n);
            ref readonly var _p = ref @as<T,ushort>(p);

            for(ushort i=0; i<_m; i++)
            for(ushort j=0; j<_n; j++)
            for(ushort k=0; k<_p; k++)
                invoke<F,T>(f,i,j,k);
        }

        [MethodImpl(Inline)]
        static void iter32u<F,T>(F f, T m, T n, T p)
            where F : IAction<T,T,T>
            where T : unmanaged
        {
            ref readonly var _m = ref @as<T,uint>(m);
            ref readonly var _n = ref @as<T,uint>(n);
            ref readonly var _p = ref @as<T,uint>(p);

            for(uint i=0; i<_m; i++)
            for(uint j=0; j<_n; j++)
            for(uint k=0; k<_p; k++)
                invoke<F,T>(f,i,j,k);
        }

        [MethodImpl(Inline)]
        static void iter64u<F,T>(F f, T m, T n, T p)
            where F : IAction<T,T,T>
            where T : unmanaged
        {
            ref readonly var _m = ref @as<T,ulong>(m);
            ref readonly var _n = ref @as<T,ulong>(n);
            ref readonly var _p = ref @as<T,ulong>(p);

            for(ulong i=0; i<_m; i++)
            for(ulong j=0; j<_n; j++)
            for(ulong k=0; k<_p; k++)
                invoke<F,T>(f,i,j,k);
        }
    }
}