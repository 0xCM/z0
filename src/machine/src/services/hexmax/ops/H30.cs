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
    using static Typed;
    using static V0;
    using static V0d;

    partial struct HexMax
    {
        [MethodImpl(Inline)]
        public void Process(X30 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X31 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X32 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X33 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X34 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X35 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X36 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X37 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X38 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X39 x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X3A x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X3B x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X3C x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X3D x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X3E x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [MethodImpl(Inline)]
        public void Process(X3F x)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }           
    }
}