//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct LlvmTypes
    {
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct dag<O,A0> : IDag<dag<O,A0>,O>
            where O : unmanaged
            where A0 : unmanaged
        {
            public O Operator;

            internal Ptr<A0> p0;

            [MethodImpl(Inline)]
            internal dag(O op, Ptr<A0> p0)
            {
                Operator = op;
                this.p0 = p0;
            }

            public uint StorageSize
            {
                [MethodImpl(Inline)]
                get => size<dag<O,A0>>();
            }

            public ref A0 Arg0
            {
                [MethodImpl(Inline)]
                get => ref p0[0];
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct dag<O,A0,A1> : IDag<dag<O,A0,A1>,O>
            where O : unmanaged
            where A0 : unmanaged
            where A1 : unmanaged
        {
            public O Operator;

            internal Ptr<A0> p0;

            internal Ptr<A1> p1;

            [MethodImpl(Inline)]
            internal dag(O op, Ptr<A0> p0, Ptr<A1> p1)
            {
                Operator = op;
                this.p0 = p0;
                this.p1 = p1;
            }

            public uint StorageSize
            {
                [MethodImpl(Inline)]
                get => size<dag<O,A0,A1>>();
            }

            public ref A0 Arg0
            {
                [MethodImpl(Inline)]
                get => ref p0[0];
            }

            public ref A1 Arg1
            {
                [MethodImpl(Inline)]
                get => ref p1[0];
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct dag<O,A0,A1,A2> : IDag<dag<O,A0,A1,A2>,O>
            where O : unmanaged
            where A0 : unmanaged
            where A1 : unmanaged
            where A2 : unmanaged
        {
            public O Operator;

            internal Ptr<A0> p0;

            internal Ptr<A1> p1;

            internal Ptr<A2> p2;

            [MethodImpl(Inline)]
            internal dag(O op, Ptr<A0> p0, Ptr<A1> p1, Ptr<A2> p2)
            {
                Operator = op;
                this.p0 = p0;
                this.p1 = p1;
                this.p2 = p2;
            }

            public uint StorageSize
            {
                [MethodImpl(Inline)]
                get => size<dag<O,A0,A1,A2>>();
            }

            public ref A0 Arg0
            {
                [MethodImpl(Inline)]
                get => ref p0[0];
            }

            public ref A1 Arg1
            {
                [MethodImpl(Inline)]
                get => ref p1[0];
            }

            public ref A2 Arg2
            {
                [MethodImpl(Inline)]
                get => ref p2[0];
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct dag<O,A0,A1,A2,A3> : IDag<dag<O,A0,A1,A2,A3>,O>
            where O : unmanaged
            where A0 : unmanaged
            where A1 : unmanaged
            where A2 : unmanaged
            where A3 : unmanaged
        {
            public O Operator;

            internal Ptr<A0> p0;

            internal Ptr<A1> p1;

            internal Ptr<A2> p2;

            internal Ptr<A3> p3;

            [MethodImpl(Inline)]
            internal dag(O op, Ptr<A0> p0, Ptr<A1> p1, Ptr<A2> p2, Ptr<A3> p3)
            {
                Operator = op;
                this.p0 = p0;
                this.p1 = p1;
                this.p2 = p2;
                this.p3 = p3;
            }


            public uint StorageSize
            {
                [MethodImpl(Inline)]
                get => size<dag<O,A0,A1,A2,A3>>();
            }

            public ref A0 Arg0
            {
                [MethodImpl(Inline)]
                get => ref p0[0];
            }

            public ref A1 Arg1
            {
                [MethodImpl(Inline)]
                get => ref p1[0];
            }

            public ref A2 Arg2
            {
                [MethodImpl(Inline)]
                get => ref p2[0];
            }

            public ref A3 Arg3
            {
                [MethodImpl(Inline)]
                get => ref p3[0];
            }
        }
    }
}