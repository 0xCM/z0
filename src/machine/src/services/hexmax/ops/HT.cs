//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    partial struct HexMax
    {
        [Op, Closures(UInt64k)]
        public void Process<T>(X00 x, in T src)
            where T : struct
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X01 x, in T src)
            where T : struct
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X02 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X03 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X04 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X05 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X06 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X07 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X08 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X09 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X0A x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X0B x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X0C x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X0D x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X0E x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X0F x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X10 x, in T src)
            where T : struct
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X11 x, in T src)
            where T : struct
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X12 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X13 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X14 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X15 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X16 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X17 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X18 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X19 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X1A x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X1B x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X1C x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X1D x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X1E x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X1F x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X20 x, in T src)
            where T : struct
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X21 x, in T src)
            where T : struct
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X22 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X23 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X24 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X25 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X26 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X27 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X28 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X29 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X2A x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X2B x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X2C x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X2D x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X2E x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X2F x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X30 x, in T src)
            where T : struct
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X31 x, in T src)
            where T : struct
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X32 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X33 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X34 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X35 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X36 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X37 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X38 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X39 x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X3A x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X3B x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X3C x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X3D x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X3E x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }

        [Op, Closures(UInt64k)]
        public void Process<T>(X3F x, in T src)
        {
            State = vadd(State, vbroadcast(w128, (byte)x));
        }
    }
}