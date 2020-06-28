//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
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

    partial struct HM
    {
        [MethodImpl(Inline)]
        public void Process(X60 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X61 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X62 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X63 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X64 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X65 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X66 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X67 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X68 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X69 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X6A x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X6B x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X6C x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X6D x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X6E x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X6F x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }           
    }
}