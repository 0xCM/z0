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

    using E = SpecializedImmEvent;

    public class ApiImmEmitter :  WfService<ApiImmEmitter>
    {
        IAsmContext Asm;

        IImmSpecializer Specializer;

        public ApiImmEmitter()
        {

        }

        protected override void OnInit()
        {
            Asm = AsmServices.context(Wf);
            Specializer = AsmServices.ImmSpecializer(Wf, Asm);
        }

        bool Append = true;

        public void Emit(params PartId[] parts)
        {
            var selected = parts.Length == 0 ? Wf.Api.PartIdentities : parts;
            ClearArchive(selected);
            EmitUnrefined(selected);
            EmitRefined(selected);
        }

        void ClearArchive(PartId[] parts)
        {
            if(parts.Length != 0)
                Db.ImmHostDirs(parts).Delete();
            else
                Db.ImmRoot().Delete();
        }

        void EmitLiteral(byte[] imm8, PartId[] parts)
        {
            if(imm8.Length != 0)
            {
                var exchange = Capture.exchange(Asm);
                EmitUnrefined(exchange, imm8.ToImm8Values(RefinementClass.Unrefined), parts);
            }
        }

        void EmitUnrefined(PartId[] parts)
        {
            var defaults = new byte[]{2,4,6,8};
            EmitLiteral(defaults, parts);
        }

        public void EmitRefined(PartId[] parts)
            => EmitRefined(Capture.exchange(Asm), parts);

        ParameterInfo RefiningParameter(MethodInfo src)
            => src.ImmParameters(RefinementClass.Refined).First();

        Type RefinementType(MethodInfo src)
            => src.ImmParameters(RefinementClass.Refined).First().ParameterType;

        Imm8R[] RefinedValues(MethodInfo src)
            => RefiningParameter(src).RefinedImmValues();

        void EmitDirectRefinements(in CaptureExchange exchange, IApiHost host, IAsmImmWriter dst)
        {
            var groups = ApiQuery.ImmDirect(host,RefinementClass.Refined);
            var uri = host.Uri;
            var generic = false;
            foreach(var g in groups)
            {
                var gid = g.GroupId;
                foreach(var member in g.Members.Storage)
                {
                    if(member.Method.IsVectorizedUnaryImm(RefinementClass.Refined))
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
                    else if(member.Method.IsVectorizedBinaryImm(RefinementClass.Refined))
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

        // ApiHost[] Hosts(params PartId[] parts)
        //     => (from h in Wf.Api.PartHosts(parts)
        //         where h is ApiHost
        //         select (ApiHost)h).Array();

        IApiHost[] Hosts(params PartId[] parts)
            => Wf.Api.PartHosts(parts);

        IAsmImmWriter Archive(IApiHost host)
            => AsmServices.immwriter(Wf, Asm, host.Uri);

        void EmitUnrefined(in CaptureExchange exchange, Imm8R[] imm8, params PartId[] parts)
        {
            EmitUnrefinedDirect(exchange, imm8, parts);
            EmitUnrefinedGeneric(exchange, imm8, parts);
        }

        void EmitRefined(in CaptureExchange exchange, params PartId[] parts)
        {
            var routines = root.list<AsmRoutine>();
            foreach(var host in Hosts(parts))
            {
                var archive = Archive(host);
                EmitDirectRefinements(exchange, host, archive);
                routines.AddRange(EmitGenericRefinements(exchange, host, archive));
            }
        }

        Index<AsmRoutine> EmitUnrefinedDirect(in CaptureExchange exchange, Imm8R[] imm8, params PartId[] parts)
        {
            var routines = root.list<AsmRoutine>();
            foreach(var host in Hosts(parts))
            {
                var archive = Archive(host);
                var groups = ApiQuery.ImmDirect(host, RefinementClass.Unrefined);
                routines.AddRange(EmitUnrefinedDirect(exchange, groups,imm8, archive));
            }
            return routines.ToArray();
        }

        Index<AsmRoutine> EmitUnrefinedDirect(in CaptureExchange exchange, ApiGroupNG[] groups, Imm8R[] imm8, IAsmImmWriter dst)
        {
            var routines = root.list<AsmRoutine>();
            var unary = from g in groups
                        let members = g.Members.Where(m => m.Method.IsVectorizedUnaryImm(RefinementClass.Unrefined))
                        select (g,members.Array());

            foreach(var (g,members) in unary)
                routines.AddRange(EmitUnrefinedUnary(exchange, g.GroupId, members, imm8, dst));

            var binary = from g in groups
                        let members = g.Members.Where(m => m.Method.IsVectorizedBinaryImm(RefinementClass.Unrefined))
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
                var archive = Archive(host);
                var specs = ApiQuery.ImmGeneric(host, RefinementClass.Unrefined);
                foreach(var spec in specs)
                    routines.AddRange(EmitUnrefinedGeneric(exchange, spec, imm8, archive));
            }
            return routines.ToArray();
        }

        Index<AsmRoutine> EmitGenericRefinements(in CaptureExchange exchange, IApiHost host, IAsmImmWriter dst)
        {
            var specs = ApiQuery.ImmGeneric(host, RefinementClass.Refined);
            var routines = root.list<AsmRoutine>();
            foreach(var f in specs)
            {
                if(f.Method.IsVectorizedUnaryImm(RefinementClass.Refined))
                    routines.AddRange(EmitUnary(exchange, f, RefinedValues(f.Method), dst, RefinementType(f.Method)));
                else if(f.Method.IsVectorizedBinaryImm(RefinementClass.Refined))
                    routines.AddRange(EmitBinary(exchange, f, RefinedValues(f.Method), dst, RefinementType(f.Method)));
            }
            return routines.ToArray();
        }

        Index<AsmRoutine> EmitUnrefinedGeneric(in CaptureExchange exchange, ApiMethodG src,  Imm8R[] imm8, IAsmImmWriter dst)
        {
            var routines = root.list<AsmRoutine>();
            if(src.Method.IsVectorizedUnaryImm(RefinementClass.Unrefined))
                routines.AddRange(EmitUnary(exchange, src, imm8, dst));
            else if(src.Method.IsVectorizedBinaryImm(RefinementClass.Unrefined))
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
                var uri = host.Uri;
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
                var uri = host.Uri;
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
            var uri = src.Host.Uri;
            var generic = true;
            var closures = Identity.Closures(src);
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
            var host = src.Host.Uri;
            var generic = true;
            var closures = Identity.Closures(src);
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