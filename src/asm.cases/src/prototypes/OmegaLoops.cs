//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;


    [ApiComplete]
    public unsafe readonly struct OmegaModels
    {
        public unsafe readonly struct Receivers
        {
            [MethodImpl(Inline)]
            public static Receiver1 create(int* pDst0)
                => new Receiver1(pDst0);

            [MethodImpl(Inline)]
            public static Receiver2 create(int* pDst0, int* pDst1)
                => new Receiver2(pDst0, pDst1);
        }

        public unsafe struct Receiver1
        {
            readonly int* Dst0;

            int I;

            [MethodImpl(Inline)]
            public Receiver1(int* pDst0)
            {
                Dst0 = pDst0;
                I = 0;
            }

            [MethodImpl(Inline)]
            public void Receive(int c0)
            {
                Dst0[I++] = c0;
            }

            public int ReceiptCount
            {
                [MethodImpl(Inline)]
                get => I;
            }
        }

        public unsafe struct Receiver2
        {
            readonly int* Dst0;

            readonly int* Dst1;

            int I;

            [MethodImpl(Inline)]
            public Receiver2(int* pDst0, int* pDst1)
            {
                Dst0 = pDst0;
                Dst1 = pDst1;
                I = 0;
            }

            [MethodImpl(Inline)]
            public void Receive(int c0, int c1)
            {
                Dst0[I] = c0;
                Dst1[I] = c1;
                I++;
            }

            public int ReceiptCount
            {
                [MethodImpl(Inline)]
                get => I;
            }
        }

        public enum ModelId : uint
        {
            None = 0,

            basics_0,
        }

        public static StringAddress basics_0()
        {
            return
@"{ s0[In_1] -> [In_1] : (In_1 >= 5 and In_1 <= 8) or (exists (e0 = [(In_1)/2]: 2e0 = In_1 and In_1 >= 10 and In_1 <= 16)) or (In_1 >= 20 and In_1 <= 25) }
{  :  }
{ [i0] -> separate[o0] : o0 >= 0; [i0] -> atomic[o0] : o0 <= -1 }
";
        }

        public static void basics_0(Action<int> s0)
        {
            for (int c0 = 5; c0 <= 8; c0 += 1)
                s0(c0);
            for (int c0 = 10; c0 <= 16; c0 += 2)
                s0(c0);
            for (int c0 = 20; c0 <= 25; c0 += 1)
                s0(c0);
        }

        /// <summary>
        /// isl/test_inputs/codegen/omega/basics-0.c
        /// </summary>
        /// <param name="s0"></param>
        public static void basics_0(ref Receiver1 s0)
        {
            for (int c0 = 5; c0 <= 8; c0 += 1)
                s0.Receive(c0);
            for (int c0 = 10; c0 <= 16; c0 += 2)
                s0.Receive(c0);
            for (int c0 = 20; c0 <= 25; c0 += 1)
                s0.Receive(c0);
        }

        public static int basics_0(int* pDst0)
        {
            var receiver = Receivers.create(pDst0);
            basics_0(ref receiver);
            return receiver.ReceiptCount;
        }

        public static StringAddress code_gen_0()
        {
            return @"{ s1[In_1, In_2] -> [In_1, In_2] : In_1 >= 2 and In_1 <= 6 and In_2 >= 0 and In_2 <= 4; s0[In_1, In_2] -> [In_1, In_2] : In_1 >= 1 and In_2 >= -1 + In_1 and In_2 <= 7 }
{  :  }
{ [i0, i1] -> atomic[o0] : o0 <= 1; [i0, i1] -> separate[o0] : o0 >= 2 }
";
        }

        public static void code_gen_0(Action<int,int> s0, Action<int,int> s1)
        {
            for (int c0 = 1; c0 <= 8; c0 += 1)
            for (int c1 = 0; c1 <= 7; c1 += 1) {
                if (c0 >= 2 && c0 <= 6 && c1 <= 4)
                s1(c0, c1);
                if (c1 + 1 >= c0)
                s0(c0, c1);
            }
        }

        public static void code_gen_0(ref Receiver2 s0, ref Receiver2 s1)
        {
            for (int c0 = 1; c0 <= 8; c0 += 1)
            for (int c1 = 0; c1 <= 7; c1 += 1) {
                if (c0 >= 2 && c0 <= 6 && c1 <= 4)
                s0.Receive(c0, c1);
                if (c1 + 1 >= c0)
                s0.Receive(c0, c1);
            }
        }

        public static Pair<int> code_gen_0(int* pDst00, int* pDst01, int* pDst10, int* pDst11)
        {
            var s0 = Receivers.create(pDst00, pDst01);
            var s1 = Receivers.create(pDst10, pDst11);
            code_gen_0(ref s0, ref s1);
            return (s0.ReceiptCount, s1.ReceiptCount);
        }
    }
}