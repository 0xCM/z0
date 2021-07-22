//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Emu
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct CpuModels
    {
        public static CpuCore<T> core<T>(uint id)
            where T : unmanaged
                => new CpuCore<T>(id);

        public static Stack<T> stack<T>(CpuMachine<T> m, uint capacity)
            where T : unmanaged
        {
            var buffer = allocate<T>(m,capacity);
            return new Stack<T>(buffer);
        }

        public static T[] allocate<T>(CpuMachine<T> m, uint count)
            where T : unmanaged
        {
            return alloc<T>(count);
        }

        public static CpuModel<T> cpu<T>(uint cores)
            where T : unmanaged
                => new CpuModel<T>(alloc<CpuCore<T>>(cores));
    }
}