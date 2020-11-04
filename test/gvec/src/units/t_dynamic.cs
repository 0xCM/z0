//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static Konst;
    using static Kinds;

    public class t_dynamic : t_inx<t_dynamic>
    {
        public void check_blocks()
        {
            var methods = typeof(Blocked).DeclaredMethods().Tagged<OpAttribute>().WithName("add");
            foreach(var method in methods)
            {
                foreach(var t in method.ParameterTypes())
                {
                    Claim.yea(t.IsBlocked(), $"The parameter {t.Name} from the method {method.Name} is not of blocked type");
                    var width = ApiIdentify.width(t);
                    Claim.yea(width == TypeWidth.W128 || width == TypeWidth.W256, $"{width}");
                }
            }
        }

        public void vbsll_imm_handle()
        {   const byte imm8 = 9;
            var name = nameof(gvec.vbsll);
            var src = typeof(gvec).DeclaredMethods().WithName(name).OfKind(v128).Single();
            var op = Dynop.EmbedVUnaryOpImm(vk128<uint>(), Z0.Identity.identify(src), src, imm8);
            var handle = ClrDynamic.handle(op.Target);
            var dst = ClrDynamic.method(handle);
            Claim.eq(dst.Name, name);
        }

        public unsafe void vbsll_128x32u()
        {
            const byte imm8 = 9;

            var resolver = default(VImm8UnaryResolver128<uint>);
            var vbsll = resolver.inject(imm8, ApiClass.Bsll).DynamicOp;

            for(var i=0; i<RepCount; i++)
            {
                var x = Random.CpuVector<uint>(n128);
                var y = vbsll(x);
                var z = gvec.vbsll(x,imm8);
                Claim.veq(z,y);
            }
        }
    }
}