//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct ApiQuery
    {
        public static ApiAddressRecord record(uint seq, MethodAddress src)
        {
            var dst = new ApiAddressRecord();
            var method = src.Method;
            var host = method.DeclaringType;
            var part = host.Assembly.Id();
            dst.Sequence = seq;
            dst.Address = src.Address;
            dst.HostName = host.Tag<ApiHostAttribute>().MapValueOrElse(a => text.ifempty(a.HostName, host.Name), () =>  host.Name).ToLower();
            dst.PartName = part != 0 ? part.Format() : host.Assembly.GetSimpleName();
            dst.Identifier = ApiIdentity.identify(method);
            return dst;
        }
    }
}