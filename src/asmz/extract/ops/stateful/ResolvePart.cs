//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class ApiExtractor
    {
        ResolvedPart ResolvePart(IPart src)
        {
            var flow = Wf.Running(string.Format("{0} Resolving part {1}", Worker(), src.Format()));
            var resolved = Resolver.ResolvePart(src);
            Receivers.Raise(new PartResolvedEvent(resolved));
            Wf.Ran(flow, string.Format("{0} Resloved {1} methods from {2}", Worker(), resolved.MethodCount, src.Format()));
            return resolved;
        }

        ResolvedPart ResolvePart(PartId src)
        {
            var flow = Wf.Running(string.Format("{0} Resolving part {1}", Worker(), src.Format()));
            var resolved = Resolver.ResolvePart(src);
            Receivers.Raise(new PartResolvedEvent(resolved));
            Wf.Ran(flow, string.Format("{0} Resolved {1} methods from {2}", Worker(), resolved.MethodCount, src.Format()));
            return resolved;
        }
    }
}