//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;


    public static class Gates
    {
        [MethodImpl(Inline)]
        public static ref readonly AndGate and()
            => ref AndGate.Gate;

        [MethodImpl(Inline)]
        public static ref readonly XOrGate xor()
            => ref XOrGate.Gate;
            
        [MethodImpl(Inline)]
        public static ref readonly AndGate<T> and<T>()
            where T : unmanaged
                => ref AndGate<T>.Gate;

        [MethodImpl(Inline)]
        public static ref readonly OrGate<T> or<T>()
            where T : unmanaged
                => ref OrGate<T>.Gate;

        [MethodImpl(Inline)]
        public static ref readonly XOrGate<T> xor<T>()
            where T : unmanaged
                => ref XOrGate<T>.Gate;

        [MethodImpl(Inline)]
        public static ref readonly NotGate<T> not<T>()
            where T : unmanaged
                => ref NotGate<T>.Gate;

        [MethodImpl(Inline)]
        public static ref readonly NandGate<T> nand<T>()
            where T : unmanaged
                => ref NandGate<T>.Gate;

        [MethodImpl(Inline)]
        public static ref readonly NorGate<T> norg<T>()
            where T : unmanaged
                => ref NorGate<T>.Gate;

        [MethodImpl(Inline)]
        public static ref readonly XnorGate<T> xnor<T>()
            where T : unmanaged
                => ref XnorGate<T>.Gate;

        [MethodImpl(Inline)]
        public static ref readonly MuxGate<T> mux<T>()
            where T : unmanaged
                => ref MuxGate<T>.Gate;

    }

}