//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;
    using static Memories;
    using static AsmEvents;

    public interface IImmEmitter : IService
    {
        AsmEmissionToken[] Emit(params byte[] immediates);
    }

    public class ImmEmitter : IImmEmitter
    {                
        public static IImmEmitter Create(IContext context, IApiSet api, IAsmFunctionDecoder decoder, FolderPath dst)        
            => new ImmEmitter(context, decoder, api, dst);

        readonly IContext Context;

        readonly IApiSet ApiSet;

        readonly IApiCollector ApiCollector;

        readonly RootEmissionPaths Paths;

        readonly IImmSpecializer ImmSpecializer;

        readonly List<AsmEmissionToken> Tokens;

        ImmEmitter(IContext context, IAsmFunctionDecoder decoder, IApiSet api, FolderPath root)
        {
            Context = context;
            ImmSpecializer = context.ImmSpecializer(decoder);
            ApiSet = api;
            Tokens = new List<AsmEmissionToken>();
            Paths = RootEmissionPaths.Define(root);
            Paths.Clear();
            ApiCollector = context.ApiCollector();
        }

        public AsmEmissionToken[] Emit(params byte[] imm8)
            => EmitImm(Context.ExtractExchange(OnCapture), imm8);

        void OnCapture(in AsmCaptureEvent data)
        {

        }

        IEnumerable<IApiHost> ApiHosts => ApiSet.Hosts;

        IAsmFunctionArchive Archive(IApiHost host)
            => Context.ImmFunctionArchive(host.UriPath, Paths.RootDir);

        AsmEmissionToken[] EmitImm(in OpExtractExchange exchange, byte[] imm8)
        {
            EmitDirectImm(exchange, imm8);
            EmitGenericImm(exchange, imm8);
            return Tokens.ToArray();
        }

        DirectApiGroup ImmGroup(IApiHost host, DirectApiGroup g)
            => DirectApiGroup.Define(host, g.GroupId, g.Members.Where(m => m.Method.AcceptsImmediate() && m.Method.ReturnsVector()));

        IEnumerable<DirectApiGroup> DirectImmGroups(IApiHost host)
            => from g in ApiCollector.CollectDirect(host)
                let immg = ImmGroup(host, g)
                where !immg.IsEmpty
                select g;
        
        void EmitDirectImm(in OpExtractExchange exchange, byte[] imm8)
        {
            foreach(var host in ApiHosts)
            {
                var archive = Archive(host);
                var groups = DirectImmGroups(host);
                foreach(var g in groups)
                    EmitDirectImm(exchange, g, imm8, archive);
            }
        }

        void EmitDirectImm(in OpExtractExchange exchange, DirectApiGroup op, byte[] imm8, IAsmFunctionArchive dst)
        {
            var tokens = new List<AsmEmissionToken>();
            foreach(var member in op.Members.Where(m => m.Method.IsVectorizedUnaryImm()))
            {
                var functions = ImmSpecializer.UnaryOps(exchange, member.Method, member.Id, imm8);
                if(functions.Length != 0)
                {
                    var tGroup = dst.Save(AsmFunctionGroup.Define(op.GroupId, functions), true);
                    tGroup.OnSome(t => tokens.AddRange(t.Content)).OnSome(Accept);
                }
            }

            foreach(var member in op.Members.Where(m => m.Method.IsVectorizedBinaryImm()))
            {
                var functions = ImmSpecializer.BinaryOps(exchange, member.Method, member.Id, imm8);
                if(functions.Length != 0)
                {
                    var tGroup = dst.Save(AsmFunctionGroup.Define(op.GroupId, functions), true);
                    tGroup.OnSome(t => tokens.AddRange(t.Content)).OnSome(Accept);
                }
            }
        }

        void EmitGenericImm(in OpExtractExchange exchange, byte[] imm8)
        {        
            foreach(var host in ApiHosts)
            {
                var archive = Archive(host);
                var specs = ApiCollector.CollectGeneric(host).Where(op => op.Method.AcceptsImmediate());

                foreach(var spec in specs)
                    EmitGenericImm(exchange, spec, imm8, archive); 
            }        
        }

        void EmitGenericImm(in OpExtractExchange exchange, GenericApiOp op,  byte[] imm8, IAsmFunctionArchive dst)
        {
            if(op.Method.IsVectorizedUnaryImm())
            {                                                
                foreach(var closure in op.Close())
                {
                    var functions = ImmSpecializer.UnaryOps(exchange, closure.Method, closure.Id, imm8);
                    if(functions.Length != 0)
                        dst.Save(AsmFunctionGroup.Define(op.GenericId, functions), true);
                }
            }
            else if(op.Method.IsVectorizedBinaryImm())
            {
                foreach(var closure in op.Close())
                {
                    var functions = ImmSpecializer.BinaryOps(exchange, closure.Method, closure.Id, imm8);
                    if(functions.Length != 0)
                        dst.Save(AsmFunctionGroup.Define(op.GenericId, functions), true);
                }
            }
        }



        [MethodImpl(Inline)]
        void Accept(AsmEmissionTokens<OpUri> src) => Tokens.AddRange(src);
    }
}