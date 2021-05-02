//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static memory;

    using E = SpecializedImmEvent;

    public class ApiImmEmitter :  AppService<ApiImmEmitter>
    {
        const uint BufferSize = Pow2.T16;

        ImmSpecializer Specializer;

        AsmFormatter Formatter;

        Index<byte> Buffer;

        public ApiImmEmitter()
        {
            Buffer = alloc<byte>(BufferSize);
        }

        protected override void OnInit()
        {
            Specializer = Wf.ImmSpecializer();
            Formatter = Wf.AsmFormatter();
        }

        bool Append = true;

        public void Emit(params PartId[] parts)
        {
            var selected = parts.Length == 0 ? Wf.ApiCatalog.PartIdentities : parts;
            ClearArchive(selected);
            EmitUnrefined(selected);
            EmitRefined(selected);
        }

        public void Emit(ReadOnlySpan<ApiHostUri> hosts)
        {
            var count = hosts.Length;
            var exchange = Exchange;
            for(var i=0; i<count; i++)
            {
                ref readonly var uri = ref skip(hosts,i);
                var host = Wf.ApiCatalog.FindHost(uri);
                if(host)
                {
                    var dst = Archive(uri);
                    EmitDirectRefinements(exchange, host.Value, dst);
                    EmitGenericRefinements(exchange, host.Value, dst);
                }
            }
        }

        void ClearArchive(PartId[] parts)
        {
            if(parts.Length != 0)
                Db.ImmHostDirs(parts).Delete();
            else
                Db.ImmCaptureRoot().Delete();
        }

        void EmitLiteral(byte[] imm8, PartId[] parts)
        {
            if(imm8.Length != 0)
            {
                EmitUnrefined(Exchange, imm8.ToImm8Values(ImmRefinementKind.Unrefined), parts);
            }
        }

        void EmitUnrefined(PartId[] parts)
        {
            var defaults = new byte[]{2,4,6,8};
            EmitLiteral(defaults, parts);
        }

        CaptureExchange Exchange
            => Capture.exchange(Buffer.Storage);

        public void EmitRefined(PartId[] parts)
            => EmitRefined(Exchange, parts);

        ParameterInfo RefiningParameter(MethodInfo src)
            => src.ImmParameters(ImmRefinementKind.Refined).First();

        Type RefinementType(MethodInfo src)
            => src.ImmParameters(ImmRefinementKind.Refined).First().ParameterType;

        Imm8R[] RefinedValues(MethodInfo src)
            => RefiningParameter(src).RefinedImmValues();

        void EmitDirectRefinements(in CaptureExchange exchange, IApiHost host, IAsmImmWriter dst)
        {
            var groups = ApiQuery.imm(host,ImmRefinementKind.Refined);
            var uri = host.HostUri;
            var generic = false;
            foreach(var g in groups)
            {
                var gid = g.GroupId;
                foreach(var member in g.Members.Storage)
                {
                    if(member.Method.IsVectorizedUnaryImm(ImmRefinementKind.Refined))
                    {
                        var imm8 = RefinedValues(member.Method);
                        if(imm8.Length != 0)
                        {
                            var rft = RefinementType(member.Method);
                            var functions = Specializer.UnaryOps(exchange, member.Method, member.Id, imm8);
                            if(functions.Length != 0)
                            {
                                var hex = dst.SaveHexImm(gid, functions, Append, true);
                                Wf.Raise(E.refined(Host, uri, generic, rft, hex.Location, Wf.Ct));

                                dst.SaveAsmImm(gid, functions, Append, true)
                                    .OnSome(path => Wf.Raise(E.refined(Host, uri, generic, rft, path, Wf.Ct)));
                            }
                        }
                    }
                    else if(member.Method.IsVectorizedBinaryImm(ImmRefinementKind.Refined))
                    {
                        var values = RefinedValues(member.Method);
                        if(values.Length != 0)
                        {
                            var rft = RefinementType(member.Method);
                            var functions = Specializer.BinaryOps(exchange, member.Method, member.Id, values);
                            if(functions.Length != 0)
                            {
                                var hex = dst.SaveHexImm(gid, functions, Append, true);
                                Wf.Raise(E.refined(Host, uri, generic, rft, hex.Location, Wf.Ct));

                                dst.SaveAsmImm(gid, functions, Append, true)
                                    .OnSome(path => Wf.Raise(E.refined(Host, uri, generic, rft, path, Wf.Ct)));
                            }
                        }
                    }
                }
            }
        }

        IApiHost[] Hosts(params PartId[] parts)
            => Wf.ApiCatalog.PartHosts(parts);

        IAsmImmWriter Archive(in ApiHostUri host)
            => Wf.ImmWriter(host, Formatter);

        void EmitUnrefined(in CaptureExchange exchange, Imm8R[] imm8, PartId[] parts)
        {
            EmitUnrefinedDirect(exchange, imm8, parts);
            EmitUnrefinedGeneric(exchange, imm8, parts);
        }

        void EmitRefined(in CaptureExchange exchange, params PartId[] parts)
        {
            var routines = root.list<AsmRoutine>();
            foreach(var host in Hosts(parts))
            {
                var archive = Archive(host.HostUri);
                EmitDirectRefinements(exchange, host, archive);
                routines.AddRange(EmitGenericRefinements(exchange, host, archive));
            }
        }

        Index<AsmRoutine> EmitUnrefinedDirect(in CaptureExchange exchange, Imm8R[] imm8, PartId[] parts)
        {
            var routines = root.list<AsmRoutine>();
            foreach(var host in Hosts(parts))
            {
                var archive = Archive(host.HostUri);
                var groups = ApiQuery.imm(host, ImmRefinementKind.Unrefined);
                routines.AddRange(EmitUnrefinedDirect(exchange, groups,imm8, archive));
            }
            return routines.ToArray();
        }

        Index<AsmRoutine> EmitUnrefinedDirect(in CaptureExchange exchange, ApiGroupNG[] groups, Imm8R[] imm8, IAsmImmWriter dst)
        {
            var routines = root.list<AsmRoutine>();
            var unary = from g in groups
                        let members = g.Members.Where(m => m.Method.IsVectorizedUnaryImm(ImmRefinementKind.Unrefined))
                        select (g,members.Array());

            foreach(var (g,members) in unary)
                routines.AddRange(EmitUnrefinedUnary(exchange, g.GroupId, members, imm8, dst));

            var binary = from g in groups
                        let members = g.Members.Where(m => m.Method.IsVectorizedBinaryImm(ImmRefinementKind.Unrefined))
                        select (g,members.Array());

            foreach(var (g,members) in binary)
                routines.AddRange(EmitUnrefinedBinary(exchange, g.GroupId, members, imm8, dst));
            return routines.ToArray();
        }

        Index<AsmRoutine> EmitUnrefinedGeneric(in CaptureExchange exchange, Imm8R[] imm8, params PartId[] parts)
        {
            var routines = root.list<AsmRoutine>();
            foreach(var host in Hosts(parts))
            {
                var archive = Archive(host.HostUri);
                var specs = ApiQuery.immG(host, ImmRefinementKind.Unrefined);
                foreach(var spec in specs)
                    routines.AddRange(EmitUnrefinedGeneric(exchange, spec, imm8, archive));
            }
            return routines.ToArray();
        }

        Index<AsmRoutine> EmitGenericRefinements(in CaptureExchange exchange, IApiHost host, IAsmImmWriter dst)
        {
            var specs = ApiQuery.immG(host, ImmRefinementKind.Refined);
            var routines = root.list<AsmRoutine>();
            foreach(var f in specs)
            {
                if(f.Method.IsVectorizedUnaryImm(ImmRefinementKind.Refined))
                    routines.AddRange(EmitUnary(exchange, f, RefinedValues(f.Method), dst, RefinementType(f.Method)));
                else if(f.Method.IsVectorizedBinaryImm(ImmRefinementKind.Refined))
                    routines.AddRange(EmitBinary(exchange, f, RefinedValues(f.Method), dst, RefinementType(f.Method)));
            }
            return routines.ToArray();
        }

        Index<AsmRoutine> EmitUnrefinedGeneric(in CaptureExchange exchange, ApiMethodG src,  Imm8R[] imm8, IAsmImmWriter dst)
        {
            var routines = root.list<AsmRoutine>();
            if(src.Method.IsVectorizedUnaryImm(ImmRefinementKind.Unrefined))
                routines.AddRange(EmitUnary(exchange, src, imm8, dst));
            else if(src.Method.IsVectorizedBinaryImm(ImmRefinementKind.Unrefined))
                routines.AddRange(EmitBinary(exchange, src, imm8, dst));

            return routines.ToArray();
        }

        Index<AsmRoutine> EmitUnrefinedUnary(in CaptureExchange exchange, OpIdentity gid, ApiMethodNG[] methods, Imm8R[] imm8, IAsmImmWriter dst)
        {
            var generic = false;
            var routines = root.list<AsmRoutine>();
            foreach(var f in methods)
            {
                var host = f.Host;
                var uri = host.HostUri;
                var functions = Specializer.UnaryOps(exchange, f.Method, f.Id, imm8);
                if(functions.Length != 0)
                {
                    var hex = dst.SaveHexImm(gid, functions, Append, false);
                    Wf.Raise(E.literal(Host, uri, generic, hex.Location, Wf.Ct));

                    dst.SaveAsmImm(gid, functions, Append, false).OnSome(path => Wf.Raise(E.literal(Host, uri, generic, path, Wf.Ct)));
                    routines.AddRange(functions);
                }
            }
            return routines.ToArray();
        }

        Index<AsmRoutine> EmitUnrefinedBinary(in CaptureExchange exchange, OpIdentity gid, ApiMethodNG[] methods, Imm8R[] imm8, IAsmImmWriter dst)
        {
            var generic = false;
            var routines = root.list<AsmRoutine>();
            foreach(var f in methods)
            {
                var host = f.Host;
                var uri = host.HostUri;
                var functions = Specializer.BinaryOps(exchange, f.Method, f.Id, imm8);
                if(functions.Length != 0)
                {
                    var hex = dst.SaveHexImm(gid, functions, Append, false);
                    Wf.Raise(E.literal(Host, uri, generic, hex.Location, Wf.Ct));

                    dst.SaveAsmImm(gid, functions, Append, false).OnSome(path => Wf.Raise(E.literal(Host, uri, generic, path, Wf.Ct)));
                    routines.AddRange(functions);
                }
            }
            return routines.ToArray();
        }

        Index<AsmRoutine> EmitUnary(in CaptureExchange exchange, ApiMethodG src, Imm8R[] imm8, IAsmImmWriter dst, Type refinement = null)
        {
            var gid = src.Id;
            var uri = src.Host.HostUri;
            var generic = true;
            var closures = ApiIdentity.closures(src);
            var count = closures.Length;
            var routines = root.list<AsmRoutine>();
            foreach(var closure in closures)
            {
                var functions = Specializer.UnaryOps(exchange, closure.Method, closure.Id, imm8);
                if(functions.Length != 0)
                {
                    var hex = dst.SaveHexImm(gid, functions, Append, refinement != null);
                    Wf.Raise(E.literal(Host, uri, generic, hex.Location, Wf.Ct));

                    dst.SaveAsmImm(gid, functions, Append, refinement != null).OnSome(path => Wf.Raise(E.define(Host, uri, generic, path, refinement, Wf.Ct)));
                    routines.AddRange(functions);
                }
            }
            return routines.ToArray();
        }

        Index<AsmRoutine> EmitBinary(in CaptureExchange exchange, ApiMethodG src, Imm8R[] imm8, IAsmImmWriter dst, Type refinement = null)
        {
            var gid = src.Id;
            var host = src.Host.HostUri;
            var generic = true;
            var closures = ApiIdentity.closures(src);
            var count = closures.Length;
            var routines = root.list<AsmRoutine>();

            foreach(var closure in closures)
            {
                var functions = Specializer.BinaryOps(exchange, closure.Method, closure.Id, imm8);
                if(functions.Length != 0)
                {
                    var hex = dst.SaveHexImm(gid, functions, Append, refinement != null);
                    Wf.Raise(E.define(Host, host, generic, hex.Location, refinement, Wf.Ct));

                    dst.SaveAsmImm(gid, functions, Append, refinement != null).OnSome(path => Wf.Raise(E.define(Host, host, generic, path, refinement, Wf.Ct)));
                    routines.AddRange(functions);
                }
            }
            return routines.ToArray();
        }
    }
}