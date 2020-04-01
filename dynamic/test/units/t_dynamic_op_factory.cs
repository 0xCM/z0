//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using T = t_dynamic_op_factories;
    using C = OpClasses;

    public class t_dynamic_op_factories : UnitTest<t_dynamic_op_factories>
    {    
        public static uint Suprise() => 17;

        public static uint Square(uint x) => x*x;

        public static uint Add2(uint x, uint y) => x + y;

        public static uint Add3(uint x, uint y, uint z) => x + y + z;

        static MethodInfo suprise => typeof(T).Method(nameof(Suprise)).Require();

        static MethodInfo square => typeof(T).Method(nameof(Square)).Require();

        static MethodInfo add2 => typeof(T).Method(nameof(Add2)).Require();

        static MethodInfo add3 => typeof(T).Method(nameof(Add3)).Require();

        public void create_emitter()
        {
            var n = n0;
            var t = z32;
            var m = suprise;
            
            var factory = Context.OperatorFactory(C.emitter(t));
            var f = factory.Manufacture(m);            
            Claim.eq(f(), Suprise());        
        }

        public void create_unary_op()
        {
            var n = n1;
            var t = z32;
            var m = square;
            
            var factory = Context.OperatorFactory(C.unaryop(t));
            var f = factory.Manufacture(m);            
            Claim.eq(f(3), Square(3));        
        }

        public void create_binary_op()
        {
            var n = n2;
            var t = z32;
            var m = add2;
            
            var factory = Context.OperatorFactory(C.binaryop(t));
            var f = factory.Manufacture(m);            
            Claim.eq(f(10,5), Add2(10,5));        
        }

        public void create_ternary_op()
        {
            var n = n3;
            var t = z32;
            var m = add3;
        
            
            var factory = Context.OperatorFactory(C.ternaryop(t));
            var f = factory.Manufacture(m);            
            Claim.eq(f(10,5,5), Add3(10,5,5));        
        }
    }
}
