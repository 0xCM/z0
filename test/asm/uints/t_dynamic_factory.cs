//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Linq;

    using static Konst;

    using T = t_dynamic_factory;
    using K = Kinds;
    using M = CaseMethods;
    

    public class t_dynamic_factory : t_asm<t_dynamic_factory>
    {
        public override bool Enabled => true;

            
        IDynexus Dynamic => Dynops.Services.Dynexus;
        
        public void create_emitter()
        {
            var n = n0;
            var t = z32;
            var m = M.K17_Method;
            var id = m.Identify();
            
            var factory = Dynamic.Factory(K.emitter(t));
            var f = factory.Manufacture(m);            
            Claim.eq(f(), M.K17());        
        }

        public void create_unary_op()
        {
            var n = n1;
            var t = z32;
            var m = M.Square_Method;
            var id = m.Identify();
            
            var factory = Dynamic.Factory(K.unaryop(t));
            var f = factory.Manufacture(m);            
            Claim.eq(f(3), M.Square(3));        
        }

        public void create_binary_op()
        {
            var n = n2;
            var t = z32;
            var m = M.BinaryAdd_Method;
            var id = m.Identify();
            
            var factory = Dynamic.Factory(K.binaryop(t));
            var f = factory.Manufacture(m);            
            Claim.eq(f(10,5), M.BinaryAdd(10,5));        
        }

        public void create_ternary_op()
        {
            var n = n3;
            var t = z32;
            var m = M.TernaryAdd_Method;        
            var id = m.Identify();
            
            var factory = Dynamic.Factory(K.ternaryop(t));
            var f = factory.Manufacture(m);            
            Claim.eq(f(10,5,5), M.TernaryAdd(10,5,5));        
        }


        public void check_blocks()
        {
            var methods = typeof(Blocked).DeclaredMethods().Tagged<OpAttribute>().WithName("add");
            foreach(var method in methods)
            {                
                foreach(var t in method.ParameterTypes())
                {
                    Claim.yea(t.IsBlocked(), $"The parameter {t.Name} from the method {method.Name} is not of blocked type");
                    var width = Widths.divine(t);
                    Claim.yea(width == TypeWidth.W128 || width == TypeWidth.W256, $"{width}");
                }                    
            }
        }
            
        public unsafe void vbsll_128x32u()
        {
            const byte imm8 = 9;

            var resolver = default(VImm8UnaryResolver128<uint>);
            var vbsll = resolver.inject(imm8, OpKindId.Bsll).DynamicOp;
                    
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.CpuVector<uint>(n128);
                var y = vbsll(x);
                var z = gvec.vbsll(x,imm8);
                Claim.veq(z,y);
            }
        }

        [MethodImpl(Inline)]
        static Func<Vector256<T>,Vector256<T>> shuffler<T>(N2 n)
            where T : unmanaged
                => x => gvec.vshuf4x32<T>(x, Arrange4L.AABB);

        [MethodImpl(Inline)]
        static Func<Vector256<uint>, Vector256<uint>> shuffler(N3 n)
            => v => Avx2.Shuffle(v, (byte)Arrange4L.ABCD);
        
        void capture_shuffler()
        {
            var f = shuffler<uint>(n2);
            var g = shuffler(n3);
            
            using var hexout = HexWriter();
            using var asmout = AsmWriter();         
    
            var fCaptured = AsmCheck.Capture(f.Identify(), f).Require();
            hexout.Write(fCaptured.HostedBits);
            asmout.WriteAsm(AsmCheck.Decoder.Decode(fCaptured).Require());

            var gCaptured = AsmCheck.Capture(g.Identify(), g).Require();
            hexout.Write(gCaptured.HostedBits);
            asmout.WriteAsm(AsmCheck.Decoder.Decode(gCaptured).Require());
        }

        TestCaseRecord TestVectorMatch(BufferTokens dst, string name, TypeWidth w, NumericKind kind)
        {
            var dId = Identify.Op(name, w, kind, false);
            var gId = Identify.Op(name, w, kind, true);            
            var archive = UriHexArchive.Create(CodeArchive.CodeDir);
            var dBits = archive.Read(ApiHosts.from<dvec>().Uri).Where(x => x.Id == dId).Single();
            var gBits = archive.Read(ApiHosts.from<gvec>().Uri).Where(x => x.Id == gId).Single();
            return AsmCheck.Match(K.BinaryOp, w, dBits, gBits, dst);
        }

        public TestCaseRecord[] vector_bitlogic_match(BufferTokens buffers)
        {
            var names = Root.array("vxor", "vand", "vor", "vnor", "vxnor", "vnand", "vcimpl");
            var kinds = NumericKind.Integers.DistinctKinds();
            var widths = Root.array(TypeWidth.W128, TypeWidth.W256);
            var dst = new TestCaseRecord[names.Length * widths.Length * kinds.Count];
            var i = 0;
            foreach(var n in names)
            foreach(var w in widths)
            foreach(var k in kinds)
                dst[i++] = TestVectorMatch(buffers, n, w, k);                        
            return dst;
        }
    }
}