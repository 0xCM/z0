//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Collections.Concurrent;

    using static Konst;
    using static Root;

    partial class TestApp<A>
    {
        static IEnumerable<IAppMsg> FormatErrors(string name, Exception e)
        {
            if(e.InnerException is ClaimException claim)
                yield return claim.Message;            
            else if(e.InnerException is AppException app)
                yield return app.Message;
            else if(e.InnerException != null)               
                yield return AppMsg.NoCaller($"{e}",AppMsgKind.Error);
            else
                yield return AppMsg.NoCaller($"{name} failed {e}", AppMsgKind.Error);
        }

        static IEnumerable<IAppMsg> FormatErrors(Exception e, MethodInfo method)
        {
            var casename = OpUriBuilder.TestCase(method);            
            if(e is TargetInvocationException i)
            {
                foreach(var m in FormatErrors(e.InnerException, method))
                    yield return m;
            } 
            else if(e.InnerException is ClaimException claim)
                yield return claim.Message;            
            else if(e.InnerException is AppException app)
                yield return app.Message;
            else if(e.InnerException != null)               
                yield return AppMsg.NoCaller($"{e}", AppMsgKind.Error);
            else
            {
                var reason = e.Message;
                var title = text.concat("fail".PadRight(10), Space, FieldDelimiter, Space, casename.PadRight(48), Space, FieldDelimiter, Space, reason);
                var content = text.build();
                content.AppendLine(title);
                content.AppendLine(e.StackTrace);                
                var payload = content.ToString();
                yield return AppMsg.NoCaller(payload, AppMsgKind.Error);                                          
            }
         }
    }
}