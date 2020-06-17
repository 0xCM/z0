//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Security;
    using System.Reflection.Emit;
    using System.Runtime.InteropServices;

    using static Konst;
    using static Memories;

    public static partial class XTend
    {

        

    }

    public class SizeAttribute : Attribute
    {
        public SizeAttribute(uint size)
        {
            Size = size;
        }

        public ByteSize Size {get;}
    }
    
    readonly struct Slots
    {
        [Size(20)]
        public static byte add(byte x, byte y)
            => (byte)(x+y);

        [Size(17)]
        public static byte sub(byte x, byte y)
            => (byte)(x-y);

        [Size(18)]
        public static byte mul(byte x, byte y)
            => (byte)(x*y);

        [Size(18)]
        public static byte div(byte x, byte y)
            => (byte)(x/y);

        [Size(17)]
        public static byte and(byte x, byte y)
            => (byte)(x&y);

    }

    readonly struct ExecutionEngine
    {
        public static MemRef[] GetReferences(Type src)
        {
            var locations = src.DeclaredMethods().Select(m =>  (MemoryAddress)MemberJit.Service.Jit(m));


            return default;
            
        }

        readonly struct Mul8x8 : IBinaryOp<byte>
        {
            public static Mul8x8 F => default;

            [MethodImpl(Inline)]
            public byte Invoke(byte a, byte b)
                => (byte)(a*b);
        }

        [MethodImpl(Inline), Op]
        public static byte mul_direct(byte a, byte b)
            => (byte)(a*b);

        [MethodImpl(Inline), Op]
        public static byte mul_sfunc(byte a, byte b)
            => Mul8x8.F.Invoke(a,b);

        public static byte eval(byte x, byte y, ReadOnlySpan<byte> f)
        {
            var buffer = Control.alloc<byte>(f.Length);
            f.CopyTo(buffer);                
            Spans.liberate(buffer);
            var g = EmitBinaryOp8u("mul",buffer);
            return g(x,y);
        }                

        public static BinaryOp<byte> EmitBinaryOp8u(string name, Span<byte> buffer)
        {   
            var tFunc = typeof(BinaryOp<byte>);
            var tOperand = typeof(byte);
            var args = Control.array(tOperand, tOperand);

            var id = OpIdentityParser.Service.Parse($"{name}_(8u,8u)");
            var method = new DynamicMethod(id, tOperand, args, tFunc.Module);                
            var g = method.GetILGenerator();
            var dst = MemoryAddress.From(head(buffer));
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldarg_1);                
            g.Emit(OpCodes.Ldc_I8, dst);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, tOperand, args);
            g.Emit(OpCodes.Ret);
            return (BinaryOp<byte>)FixedDelegate.Define(id, dst, method, method.CreateDelegate(tFunc));
        }
    }
}