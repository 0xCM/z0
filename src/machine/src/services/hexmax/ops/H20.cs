//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static Konst;
    using static HexLevel;
    using static Typed;
    using static V0;
    using static V0d;

    partial struct HexMax
    {
        [MethodImpl(Inline)]
        public void Process(X20 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X21 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X22 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X23 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X24 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X25 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X26 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X27 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X28 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X29 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X2A x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X2B x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X2C x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X2D x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X2E x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X2F x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }           


    }
}