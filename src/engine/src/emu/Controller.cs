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

    public readonly struct Controller
    {
        public static Core<T> core<T>(uint id)
            where T : unmanaged
                => new Core<T>(id);

        public static Stack<T> stack<T>(Machine<T> m, uint capacity)
            where T : unmanaged
        {
            var buffer = allocate<T>(m,capacity);
            return new Stack<T>(buffer);
        }

        public static T[] allocate<T>(Machine<T> m, uint count)
            where T : unmanaged
        {
            return alloc<T>(count);
        }

        public static Cpu<T> cpu<T>(uint cores)
            where T : unmanaged
                => new Cpu<T>(alloc<Core<T>>(cores));

        public static Machine<T> machine<T>(Cpu<T> cpu)
            where T : unmanaged
                => new Machine<T>(cpu);
    }
}