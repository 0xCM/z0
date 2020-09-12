//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.InteropServices;

    using static Root;
    using static Kinds;
    using static Konst;
    using static Typed;

    using K = Kinds;
    using I = Z0;

    using U = Kinds.UnaryOpClass;
    using B = BinaryOpClass;
    using T = Kinds.TernaryOpClass;

    readonly struct Dynexus : IDynexus
    {
        readonly IMultiDiviner Diviner;

        [MethodImpl(Inline)]
        internal Dynexus(IMultiDiviner diviner)
        {
            Diviner = diviner;
        }

        [MethodImpl(Inline)]
        OpIdentity Identify(MethodInfo src)
            => Diviner.Identify(src);

        U Unary => default;

        B Binary => default;

        T Ternary => default;

        IDynamicFactories FactorySource
            => DynamicFactories.Service;

        IImmInjector IDynamicImmediate.UnaryInjector<W>()
        {
            if(typeof(W) == typeof(W128))
                return ImmInjector.create(Diviner, v128, K.UnaryOp);
            else if(typeof(W) == typeof(W256))
                return ImmInjector.create(Diviner, v256, K.UnaryOp);
            else
                throw Unsupported.define<W>();
        }

        IImmInjector IDynamicImmediate.BinaryInjector<W>()
        {
            if(typeof(W) == typeof(W128))
                return ImmInjector.create(Diviner, v128, K.BinaryOp);
            else if(typeof(W) == typeof(W256))
                return ImmInjector.create(Diviner, v256, K.BinaryOp);
            else
                throw Unsupported.define<W>();
        }

        [MethodImpl(Inline)]
        DynamicDelegate<UnaryOp<Vector128<T>>> IDynamicImmediate.CreateUnaryOp<T>(MethodInfo src, W128 w, byte imm)
            => Dynop.EmbedVUnaryOpImm(vk128<T>(), Identify(src), src, imm);

        [MethodImpl(Inline)]
        DynamicDelegate<BinaryOp<Vector128<T>>> IDynamicImmediate.CreateBinaryOp<T>(MethodInfo src, W128 w, byte imm)
            => Dynop.EmbedVBinaryOpImm(vk128<T>(), Identify(src), src, imm);

        [MethodImpl(Inline)]
        DynamicDelegate<UnaryOp<Vector256<T>>> IDynamicImmediate.CreateUnaryOp<T>(MethodInfo src, W256 w, byte imm)
            => Dynop.EmbedVUnaryOpImm(vk256<T>(), Identify(src), src, imm);

        [MethodImpl(Inline)]
        DynamicDelegate<BinaryOp<Vector256<T>>> IDynamicImmediate.CreateBinaryOp<T>(MethodInfo src, W256 w, byte imm)
            => Dynop.EmbedImmVBinaryOpImm(vk256<T>(), Identify(src), src, imm);

        [MethodImpl(Inline)]
        IEmitterOpFactory<T> IDynamicFactories.Factory<T>(EmitterOpClass<T> k)
            => FactorySource.Factory(k);

        [MethodImpl(Inline)]
        IUnaryOpFactory<T> IDynamicFactories.Factory<T>(UnaryOpClass<T> k)
            => FactorySource.Factory(k);

        [MethodImpl(Inline)]
        IBinaryOpFactory<T> IDynamicFactories.Factory<T>(BinaryOpClass<T> k)
            => FactorySource.Factory(k);

        [MethodImpl(Inline)]
        ITernaryOpFactory<T> IDynamicFactories.Factory<T>(TernaryOpClass<T> k)
            => FactorySource.Factory(k);

        Option<DynamicDelegate> IDynamicImmediate.CreateUnaryOp(TypeWidth w, MethodInfo src, byte imm8)
        {
            if(w == TypeWidth.W128)
                return DynamicImmediate.EmbedVUnaryOpImm(w128, src,imm8, Identify(src));
            else if(w == TypeWidth.W256)
                return DynamicImmediate.EmbedVUnaryOpImm(w256, src,imm8, Identify(src));
            else
                return none<DynamicDelegate>();
        }

        Option<DynamicDelegate> IDynamicImmediate.CreateBinaryOp(TypeWidth w, MethodInfo src, byte imm8)
        {
            if(w == TypeWidth.W128)
                return DynamicImmediate.EmbedVBinaryOpImm(w128, src,imm8, Identify(src));
            else if(w == TypeWidth.W256)
                return DynamicImmediate.EmbedVBinaryOpImm(w256, src,imm8, Identify(src));
            else
                return none<DynamicDelegate>();
        }

        /// <summary>
        /// Creates a 128-bit T-parametric unary immediate injector
        /// </summary>
        /// <param name="w">The vector operand width</param>
        /// <param name="k">The operator kind</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        public IImmInjector<UnaryOp<Vector128<T>>> UnaryInjector<T>(W128 w)
            where T : unmanaged
                => ImmInjector.from(Diviner, I.V128UnaryOpImmInjector.Create<T>(Diviner));

        /// <summary>
        /// Creates a 256-bit T-parametric unary immediate injector
        /// </summary>
        /// <param name="w">The vector operand width</param>
        /// <param name="k">The operator kind</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        public IImmInjector<UnaryOp<Vector256<T>>> UnaryInjector<T>(W256 w)
            where T : unmanaged
                => ImmInjector.from(Diviner, I.V256UnaryOpImmInjector.Create<T>(Diviner));

        /// <summary>
        /// Creates a 128-bit T-parametric binary immediate injector
        /// </summary>
        /// <param name="w">The vector operand width</param>
        /// <param name="k">The operator kind</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        public IImmInjector<BinaryOp<Vector128<T>>> BinaryInjector<T>(W128 w)
            where T : unmanaged
                => ImmInjector.from(Diviner, I.V128BinaryOpImmInjector.Create<T>(Diviner));

        /// <summary>
        /// Creates a 256-bit T-parametric binary immediate injector
        /// </summary>
        /// <param name="w">The vector operand width</param>
        /// <param name="k">The operator kind</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        public IImmInjector<BinaryOp<Vector256<T>>> BinaryInjector<T>(W256 w)
            where T : unmanaged
                => ImmInjector.from(Diviner, I.V256BinaryOpImmInjector.Create<T>(Diviner));

        [MethodImpl(Inline)]
        FixedUnaryOp<F> IFixedDynamic.EmitFixedUnary<F>(BufferToken dst, X86UriHex src)
            => (FixedUnaryOp<F>)Emit(src.Id, typeof(FixedUnaryOp<F>), typeof(F),
                    sys.array(typeof(F)), dst.Load(src.Encoded).Handle);

        [MethodImpl(Inline)]
        FixedBinaryOp<F> IFixedDynamic.EmitFixedBinary<F>(BufferToken dst, X86UriHex src)
            => (FixedBinaryOp<F>)Emit(src.Id, typeof(FixedBinaryOp<F>), typeof(F),
                    sys.array(typeof(F),typeof(F)),dst.Load(src.Encoded).Handle);

        [MethodImpl(Inline)]
        FixedTernaryOp<F> IFixedDynamic.EmitFixedTernary<F>(BufferToken dst, X86UriHex src)
            => (FixedTernaryOp<F>)Emit(src.Id, typeof(FixedTernaryOp<F>), typeof(F),
                    sys.array(typeof(F), typeof(F), typeof(F)), dst.Load(src.Encoded).Handle);

        [MethodImpl(Inline)]
        UnaryOp8 IFixedDynamic.EmitFixedUnary(BufferToken dst, W8 w, X86UriHex src)
            => Emit(src.Id, Unary, w, dst.Load(src.Encoded));

        [MethodImpl(Inline)]
        UnaryOp16 IFixedDynamic.EmitFixedUnary(BufferToken dst, W16 w, X86UriHex src)
            => Emit(src.Id, Unary, w, dst.Load(src.Encoded));

        [MethodImpl(Inline)]
        UnaryOp32 IFixedDynamic.EmitFixedUnary(BufferToken dst, W32 w, X86UriHex src)
            => Emit(src.Id, Unary, w, dst.Load(src.Encoded));

        [MethodImpl(Inline)]
        UnaryOp64 IFixedDynamic.EmitFixedUnary(BufferToken dst, W64 w, X86UriHex src)
            => Emit(src.Id, Unary, w, dst.Load(src.Encoded));

        [MethodImpl(Inline)]
        UnaryOp128 IFixedDynamic.EmitFixedUnary(BufferToken dst, W128 w, X86UriHex src)
            => Emit(dst.Load(src.Encoded), src.Id, Unary, w);

        [MethodImpl(Inline)]
        UnaryOp256 IFixedDynamic.EmitFixedUnary(BufferToken dst, W256 w, X86UriHex src)
            => Emit(dst.Load(src.Encoded), src.Id, Unary, w);

        [MethodImpl(Inline)]
        BinaryOp8 IFixedDynamic.EmitFixedBinary(BufferToken dst, W8 w, X86UriHex src)
            => Emit(dst.Load(src.Encoded), src.Id, Binary, w);

        [MethodImpl(Inline)]
        BinaryOp16 IFixedDynamic.EmitFixedBinary(BufferToken dst, W16 w, X86UriHex src)
            => Emit(dst.Load(src.Encoded), src.Id, Binary, w);

        [MethodImpl(Inline)]
        BinaryOp32 IFixedDynamic.EmitFixedBinary(BufferToken dst, W32 w, X86UriHex src)
            => Emit(dst.Load(src.Encoded), src.Id, Binary, w);

        [MethodImpl(Inline)]
        BinaryOp64 IFixedDynamic.EmitFixedBinary(BufferToken dst, W64 w, X86UriHex src)
            => Emit(dst.Load(src.Encoded), src.Id, Binary, w);

        [MethodImpl(Inline)]
        BinaryOp128 IFixedDynamic.EmitFixedBinary(BufferToken dst, W128 w, X86UriHex src)
            => Emit(src.Id, Binary, w, dst.Load(src.Encoded));

        [MethodImpl(Inline)]
        BinaryOp256 IFixedDynamic.EmitFixedBinary(BufferToken dst, W256 w, X86UriHex src)
            => Emit(src.Id, Binary, w, dst.Load(src.Encoded));

        [MethodImpl(Inline)]
        UnaryOp<T> IDynamicNumeric.EmitUnaryOp<T>(BufferToken dst, X86UriHex src)
            => EmitUnaryOp<T>(src.Id, dst.Load(src.Encoded));

        [MethodImpl(Inline)]
        BinaryOp<T> IDynamicNumeric.EmitBinaryOp<T>(BufferToken dst, X86UriHex src)
            => EmitBinaryOp<T>(src.Id, dst.Load(src.Encoded));

        [MethodImpl(Inline)]
        TernaryOp<T> IDynamicNumeric.EmitTernaryOp<T>(BufferToken dst, X86UriHex src)
            => EmitTernaryOp<T>(src.Id, dst.Load(src.Encoded));

        [MethodImpl(Inline)]
        UnaryOp8 Emit(OpIdentity id, U f, W8 w, BufferToken dst)
            => (UnaryOp8)Emit(id, f, typeof(UnaryOp8), typeof(Cell8), dst);

        [MethodImpl(Inline)]
        UnaryOp16 Emit(OpIdentity id, U f, W16 w, BufferToken dst)
            => (UnaryOp16)Emit(id, f, typeof(UnaryOp16), typeof(Cell16), dst);

        [MethodImpl(Inline)]
        UnaryOp32 Emit(OpIdentity id, U f, W32 w, BufferToken dst)
            => (UnaryOp32)Emit(id, f, typeof(UnaryOp32), typeof(Cell32), dst);

        [MethodImpl(Inline)]
        UnaryOp64 Emit(OpIdentity id, U f, W64 w, BufferToken dst)
            => (UnaryOp64)Emit(id, f, typeof(UnaryOp64), typeof(Cell64), dst);

        [MethodImpl(Inline)]
        UnaryOp128 Emit(BufferToken dst, OpIdentity id, U f, N128 w)
            => (UnaryOp128)Emit(id, f, typeof(UnaryOp128), typeof(Cell128), dst);

        [MethodImpl(Inline)]
        UnaryOp256 Emit(BufferToken dst, OpIdentity id, U f, N256 w)
            => (UnaryOp256)Emit(id, f, typeof(UnaryOp256), typeof(Cell256), dst);

        [MethodImpl(Inline)]
        BinaryOp8 Emit(BufferToken dst, OpIdentity id, B f, W8 w)
            => (BinaryOp8)Emit(id, f, typeof(BinaryOp8), typeof(Cell8), dst);

        [MethodImpl(Inline)]
        BinaryOp16 Emit(BufferToken dst, OpIdentity id, B f, W16 w)
            => (BinaryOp16)Emit(id, f, typeof(BinaryOp16), typeof(Cell16), dst);

        [MethodImpl(Inline)]
        BinaryOp32 Emit(BufferToken dst, OpIdentity id, B f, W32 w)
            => (BinaryOp32)Emit(id, f, typeof(BinaryOp32), typeof(Cell32), dst);

        [MethodImpl(Inline)]
        BinaryOp64 Emit(BufferToken dst, OpIdentity id, B f, W64 w)
            => (BinaryOp64)Emit(id, f, typeof(BinaryOp64), typeof(Cell64), dst);

        [MethodImpl(Inline)]
        BinaryOp128 Emit(OpIdentity id, B f, N128 w, BufferToken dst)
            => (BinaryOp128)Emit(id, f, typeof(BinaryOp128), typeof(Cell128), dst);

        [MethodImpl(Inline)]
        BinaryOp256 Emit(OpIdentity id, B f, N256 w, BufferToken dst)
            => (BinaryOp256)Emit(id, f, typeof(BinaryOp256), typeof(Cell256), dst);

        [MethodImpl(Inline)]
        CellDelegate Emit(OpIdentity id, U f, Type operatorType, Type operandType, BufferToken dst)
            => Emit(id, functype:operatorType, result:operandType,
                    args:array(operandType, operandType), dst.Handle);

        [MethodImpl(Inline)]
        CellDelegate Emit(OpIdentity id, B f, Type operatorType, Type operandType, BufferToken dst)
            => Emit(id, functype:operatorType, result:operandType,
                    args:array(operandType, operandType), dst.Handle);

        [MethodImpl(Inline)]
        UnaryOp<T> EmitUnaryOp<T>(OpIdentity id, BufferToken dst)
            where T : unmanaged
                => (UnaryOp<T>)EmitFixedUnaryOp(id, typeof(UnaryOp<T>), typeof(T), dst);

        [MethodImpl(Inline)]
        BinaryOp<T> EmitBinaryOp<T>(OpIdentity id, BufferToken dst)
            where T : unmanaged
                => (BinaryOp<T>)EmitFixedBinaryOp(id, typeof(BinaryOp<T>), typeof(T), dst);

        [MethodImpl(Inline)]
        TernaryOp<T> EmitTernaryOp<T>(OpIdentity id, BufferToken dst)
            where T : unmanaged
                => (TernaryOp<T>)EmitFixedTernaryOp(id,typeof(TernaryOp<T>), typeof(T), dst);

        [MethodImpl(Inline)]
        CellDelegate EmitFixedUnaryOp(OpIdentity id, Type operatorType, Type operandType, BufferToken dst)
            => Emit(id, functype: operatorType, result: operandType, args: array(operandType), dst.Handle);

        [MethodImpl(Inline)]
        CellDelegate EmitFixedBinaryOp(OpIdentity id, Type operatorType, Type operandType, BufferToken dst)
            => Emit(id, functype:operatorType, result:operandType, args: array(operandType, operandType), dst.Handle);

        [MethodImpl(Inline)]
        CellDelegate EmitFixedTernaryOp(OpIdentity id, Type operatorType, Type operandType, BufferToken dst)
            => Emit(id, functype:operatorType, result:operandType, args: array(operandType, operandType, operandType), dst.Handle);

        CellDelegate Emit(OpIdentity id, Type functype, Type result, Type[] args, IntPtr dst)
        {
            var method = new DynamicMethod(id, result, args, functype.Module);
            var g = method.GetILGenerator();
            switch(args.Length)
            {
                case 1:
                    g.Emit(OpCodes.Ldarg_0);
                break;
                case 2:
                    g.Emit(OpCodes.Ldarg_0);
                    g.Emit(OpCodes.Ldarg_1);
                break;
                case 3:
                    g.Emit(OpCodes.Ldarg_0);
                    g.Emit(OpCodes.Ldarg_1);
                    g.Emit(OpCodes.Ldarg_2);
                break;
                case 4:
                    g.Emit(OpCodes.Ldarg_0);
                    g.Emit(OpCodes.Ldarg_1);
                    g.Emit(OpCodes.Ldarg_2);
                    g.Emit(OpCodes.Ldarg_3);
                break;

            }
            g.Emit(OpCodes.Ldc_I8, (long)dst);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, result, args);
            g.Emit(OpCodes.Ret);
            return CellDelegate.define(id, dst, method, method.CreateDelegate(functype));
        }
    }
}