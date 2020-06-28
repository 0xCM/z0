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
        public void Process(X50 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X51 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X52 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X53 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X54 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X55 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X56 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X57 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X58 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X59 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X5A x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X5B x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X5C x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X5D x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X5E x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X5F x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }           
    }
}