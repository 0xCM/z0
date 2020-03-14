//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Linq;

    using static Root;
    using static FKT;
    using static Nats;

    partial class Dynop
    {

        static Func<byte,DynamicDelegate> EmitImmVUnaryOpProducer(VKT.Vec k, MethodInfo method, OpIdentity baseid)
        {
            (var celltype, var width) = method.ParameterTypes()
                    .Where(p => p.IsVector())
                    .Select(x => (x.SuppliedTypeArgs().Single(),x.Width()))
                    .FirstOrDefault();            

            var factory = width switch{
                FixedWidth.W128 => EmitImmV128UnaryOpProducer(baseid, method, celltype),
                FixedWidth.W256 => EmitImmV256UnaryOpProducer(baseid, method, celltype),
                _ => throw new NotSupportedException(width.ToString())
            };
            return factory;
        }

        static Func<byte,DynamicDelegate> EmitImmV128UnaryOpProducer(OpIdentity id, MethodInfo src, Type component)
            => imm8 => EmitImmV128UnaryOp(id, src,imm8,component);

        static Func<byte,DynamicDelegate> EmitImmV256UnaryOpProducer(OpIdentity id, MethodInfo src, Type component)
            => imm8 => EmitImmV256UnaryOp(id, src,imm8,component);

        static Func<byte,DynamicDelegate> EmitImmVBinaryOpProducer(VKT.Vec k, MethodInfo method, OpIdentity baseid)
        {
            (var celltype, var width) = method.ParameterTypes()
                    .Where(p => p.IsVector())
                    .Select(x => (x.SuppliedTypeArgs().Single(),x.Width()))
                    .FirstOrDefault();            

            var factory = width switch{
                FixedWidth.W128 => EmitImmV128BinaryOpProducer(baseid, method, celltype),
                FixedWidth.W256 => EmitImmV256BinaryOpProducer(baseid, method, celltype),
                _ => throw new NotSupportedException(width.ToString())
            };
            return factory;
        }

        static Func<byte,DynamicDelegate> EmitImmV128BinaryOpProducer(OpIdentity id, MethodInfo src, Type component)
            => imm8 => EmitImmV128BinaryOp(id,src,imm8,component);        

        static Func<byte,DynamicDelegate> EmitImmV256BinaryOpProducer(OpIdentity id, MethodInfo src, Type component)
            => imm8 => EmitImmV256BinaryOp(id, src,imm8,component);



    }
}