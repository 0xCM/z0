//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Part;
    using static memory;

    class App : WfApp<App>
    {
        public static void Main(params string[] args)
            => run(args, PartId.BitNumbers, PartId.DynamicShell);

        readonly IDynexus Dynamic;

        public App()
        {
            Dynamic = Dynops.Dynexus;
        }

        public void ListEnvVars()
        {
            var src = Resources.strings<uint>(typeof(EnvVarNames)).View;
            for(var i=0; i<src.Length; i++)
                Wf.Status(skip(src,i).Format());
        }

        void RunCalc()
        {
            CalcDemo.compute();
            var dst = text.buffer();
            CalcDemo.run(dst);
            Wf.Row(dst.Emit());
        }


        void Test1()
        {
            var name = nameof(mul_8u_8u_8u);
            var code = mul_8u_8u_8u;
            var dynop = BinaryOpDynamics.dynop<byte>(name, code);
            var fx = dynop.Delegate;
            var il = ClrDynamic.compilation(dynop.Definition);
            Wf.Row(string.Format("{0}: {1}", il.EntryPoint, il.Msil.Encoded.Format()));
            for(byte i=0; i<20; i++)
            {
                var a = i;
                var b = (byte)(a*2);
                var c = fx(a,b);
                Wf.Row(string.Format("{0}({1},{2})={3}", name, a, b, c));
            }
        }

        void Test2()
        {
            var n = n2;
            var t = z32;
            var m = CaseMethods.BinaryAdd_Method;
            var id = m.Identify();
            var factory = Dynamic.Factory(OperatorClasses.binary(t));
            var fx = factory.Create(m);
            Wf.Row(fx(3,4).ToString());
        }

        void Test3()
        {
            var src = BinaryOpsDemo.dynops().View;
            var count = src.Length;
            var buffer = alloc<MsilCompilation>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var op = ref skip(src,i);
                ref var result = ref seek(dst,i);
                result = ClrDynamic.compilation(op.Definition);
                Wf.Row(string.Format("{0}: {1}", result.EntryPoint, result.Msil.Encoded.Format()));
            }
        }

        protected override void Run()
        {
            var flow = Wf.Running();
            Test1();
            Wf.Ran(flow);
        }

        static ReadOnlySpan<byte> mul_8u_8u_8u
            => new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x0f,0xaf,0xc2,0x0f,0xb6,0xc0,0xc3};
    }


    public readonly struct CaseMethods
    {
        public static uint Emitter()
            => 17;

        public static uint Square(uint x)
            => x*x;

        public static uint BinaryAdd(uint x, uint y)
            => x + y;

        public static uint TernaryAdd(uint x, uint y, uint z)
            => x + y + z;

        public static MethodInfo Emitter_Method
            => typeof(CaseMethods).Method(nameof(Emitter));

        public static MethodInfo Square_Method
            => typeof(CaseMethods).Method(nameof(Square));

        public static MethodInfo BinaryAdd_Method
            => typeof(CaseMethods).Method(nameof(BinaryAdd));

        public static MethodInfo TernaryAdd_Method
            => typeof(CaseMethods).Method(nameof(TernaryAdd));
    }
}