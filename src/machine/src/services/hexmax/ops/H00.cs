//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.InteropServices;
    using NativeCallers = System.Runtime.InteropServices.AllowReversePInvokeCallsAttribute;

    using static Konst;
    using static z;

    partial struct HexMax
    {
        [MethodImpl(Inline), NativeCallers]
        public void Process(X01 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline), NativeCallers]
        public void Process(X02 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline), NativeCallers]
        public void Process(X03 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline), NativeCallers]
        public void Process(X04 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline), NativeCallers]
        public void Process(X05 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline), NativeCallers]
        public void Process(X06 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline), NativeCallers]
        public void Process(X07 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline), NativeCallers]
        public void Process(X08 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline), NativeCallers]
        public void Process(X09 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline), NativeCallers]
        public void Process(X0A x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline), NativeCallers]
        public void Process(X0B x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline), NativeCallers]
        public void Process(X0C x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline), NativeCallers]
        public void Process(X0D x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline), NativeCallers]
        public void Process(X0E x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline), NativeCallers]
        public void Process(X0F x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }
    }
}