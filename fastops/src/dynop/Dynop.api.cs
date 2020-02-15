//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Linq;

    using static zfunc;
    using static FKT;

    public static partial class Dynop
    {
        [MethodImpl(Inline)]
        public static FixedDelegate UnaryOp(this ExecBufferToken buffer, OpIdentity id, Type operatorType, Type operandType)        
            => buffer.Handle.FixedFunc(id, functype: operatorType, result: operandType, args: operandType);

        [MethodImpl(Inline)]
        public static FixedDelegate BinaryOp(this ExecBufferToken buffer, OpIdentity id, Type operatorType, Type operandType)        
            => buffer.Handle.FixedFunc(id,functype:operatorType, result:operandType, args: array(operandType, operandType));

        [MethodImpl(Inline)]
        public static FixedDelegate TernaryOp(this ExecBufferToken buffer, OpIdentity id, Type operatorType, Type operandType)        
            => buffer.Handle.FixedFunc(id, functype:operatorType, result:operandType, args: array(operandType, operandType,operandType));

        [MethodImpl(Inline)]
        public static BinaryOp8 BinaryOp(this ExecBufferToken buffer, N8 w, in AsmCode src)
            => buffer.Load(src).BinaryOp(w, src.Id);

        [MethodImpl(Inline)]
        public static BinaryOp16 BinaryOp(this ExecBufferToken buffer, N16 w, in AsmCode src)
            => buffer.Load(src).BinaryOp(w, src.Id);

        [MethodImpl(Inline)]
        public static BinaryOp32 BinaryOp(this ExecBufferToken buffer, N32 w, in AsmCode src)
            => buffer.Load(src).BinaryOp(w, src.Id);

        [MethodImpl(Inline)]
        public static BinaryOp64 BinaryOp(this ExecBufferToken buffer, N64 w, in AsmCode src)
            => buffer.Load(src).BinaryOp(w, src.Id);

        [MethodImpl(Inline)]
        public static BinaryOp128 BinaryOp(this ExecBufferToken buffer, N128 w, in AsmCode src)
            => buffer.Load(src).BinaryOp(w, src.Id);

        /// <summary>
        /// Creates a 256-bit binary operator over a specified executable memory location
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp256 BinaryOp(this ExecBufferToken buffer, N256 w, OpIdentity id)
            => (BinaryOp256)buffer.BinaryOp(id, typeof(BinaryOp256), typeof(Fixed256));

        [MethodImpl(Inline)]
        public static BinaryOp256 BinaryOp(this ExecBufferToken buffer, N256 w, in AsmCode src)
            => buffer.Load(src).BinaryOp(w, src.Id); 

        [MethodImpl(Inline)]
        public static UnaryOp8 UnaryOp(this ExecBufferToken buffer, N8 w, in AsmCode src)
            => buffer.Load(src).UnaryOp(w, src.Id);

        [MethodImpl(Inline)]
        public static UnaryOp16 UnaryOp(this ExecBufferToken buffer, N16 w, in AsmCode src)               
            => buffer.Load(src).UnaryOp(w, src.Id);

        [MethodImpl(Inline)]
        public static UnaryOp32 UnaryOp(this ExecBufferToken buffer, N32 w, in AsmCode src)
            => buffer.Load(src).UnaryOp(w, src.Id);

        [MethodImpl(Inline)]
        public static UnaryOp64 UnaryOp(this ExecBufferToken buffer, N64 w, in AsmCode src)
            => buffer.Load(src).UnaryOp(w, src.Id);

        [MethodImpl(Inline)]
        public static UnaryOp128 UnaryOp(this ExecBufferToken buffer, N128 w, in AsmCode src)
            => buffer.Load(src).UnaryOp(w, src.Id);

        [MethodImpl(Inline)]
        public static UnaryOp256 UnaryOp(this ExecBufferToken buffer, N256 w, in AsmCode src)
            => buffer.Load(src).UnaryOp(w, src.Id);

        /// <summary>
        /// Creates a 8-bit unary operator over an execution buffer
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp8 UnaryOp8(this ExecBufferToken buffer, N8 w, OpIdentity id)
            => (UnaryOp8)buffer.UnaryOp(id, typeof(UnaryOp8), typeof(Fixed8));

        /// <summary>
        /// Creates a 8-bit unary operator over a specified executable memory location
        /// </summary>
        /// <param name="buffer">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp8 UnaryOp(this ExecBufferToken buffer, N8 w, OpIdentity id)
            => (UnaryOp8)buffer.UnaryOp(id, typeof(UnaryOp8), typeof(Fixed8));

        /// <summary>
        /// Creates a 16-bit unary operator over a specified executable memory location
        /// </summary>
        /// <param name="buffer">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp16 UnaryOp(this ExecBufferToken buffer, N16 w, OpIdentity id)
            => (UnaryOp16)buffer.UnaryOp(id, typeof(UnaryOp16), typeof(Fixed16));

        /// <summary>
        /// Creates a 32-bit unary operator over a specified executable memory location
        /// </summary>
        /// <param name="buffer">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp32 UnaryOp(this ExecBufferToken buffer, N32 w, OpIdentity id)
            => (UnaryOp32)buffer.UnaryOp(id, typeof(UnaryOp32), typeof(Fixed32));

        /// <summary>
        /// Creates a 64-bit unary operator over a specified executable memory location
        /// </summary>
        /// <param name="buffer">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp64 UnaryOp(this ExecBufferToken buffer, N64 w, OpIdentity id)
            => (UnaryOp64)buffer.UnaryOp(id, typeof(UnaryOp64), typeof(Fixed64));

        /// <summary>
        /// Creates a 128-bit unary operator defined by supplied asm code
        /// </summary>
        /// <param name="buffer">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp128 UnaryOp(this ExecBufferToken buffer, N128 w, OpIdentity id)
            => (UnaryOp128)buffer.UnaryOp(id, typeof(UnaryOp128), typeof(Fixed128));

        /// <summary>
        /// Creates a 256-bit unary operator defined by supplied asm code
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp256 UnaryOp(this ExecBufferToken buffer, N256 w, OpIdentity id)
            => (UnaryOp256)buffer.UnaryOp(id, typeof(UnaryOp256), typeof(Fixed256));

        /// <summary>
        /// Creates a 8-bit binary operator over a specified executable memory location
        /// </summary>
        /// <param name="buffer">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp8 BinaryOp(this ExecBufferToken buffer, N8 w,OpIdentity id)
            => (BinaryOp8)buffer.BinaryOp(id, typeof(BinaryOp8), typeof(Fixed8));

        /// <summary>
        /// Creates a 32-bit binary operator over a specified executable memory location
        /// </summary>
        /// <param name="buffer">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp16 BinaryOp(this ExecBufferToken buffer,N16 w, OpIdentity id)
            => (BinaryOp16)buffer.BinaryOp(id, typeof(BinaryOp16), typeof(Fixed16));

        /// <summary>
        /// Creates a 32-bit binary operator over a specified executable memory location
        /// </summary>
        /// <param name="buffer">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp32 BinaryOp(this ExecBufferToken buffer,N32 w, OpIdentity id)
            => (BinaryOp32)buffer.BinaryOp(id, typeof(BinaryOp32), typeof(Fixed32));

        /// <summary>
        /// Creates a 64-bit binary operator over a specified executable memory location
        /// </summary>
        /// <param name="buffer">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp64 BinaryOp(this ExecBufferToken buffer, N64 w, OpIdentity id)
            => (BinaryOp64)buffer.BinaryOp(id, typeof(BinaryOp64), typeof(Fixed64));

        /// <summary>
        /// Creates a 128-bit binary operator over a specified executable memory location
        /// </summary>
        /// <param name="buffer">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp128 BinaryOp(this ExecBufferToken buffer, N128 w, OpIdentity id)
            => (BinaryOp128)buffer.BinaryOp(id, typeof(BinaryOp128), typeof(Fixed128));

        /// <summary>
        /// Returns a dynamic delegate's dynamic pointer
        /// </summary>
        /// <param name="src">The source delegate</param>
        [MethodImpl(Inline)]
        public static unsafe DynamicPointer GetDynamicPointer(this DynamicDelegate src)
            => src.ToDynamicPtr();
 
        /// <summary>
        /// Creates a vectorized unary operator with an immediate capture
        /// </summary>
        /// <param name="k">The kind selector</param>
        /// <param name="method">The method that defines a unary operator that accepts an immediate value in the second operand</param>
        /// <param name="baseid">The identity upon which the dynamic immediate will be predicated</param>
        /// <param name="imm">The immediate value to capture</param>
        public static DynamicDelegate UnaryOpImm(VKT.Vec k, MethodInfo method, OpIdentity baseid, byte imm)
            => UnaryImmOpFactory(k,method,baseid)(imm);

        /// <summary>
        /// Creates a vectorized binary operator with an immediate capture
        /// </summary>
        /// <param name="k">The kind selector</param>
        /// <param name="method">The method that defines a unary operator that accepts an immediate value in the third operand</param>
        /// <param name="baseid">The identity upon which the dynamic immediate will be predicated</param>
        /// <param name="imm">The immediate value to capture</param>
        public static DynamicDelegate BinaryOpImm(VKT.Vec k, MethodInfo method, OpIdentity baseid, byte imm)
            => BinaryImmOpFactory(k,method,baseid)(imm);

        [MethodImpl(Inline)]            
        public static DynamicDelegate UnaryOpV128Imm(MethodInfo src, byte imm)
            => ImmOpBuilder(VK.vk128(), FK.op(n1), src)(imm);

        [MethodImpl(Inline)]            
        public static DynamicDelegate UnaryOpV256Imm(MethodInfo src, byte imm)
            => ImmOpBuilder(VK.vk256(), FK.op(n1), src)(imm);

        [MethodImpl(Inline)]            
        public static DynamicDelegate BinaryOpV256Imm(MethodInfo src, byte imm)
            => ImmOpBuilder(VK.vk256(), FK.op(n2), src)(imm);

        [MethodImpl(Inline)]            
        public static DynamicDelegate BinaryV128Imm(MethodInfo src, byte imm)
            => ImmOpBuilder(VK.vk128(), FK.op(n2), src)(imm);

        [MethodImpl(Inline)]
        public static CilBody CilFunc(this DynamicMethod src)
            => CilBody.From(src);

        [MethodImpl(Inline)]
        public static CilBody CilFunc(this MethodInfo src)
            => CilBody.From(src);

        [MethodImpl(Inline)]
        public static CilBody CilFunc(this DynamicDelegate src)
            => CilBody.From(src);

        internal static DynamicMethod method(string name, Type owner, Type @return, params Type[] args)
            => new DynamicMethod(name: name, 
                attributes: MethodAttributes.Public | MethodAttributes.Static,  
                callingConvention: CallingConventions.Standard,
                returnType: @return, 
                parameterTypes: args, 
                owner: owner,
                skipVisibility: false);       

        internal static DynamicDelegate UnaryImmOpDelegate(VKT.Vec k, Type typedef, OpIdentity id, MethodInfo inner, byte imm8, Type component)
        {
            var reified = inner.Reify(component);
            var operand = typedef.MakeGenericType(component); 
            var target = typeof(UnaryOp<>).MakeGenericType(operand);
            var wrapper = method(reified.Name, reified.DeclaringType, operand, operand);            
            wrapper.GetILGenerator().EmitUnaryImmCall(reified, imm8);
            return wrapper.CreateDelegate(id.WithImm8(imm8), reified, target);
        }

        internal static DynamicDelegate BinaryImmOpDelegate(VKT.Vec128 k, OpIdentity id, MethodInfo src, byte imm8, Type component)
        {
            var reified = src.Reify(component);
            var operand = typeof(Vector128<>).MakeGenericType(component);  
            var target = typeof(BinaryOp<>).MakeGenericType(operand);
            var wrapper = method(reified.Name, reified.DeclaringType, operand, operand, operand);            
            var gen = wrapper.GetILGenerator();
            wrapper.GetILGenerator().EmitBinaryImmCall(reified,imm8);
            return wrapper.CreateDelegate(id.WithImm8(imm8),reified, target);
        }

        internal static DynamicDelegate BinaryImmOpDelegate(VKT.Vec256 k, OpIdentity id, MethodInfo src, byte imm8, Type component)
        {
            var reified = src.Reify(component);
            var operand = typeof(Vector256<>).MakeGenericType(component);  
            var target = typeof(BinaryOp<>).MakeGenericType(operand);
            var wrapper = method(reified.Name, reified.DeclaringType, operand, operand, operand);            
            var gen = wrapper.GetILGenerator();
            wrapper.GetILGenerator().EmitBinaryImmCall(reified,imm8);
            return wrapper.CreateDelegate(id.WithImm8(imm8),reified, target);
        }
     
        internal static DynamicDelegate UnaryImmOp(VKT.Vec128 k, OpIdentity id, MethodInfo src, byte imm8, Type seg)
            => UnaryImmOpDelegate(k, typeof(Vector128<>), id, src, imm8, seg);

        internal static DynamicDelegate UnaryImmOp(VKT.Vec256 k, OpIdentity id, MethodInfo src, byte imm8, Type seg)
            => UnaryImmOpDelegate(k, typeof(Vector256<>), id, src, imm8, seg);

        internal static Func<byte,DynamicDelegate> ImmOpBuilder(VKT.Vec128 vk, UnaryOpType opk, MethodInfo src)
            => imm8 => UnaryImmOp(vk,src.Identify(),src,imm8, src.ParameterTypes().First());

        internal static Func<byte,DynamicDelegate> ImmOpBuilder(VKT.Vec256 vk, UnaryOpType opk, MethodInfo src)
            => imm8 => UnaryImmOp(vk,src.Identify(),src,imm8, src.ParameterTypes().First());

        internal static Func<byte,DynamicDelegate> ImmOpBuilder(VKT.Vec128 vk, BinaryOpType opk, MethodInfo src)
            => imm8 => BinaryImmOpDelegate(vk,src.Identify(),src,imm8, src.ParameterTypes().First());

        internal static Func<byte,DynamicDelegate> ImmOpBuilder(VKT.Vec256 vk, BinaryOpType opk, MethodInfo src)
            => imm8 => BinaryImmOpDelegate(vk,src.Identify(),src,imm8, src.ParameterTypes().First());

        internal static Func<byte,DynamicDelegate> UnaryImmOpProvider(VKT.Vec128 k, OpIdentity id, MethodInfo src, Type component)
            => imm8 => UnaryImmOp(k,id,src,imm8,component);

        internal static Func<byte,DynamicDelegate> UnaryImmOpProvider(VKT.Vec256 k, OpIdentity id, MethodInfo src, Type component)
            => imm8 => UnaryImmOp(k, id, src,imm8,component);

        internal static Func<byte,DynamicDelegate> UnaryImmOpFactory(VKT.Vec k, MethodInfo method, OpIdentity baseid)
        {
            (var celltype, var width) = method.ParameterTypes()
                    .Where(p => p.IsVector())
                    .Select(x => (x.SuppliedTypeArgs().Single(),x.Width()))
                    .FirstOrDefault();            

            var factory = width switch{
                FixedWidth.W128 => UnaryImmOpProvider(VK.vk128(), baseid, method, celltype),
                FixedWidth.W256 => UnaryImmOpProvider(VK.vk256(), baseid, method, celltype),
                _ => throw new NotSupportedException(width.ToString())
            };
            return factory;
        }

        internal static Func<byte,DynamicDelegate> BinaryImmOpProvider(VKT.Vec128 k, OpIdentity id, MethodInfo src, Type component)
            => imm8 => BinaryImmOpDelegate(k,id,src,imm8,component);

        internal static Func<byte,DynamicDelegate> BinaryImmOpProvider(VKT.Vec256 k, OpIdentity id, MethodInfo src, Type component)
            => imm8 => BinaryImmOpDelegate(k, id, src,imm8,component);

        internal static Func<byte,DynamicDelegate> BinaryImmOpFactory(VKT.Vec k, MethodInfo method, OpIdentity baseid)
        {
            (var celltype, var width) = method.ParameterTypes()
                    .Where(p => p.IsVector())
                    .Select(x => (x.SuppliedTypeArgs().Single(),x.Width()))
                    .FirstOrDefault();            

            var factory = width switch{
                FixedWidth.W128 => BinaryImmOpProvider(VK.vk128(), baseid, method, celltype),
                FixedWidth.W256 => BinaryImmOpProvider(VK.vk256(), baseid, method, celltype),
                _ => throw new NotSupportedException(width.ToString())
            };
            return factory;
        }
    }
}