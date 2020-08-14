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
    using static RenderPatterns;

    partial struct Flow    
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string format<T>(T content)        
            => text.format(Slot0, content);

        [MethodImpl(Inline)]
        public static string format<T0,T1>(T0 x0, T1 x1)        
            where T0 : ITextual
            where T1 : ITextual
                => string.Format(PSx2, x0.Format(),  x1.Format());
                
        [MethodImpl(Inline)]
        public static string format<T0,T1,T2>(T0 x0, T1 x1, T2 x2)        
            where T0 : ITextual
            where T1 : ITextual
            where T2 : ITextual
                => string.Format(PSx3, x0.Format(), x1.Format(), x2.Format());                

        [MethodImpl(Inline)]
        public static string format<T0,T1,T2,T3>(T0 x0, T1 x1, T2 x2, T3 x3)        
            where T0 : ITextual
            where T1 : ITextual
            where T2 : ITextual
            where T3 : ITextual
                => string.Format(PSx4, x0.Format(), x1.Format(), x2.Format(), x3.Format());

        [MethodImpl(Inline)]
        public static string format<T0,T1,T2,T3,T4>(T0 x0, T1 x1, T2 x2, T3 x3,T4 x4)        
            where T0 : ITextual
            where T1 : ITextual
            where T2 : ITextual
            where T3 : ITextual
            where T4 : ITextual
                => string.Format(PSx5, x0.Format(), x1.Format(), x2.Format(), x3.Format(), x0.Format());

        public static void format(in WfError<Exception> error, StringBuilder dst)
        {        
            const string ErrorTrace = "{0} | {1} | {2} | Outer | {3} | {4} | {5}";            
            const string InnerTrace = "{0} | {1} | {2} | Inner | {3} | {4} | {5} | {6}";

            var exception = error.Data;
            var eType = exception.GetType();
            var outer = string.Format(ErrorTrace, error.EventId, error.Actor, error.Source, eType.Name, exception.Message, exception.StackTrace);
            dst.AppendLine(outer);
            
            int level = 0;

            var e = exception.InnerException;
            while (e != null)
            {
                dst.AppendLine(string.Format(InnerTrace, error.EventId, error.Actor, error.Source, level, eType.Name, e.Message, e.StackTrace));
                e = e.InnerException;
                level += 1;
            }
        }
    }
}