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
    public readonly struct LoopModels
    {
        public static void atomic(Action<int> a, Action<int> b)
        {
            for (int c0 = 0; c0 <= 10; c0 += 1)
            {
                if (c0 <= 9)
                    a(c0);
                if (c0 >= 1)
                    b(c0 - 1);
            }
        }

        public static StringAddress atomic_in()
        {
            const string s0 = "{ a[i] -> [i, 0] : 0 <= i < 10; b[i] -> [i+1, 1] : 0 <= i < 10 }";
            const string s1 = "{ : }";
            const string s2 = "{ [i, d] -> atomic[x] }";
            const string s = s0 + Eol + s1 + Eol + s2;
            return s;
        }

        public static StringAddress atomic_st()
        {
            const string s0 = "domain: \"{ a[i] : 0 <= i < 10; b[i] : 0 <= i < 10 }\"";
            const string s1 = "child:";
            const string s2 = "  schedule: \"[{ a[i] -> [i]; b[i] -> [i+1] }]\"";
            const string s3 = "options: \"{ atomic[x] }\"";
            const string s4 = "  child:";
            const string s5 = "    sequence:";
            const string s6 = "- filter: \"{ a[i] }\"";
            const string s7 = "    - filter: \"{ b[i] }\"";
            const string s = s0 + Eol + s1 + Eol + s2 + Eol + s3 + Eol + s4 + Eol + s5 + Eol + s6 + Eol + s7;
            return s;

        }

        public static string const_string_n8()
        {
            const string s0 = "";
            const string s1 = "";
            const string s2 = "";
            const string s3 = "";
            const string s4 = "";
            const string s5 = "";
            const string s6 = "";
            const string s7 = "";
            const string s = s0 + Eol + s1 + Eol + s2 + Eol + s3 + Eol + s4 + Eol + s5 + Eol + s6 + Eol + s7;
            return s;
        }

        /// <summary>
        /// isl/test_inputs/codegen/isolate5.c
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        public static void isolate5(Action<int, int> A, Action<int, int> B)
        {
            for (int c0 = 0; c0 <= 9; c0 += 1)
            {
                if ((c0 + 1) % 2 == 0)
                {
                    for (int c1 = 0; c1 <= 1; c1 += 1)
                        B((c0 - 1) / 2, c1);
                }
                else
                {
                    for (int c1 = 0; c1 <= 1; c1 += 1)
                        A(c0 / 2, c1);
                }
            }
            for (int c0 = 10; c0 <= 89; c0 += 1)
            {
                if ((c0 + 1) % 2 == 0)
                {
                    for (int c1 = 0; c1 <= 1; c1 += 1)
                        B((c0 - 1) / 2, c1);
                }
                else
                {
                    for (int c1 = 0; c1 <= 1; c1 += 1)
                        A(c0 / 2, c1);
                }
            }
            for (int c0 = 90; c0 <= 199; c0 += 1)
            {
                if ((c0 + 1) % 2 == 0)
                {
                    for (int c1 = 0; c1 <= 1; c1 += 1)
                        B((c0 - 1) / 2, c1);
                }
                else
                {
                    for (int c1 = 0; c1 <= 1; c1 += 1)
                        A(c0 / 2, c1);
                }
            }
        }
    }
}
