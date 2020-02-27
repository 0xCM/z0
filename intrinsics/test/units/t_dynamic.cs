//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Linq;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Collections.Generic;
    
    using static zfunc;

    public class t_dynamic : t_vinx<t_dynamic>
    {   

        public void check_blocks()
        {
            var methods = typeof(vblocks).DeclaredMethods().Tagged<OpAttribute>().WithName("add");
            foreach(var method in methods)
            {                
                foreach(var t in method.ParameterTypes())
                {
                    Claim.yea(t.IsBlocked());
                    Claim.yea(t.Width() == FixedWidth.W128 || t.Width() == FixedWidth.W256);
                }
                    
                var id = Identity.generic(method);
                TraceCaller(id);
            }
        }

        static RuntimeMethodHandle GetMethodHandle(DynamicMethod method)
        {
            var getMethodDescriptorInfo = typeof(DynamicMethod).GetMethod("GetMethodDescriptor", BindingFlags.NonPublic | BindingFlags.Instance);
            return (RuntimeMethodHandle)getMethodDescriptorInfo.Invoke(method, null);

        }

        public void handle_test()
        {   const byte imm8 = 9;
            var method = typeof(ginx).DeclaredMethods().WithName(nameof(ginx.vbsll)).OfKind(VK.vk128()).Single();
            var op = Dynop.UnaryOpImm(VK.vk128<uint>(), Identity.identify(method), method,imm8);
            var handle = GetMethodHandle(op.DynamicMethod);
            PostMessage(handle.Value.ToString());

        }
         
        public unsafe void vbsll_128x32u()
        {
            const byte imm8 = 9;

            var vbsll = VX.vbsll<uint>(n128).@delegate(imm8).DynamicOp;            
                    
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.CpuVector<uint>(n128);
                var y = vbsll(x);
                var z = ginx.vbsll(x,imm8);
                Claim.eq(z,y);
            }
        }
    }
}