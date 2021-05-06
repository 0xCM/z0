//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;

    using static ByteCode;
    using static Part;
    using static memory;

    class App : WfApp<App>
    {

        public static void Main(params string[] args)
            => run(args, PartId.BitNumbers, PartId.DynamicShell);

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
            var result = execute(nameof(mul_8u_8u_8u),mul_8u_8u_8u, 3, 4);
            Wf.Row(result);
        }

        void Test2()
        {
            var builders = new Builders();
            var op = builders.create_binary_op();
            Wf.Row(op.EntryPoint);
        }

        protected override void Run()
        {
            var flow = Wf.Running();
            ListEnvVars();
            Wf.Ran(flow);
        }

        static ReadOnlySpan<byte> mul_8u_8u_8u
            => new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x0f,0xaf,0xc2,0x0f,0xb6,0xc0,0xc3};
    }

    class Builders
    {

        readonly IDynexus Dynamic;

        public Builders()
        {
            Dynamic = Dynops.Dynexus;
        }

        public MsilCompilation create_binary_op()
        {
            var n = n2;
            var t = z32;
            var m = CaseMethods.BinaryAdd_Method;
            var id = m.Identify();

            var factory = Dynamic.Factory(OperatorClasses.binary(t));
            var fx = factory.Create(m);
            var d = (DynamicMethod)fx.GetMethodInfo();
            return ClrDynamic.compilation(d);

            //ClrDynamic.msil(d);


            //Claim.eq(f(10,5), M.BinaryAdd(10,5));
        }

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