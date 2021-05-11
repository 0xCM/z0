//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;

    using static Part;
    using static memory;
    using static ApiExtracts;

    partial class ApiExtractor
    {
        uint ExtractGeneric(IApiHost src, List<ApiMemberExtract> dst)
        {
            var counter = 0u;
            var methods = @readonly(ApiQuery.generic(src));
            var count = methods.Length;
            for(var i=0; i<count; i++)
                counter += ExtractGeneric(src.HostUri, skip(methods,i), dst);
            return counter;
        }

        uint ExtractGeneric(ApiHostUri host, MethodInfo src, List<ApiMemberExtract> dst)
        {
            var counter = 0u;
            var args = @readonly(ApiIdentityKinds.NumericClosureTypes(src));
            var count = args.Length;
            var @class = src.KindId();
            try
            {
                for(var i=0u; i<count; i++)
                {
                    ref readonly var arg = ref skip(args, i);
                    var constructed = src.MakeGenericMethod(arg);
                    var resolved = resolve(constructed, MemberUri(host, constructed), ApiJit.jit(constructed));
                    dst.Add(extract(resolved, Buffer));
                    counter++;
                }
            }
            catch(ArgumentException e)
            {
                var msg = string.Format("{0}: Closure creation failed for {1}/{2}", e.GetType().Name, src.DeclaringType.DisplayName(), src.DisplayName());
                Wf.Warn(msg);
                return 0;
            }
            catch(Exception e)
            {
                Wf.Warn(e.ToString());
            }
            return counter;
        }
    }
}