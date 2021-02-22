//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static Part;

    using M = CaseMethods;

    public class t_dynamic_factory : t_asm<t_dynamic_factory>
    {
        public override bool Enabled => true;

        IDynexus Dynamic => Dynops.Dynexus;

        public void create_emitter()
        {
            var n = n0;
            var t = z32;
            var m = M.K17_Method;
            var id = m.Identify();

            var factory = Dynamic.Factory(OperatorClasses.emitter(t));
            var f = factory.Create(m);
            Claim.eq(f(), M.K17());
        }

        public void create_unary_op()
        {
            var n = n1;
            var t = z32;
            var m = M.Square_Method;
            var id = m.Identify();

            var factory = Dynamic.Factory(OperatorClasses.unary(t));
            var f = factory.Create(m);
            Claim.eq(f(3), M.Square(3));
        }

        public void create_binary_op()
        {
            var n = n2;
            var t = z32;
            var m = M.BinaryAdd_Method;
            var id = m.Identify();

            var factory = Dynamic.Factory(OperatorClasses.binary(t));
            var f = factory.Create(m);
            Claim.eq(f(10,5), M.BinaryAdd(10,5));
        }

        public void create_ternary_op()
        {
            var n = n3;
            var t = z32;
            var m = M.TernaryAdd_Method;
            var id = m.Identify();

            var factory = Dynamic.Factory(OperatorClasses.ternary(t));
            var f = factory.Create(m);
            Claim.eq(f(10,5,5), M.TernaryAdd(10,5,5));
        }

        public void check_blocks()
        {
            var methods = typeof(Blocked).DeclaredMethods().Tagged<OpAttribute>().WithName("add");
            foreach(var method in methods)
            {
                foreach(var t in method.ParameterTypes())
                {
                    Claim.yea(t.IsSegmented(), $"The parameter {t.Name} from the method {method.Name} is not of blocked type");
                    var width = ApiIdentify.width(t);
                    Claim.yea(width == TypeWidth.W128 || width == TypeWidth.W256, $"{width}");
                }
            }
        }

        public void vbsll_128x32u()
        {
            const byte imm8 = 9;

            var resolver = VImm8UnaryResolvers.create<uint>(typeof(gcpu), w128);
            var vbsll = resolver.inject(imm8, ApiClass.Bsll).Operation;

            for(var i=0; i<RepCount; i++)
            {
                var x = Random.CpuVector<uint>(n128);
                var y = vbsll(x);
                var z = gcpu.vbsll(x,imm8);
                Claim.veq(z,y);
            }
        }

        [MethodImpl(Inline)]
        static Func<Vector256<T>,Vector256<T>> shuffler<T>(N2 n)
            where T : unmanaged
                => x => gcpu.vshuf4x32<T>(x, Arrange4L.AABB);

        [MethodImpl(Inline)]
        static Func<Vector256<uint>, Vector256<uint>> shuffler(N3 n)
            => v => Avx2.Shuffle(v, (byte)Arrange4L.ABCD);

        public void capture_shuffler()
        {
            var f = shuffler<uint>(n2);
            var g = shuffler(n3);

            using var hexTarget = HexWriter();
            using var asmTarget = AsmWriter();

            var fCaptured = AsmCheck.Capture(f.Identify(), f).Require();
            hexTarget.Write(fCaptured.CodeBlock);
            asmTarget.WriteAsm(AsmCheck.Decoder.Decode(fCaptured).Require());

            var gCaptured = AsmCheck.Capture(g.Identify(), g).Require();
            hexTarget.Write(gCaptured.CodeBlock);
            asmTarget.WriteAsm(AsmCheck.Decoder.Decode(gCaptured).Require());
        }

        TestCaseRecord TestVectorMatch(BufferTokens dst, string name, TypeWidth w, NumericKind kind)
        {
            var dId = ApiIdentify.build(name, w, kind, false);
            var gId = ApiIdentify.build(name, w, kind, true);
            var archive = ApiArchives.hex(Wf, TargetArchive.HexDir());
            var dBits = archive.Read(ApiQuery.hostinfo(typeof(z)).Uri).Where(x => x.Id == dId).Single();
            var gBits = archive.Read(ApiQuery.hostinfo<gcpu>().Uri).Where(x => x.Id == gId).Single();
            return AsmCheck.Match(OperatorClasses.binary(), w, dBits, gBits, dst);
        }

        public TestCaseRecord[] vector_bitlogic_match(BufferTokens buffers)
        {
            var names = root.array("vxor", "vand", "vor", "vnor", "vxnor", "vnand", "vcimpl");
            var kinds = NumericKind.Integers.DistinctKinds();
            var widths = root.array(TypeWidth.W128, TypeWidth.W256);
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