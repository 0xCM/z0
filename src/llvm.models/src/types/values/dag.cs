//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Types;

    partial struct Values
    {
        [MethodImpl(Inline)]
        public static string format<O,A0>(in dag<O,A0> src)
            where O : unmanaged
            where A0 : unmanaged
        {
            const string Pattern = "({0} {1})";
            return string.Format(Pattern, src.Operator, src.Arg0);
        }

        [MethodImpl(Inline)]
        public static string format<O,A0,A1>(in dag<O,A0,A1> src)
            where O : unmanaged
            where A0 : unmanaged
            where A1 : unmanaged
        {
            const string Pattern = "({0} {1},{2})";
            return string.Format(Pattern, src.Operator, src.Arg0, src.Arg1);
        }

        [MethodImpl(Inline)]
        public static string format<O,A0,A1,A2>(in dag<O,A0,A1,A2> src)
            where O : unmanaged
            where A0 : unmanaged
            where A1 : unmanaged
            where A2 : unmanaged
        {
            const string Pattern = "({0} {1},{2},{3})";
            return string.Format(Pattern, src.Operator, src.Arg0, src.Arg1, src.Arg2);
        }

        [MethodImpl(Inline)]
        public static string format<O,A0,A1,A2,A3>(in dag<O,A0,A1,A2,A3> src)
            where O : unmanaged
            where A0 : unmanaged
            where A1 : unmanaged
            where A2 : unmanaged
            where A3 : unmanaged
        {
            const string Pattern = "({0} {1},{2},{3})";
            return string.Format(Pattern, src.Operator, src.Arg0, src.Arg1, src.Arg2, src.Arg3);
        }

        [MethodImpl(Inline)]
        public static dag<T> dag<T>(T def)
            where T : unmanaged, IDag
                => new dag<T>(def);

        [MethodImpl(Inline)]
        public static unsafe dag<O,A0> dag<O,A0>(O op, A0* p0)
            where O : unmanaged
            where A0 : unmanaged
                => new dag<O,A0>(op,p0);

        [MethodImpl(Inline)]
        public static unsafe dag<O,A0,A1> dag<O,A0,A1>(O op, A0* p0, A1* p1)
            where O : unmanaged
            where A0 : unmanaged
            where A1 : unmanaged
                => new dag<O,A0,A1>(op,p0,p1);

        [MethodImpl(Inline)]
        public static unsafe dag<O,A0,A1,A2> dag<O,A0,A1,A2>(O op, A0* p0, A1* p1, A2* p2)
            where O : unmanaged
            where A0 : unmanaged
            where A1 : unmanaged
            where A2 : unmanaged
                => new dag<O,A0,A1,A2>(op,p0,p1,p2);

        [MethodImpl(Inline)]
        public static unsafe dag<O,A0,A1,A2,A3> dag<O,A0,A1,A2,A3>(O op, A0* p0, A1* p1, A2* p2, A3* p3)
            where O : unmanaged
            where A0 : unmanaged
            where A1 : unmanaged
            where A2 : unmanaged
            where A3 : unmanaged
                => new dag<O,A0,A1,A2,A3>(op,p0,p1,p2,p3);
    }
}