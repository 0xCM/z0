//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static core;

    using Svc = Z0;

    public static partial class XSvc
    {
       public static AsciByteSpans AsciByteSpans(this IServiceContext context)
            => Svc.AsciByteSpans.create(context);

       public static IndexRender IndexRender(this IServiceContext context)
            => Svc.IndexRender.create(context);
    }
}