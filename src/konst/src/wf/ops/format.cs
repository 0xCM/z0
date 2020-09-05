//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    partial struct Flow
    {
        [MethodImpl(Inline), Op]
        public static string format(WfType t)
            => text.format("{0} -> {1}", t.Source.Name, t.Target.Name);

        public static void format(WfError<Exception> error, StringBuilder dst)
        {
            const string ErrorTrace = "{0} | {1} | {2} | Outer | {3} | {4} | {5}";
            const string InnerTrace = "{0} | {1} | {2} | Inner | {3} | {4} | {5} | {6}";

            var exception = error.Data;
            var eType = exception.GetType();
            var outer = string.Format(ErrorTrace, error.EventId, error.Actor, error.Source, eType.Name, exception.Data.Message, exception.Data.StackTrace);
            dst.AppendLine(outer);

            int level = 0;

            var e = exception.Data.InnerException;
            while (e != null)
            {
                dst.AppendLine(string.Format(InnerTrace, error.EventId, error.Actor, error.Source, level, eType.Name, e.Message, e.StackTrace));
                e = e.InnerException;
                level += 1;
            }
        }
    }
}