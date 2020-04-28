//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Reflection;
    
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Z0.Asm;

    using static Seed;
    using static Z0.Memories;
    using static Z0.BufferSeqId;

    using K = Kinds;
    using Z0;

    public class AsmChecks : ITestAsm
    {
        public static AsmChecks Create(IAsmContext context)
            => new AsmChecks(context);

        public IAsmContext Context {get;}

        public IBufferToken[] Buffers {get;}

        readonly BufferAllocation BufferAlloc;

        public ICaptureExchange CaptureExchange {get;}

        AsmChecks(IAsmContext context)
        {
            Context = context;
            Buffers = BufferSeq.alloc(context.DefaultBufferLength, 5, out BufferAlloc).Tokenize();
            CaptureExchange = CaptureExchangeProxy.Create(Context.CaptureService, Buffers[(int)Aux3], Buffers[(int)Aux4]);
        }                

        public void Dispose()
        {
            BufferAlloc.Dispose();            
        }

        ICheckVectors Claim => CheckVectors.Checker;

        ITestAsm Me => this;

        ICaptureArchive CodeArchive => Me.CaptureArchive(ExecutingApp);

        protected IBitArchiveWriter HexWriter([Caller] string caller = null)
        {            
            var dstPath = CodeArchive.HexPath(FileName.Define($"{caller}", FileExtensions.Hex));
            return Archives.Services.BitArchiveWriter(dstPath);
        }

        protected IAsmFunctionWriter AsmWriter([Caller] string caller = null)
        {
            var dst = CodeArchive.AsmPath(FileName.Define($"{caller}", FileExtensions.Asm));
            var format = AsmFormatSpec.WithFunctionTimestamp;
            return AsmCore.Services.AsmWriter(dst,format);
        }

        static K.BinaryOpClass Binary => default;
                
        IAsmFunctionDecoder Decoder => Context.Decoder;


        [MethodImpl(Inline)]
        static Func<Vector256<T>,Vector256<T>> shuffler<T>(N2 n)
            where T : unmanaged
                => x => gvec.vshuf4x32<T>(x, Arrange4L.AABB);

        [MethodImpl(Inline)]
        static Func<Vector256<uint>, Vector256<uint>> shuffler(N3 n)
            => v => Avx2.Shuffle(v, (byte)Arrange4L.ABCD);

        void capture_shuffler(in BufferSeq buffers)
        {
            var f = shuffler<uint>(n2);
            var g = shuffler(n3);

            using var hexout = HexWriter();
            using var asmout = AsmWriter();         
    
            //var exchange = CaptureExchange.Create(CaptureControl, buffers[Left], buffers[Right]);

            var fCaptured = Me.Capture(f.Identify(), f).Require();
            hexout.WriteHex(fCaptured.Code);
            asmout.WriteAsm(Decoder.Decode(fCaptured).Require());

            var gCaptured = Me.Capture(g.Identify(), g).Require();
            hexout.WriteHex(gCaptured.Code);
            asmout.WriteAsm(Decoder.Decode(gCaptured).Require());
        }
                

        // void CheckImm(in BufferSeq buffers, in CaptureExchange exchange)
        // {
        //     CheckBinaryImm<uint>(buffers, exchange, w128, nameof(dvec.vblend4x32), (byte)Blend4x32.LRLR);    
        //     CheckBinaryImm<uint>(buffers, exchange, w128, nameof(dvec.vblend8x32), (byte)Blend8x32.LRLRLRLR);    
        //     CheckUnaryImm<ushort>(buffers, exchange, w256, nameof(dvec.vbsll), 3);        
        // }

        TestCaseRecord TestVectorMatch(in BufferSeq buffers, string name, TypeWidth w, NumericKind kind)
        {
            var catalog = PartId.GVec;
            
            var idD = Identify.Op(name, w, kind, false);
            var idG = Identify.Op(name, w, kind, true);

            var d = Me.HostBits(catalog, ApiHost.Create<dvec>().UriPath).Read(idD).Single();
            var g = Me.HostBits(catalog, ApiHost.Create<gvec>().UriPath).Read(idG).Single();

            return Me.Match(buffers, Binary, w,d,g);
        }

        public TestCaseRecord[] vector_bitlogic_match(in BufferSeq buffers)
        {
            var names = array("vxor", "vand", "vor", "vnor", "vxnor", "vnand", "vcimpl");
            var kinds = NumericKind.Integers.DistinctKinds();
            var widths = array(TypeWidth.W128, TypeWidth.W256);
            var dst = new TestCaseRecord[names.Length * widths.Length * kinds.Count];
            var i = 0;
            foreach(var n in names)
            foreach(var w in widths)
            foreach(var k in kinds)
                dst[i++] =TestVectorMatch(buffers, n, w, k);                        
            return dst;
        }




    #if Megacheck

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, BinaryOp<byte> primal, BinaryOp<byte> generic, NK<byte> kind)
        {
            var results = list<TestCaseRecord>();
            var w = w8;
            var id = Identify.NumericOp(name, kind, false);
            
            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w,ReadAsm(PartId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, BinaryOp<sbyte> primal, BinaryOp<sbyte> generic, 
            NK<sbyte> kind)
        {
            var results = list<TestCaseRecord>();

            var w = w8;
            var id = Identify.NumericOp(name, kind, false);
            
            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, in IdentifiedCode dCode, in IdentifiedCode gCode, 
            BinaryOp<sbyte> primal, BinaryOp<sbyte> generic, NK<sbyte> kind)
        {
            var results = list<TestCaseRecord>();

            var w = w8;

            var id = Identify.NumericOp(name, kind, false);
            var f0 = primal.ToFixed();

            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w, dCode);
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, gCode);
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, 
            BinaryOp<ushort> primal, BinaryOp<ushort> generic, NK<ushort> kind)
        {
            var results = list<TestCaseRecord>();

            var w = w16;

            var id = Identify.NumericOp(name, kind, false);
            var f0 = primal.ToFixed();

            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, 
            BinaryOp<short> primal, BinaryOp<short> generic, NK<short> kind)
        {
            var results = list<TestCaseRecord>();

            var w = w16;
            var id = Identify.NumericOp(name, kind, false);
            
            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, 
            BinaryOp<uint> primal, BinaryOp<uint> generic, NK<uint> kind)
        {
            var results = list<TestCaseRecord>();

            var w = w32;
            var id = Identify.NumericOp(name, kind, false);
            
            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, 
            BinaryOp<int> primal, BinaryOp<int> generic, NK<int> kind)
        {
            var results = list<TestCaseRecord>();

            var w = w32;
            var id = Identify.NumericOp(name, kind, false);

            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, 
            BinaryOp<long> primal, BinaryOp<long> generic, NK<long> kind)
        {            
            var results = list<TestCaseRecord>();

            var w = w64;
            var id = Identify.NumericOp(name, kind, false);
            
            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        protected TestCaseRecord[] megacheck(in BufferSeq buffers, string name, 
            BinaryOp<ulong> primal, BinaryOp<ulong> generic, U64 kind)
        {            
            var results = list<TestCaseRecord>();

            var w = w64;
            var id = Identify.Op(name, kind, false);
            
            var f0 = primal.ToFixed();
            var f1 = generic.ToFixed();
            results.Add(CheckMatch(f0, id, f1, id.WithGeneric()));

            var f2 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, Math, id));
            results.Add(CheckMatch(f0, id, f2, id.WithAsm()));

            var f3 = buffers[Main].EmitFixedBinaryOp(w, ReadAsm(PartId.GMath, GMath, id.WithGeneric()));
            results.Add(CheckMatch(f0, id, f3, id.WithGeneric().WithAsm()));

            return results.ToArray();
        }

        public void add_megacheck(in BufferSeq buffers)
        {
            var name = nameof(math.add);

            var dSrc = ApiHostUri.FromHost(typeof(math));
            var gSrc = ApiHostUri.FromHost(typeof(gmath));

            var dArchive = Context.HostBitsArchive(PartId.GMath, dSrc);
            var gArchive = Context.HostBitsArchive(PartId.GMath, gSrc);
            var dAdd = dArchive.Read("add").Select(x => x.ToApiCode()).ToArray();
            var gAdd = gArchive.Read("add_g").Select(code => code.WithIdentity(code.Id.WithoutGeneric()).ToApiCode()).ToArray();
            Claim.eq(dAdd.Length, gAdd.Length);
            for(var i=0; i< dAdd.Length; i++)
            {
                var d = dAdd[i];
                var g = gAdd[i];
                var opname = d.Id;
                switch(opname)
                {
                    case "add_8i_8i":
                        megacheck(buffers, name, d, g, math.add, gmath.add, i8);
                    break;                       
                }                
            }
        }

        public void sub_megacheck(in BufferSeq buffers)
        {
            var name = nameof(math.sub);
            megacheck(buffers, name, math.sub, gmath.sub, u8);              
            megacheck(buffers, name, math.sub, gmath.sub, i8);              
            megacheck(buffers, name, math.sub, gmath.sub, u16);              
            megacheck(buffers, name, math.sub, gmath.sub, i16);              
            megacheck(buffers, name, math.sub, gmath.sub, u32);            
            megacheck(buffers, name, math.sub, gmath.sub, i32);            
            megacheck(buffers, name, math.sub, gmath.sub, u64);            
            megacheck(buffers, name, math.sub, gmath.sub, i64);            
        }

        void mul_megacheck(in BufferSeq buffers)
        {
            var name = nameof(math.mul);
            megacheck(buffers, name, math.mul, gmath.mul, u8);              
            megacheck(buffers, name, math.mul, gmath.mul, i8);              
            megacheck(buffers, name, math.mul, gmath.mul, u16);              
            megacheck(buffers, name, math.mul, gmath.mul, i16);              
            megacheck(buffers, name, math.mul, gmath.mul, u32);            
            megacheck(buffers, name, math.mul, gmath.mul, i32);            
            megacheck(buffers, name, math.mul, gmath.mul, u64);            
            megacheck(buffers, name, math.mul, gmath.mul, i64);            
        }

        public void and_megacheck(in BufferSeq buffers)
        {
            var name = nameof(math.and);
            megacheck(buffers, name, math.and, gmath.and, u8);              
            megacheck(buffers, name, math.and, gmath.and, i8);              
            megacheck(buffers, name, math.and, gmath.and, u16);              
            megacheck(buffers, name, math.and, gmath.and, i16);              
            megacheck(buffers, name, math.and, gmath.and, u32);            
            megacheck(buffers, name, math.and, gmath.and, i32);            
            megacheck(buffers, name, math.and, gmath.and, u64);            
            megacheck(buffers, name, math.and, gmath.and, i64);            
        }

        public void xor_megacheck(in BufferSeq buffers)
        {
            var name = nameof(math.xor);
            megacheck(buffers, name, math.xor, gmath.xor, u8);              
            megacheck(buffers, name, math.xor, gmath.xor, i8);              
            megacheck(buffers, name, math.xor, gmath.xor, u16);              
            megacheck(buffers, name, math.xor, gmath.xor, i16);              
            megacheck(buffers, name, math.xor, gmath.xor, u32);            
            megacheck(buffers, name, math.xor, gmath.xor, i32);            
            megacheck(buffers, name, math.xor, gmath.xor, u64);            
            megacheck(buffers, name, math.xor, gmath.xor, i64);            
        }

        public void nand_megacheck(in BufferSeq buffers)
        {
            var name = nameof(math.nand);
            megacheck(buffers, name, math.nand, gmath.nand, u8);              
            megacheck(buffers, name, math.nand, gmath.nand, i8);              
            megacheck(buffers, name, math.nand, gmath.nand, u16);              
            megacheck(buffers, name, math.nand, gmath.nand, i16);              
            megacheck(buffers, name, math.nand, gmath.nand, u32);            
            megacheck(buffers, name, math.nand, gmath.nand, i32);            
            megacheck(buffers, name, math.nand, gmath.nand, u64);            
            megacheck(buffers, name, math.nand, gmath.nand, i64);            
        }


        public void xnor_megacheck(in BufferSeq buffers)
        {
            var name = nameof(math.xnor);
            megacheck(buffers, name, math.xnor, gmath.xnor, u8);              
            megacheck(buffers, name, math.xnor, gmath.xnor, i8);              
            megacheck(buffers, name, math.xnor, gmath.xnor, u16);              
            megacheck(buffers, name, math.xnor, gmath.xnor, i16);              
            megacheck(buffers, name, math.xnor, gmath.xnor, u32);            
            megacheck(buffers, name, math.xnor, gmath.xnor, i32);            
            megacheck(buffers, name, math.xnor, gmath.xnor, u64);            
            megacheck(buffers, name, math.xnor, gmath.xnor, i64);            
        }

    #endif
    }
}