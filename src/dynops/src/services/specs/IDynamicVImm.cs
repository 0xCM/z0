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

    using static Seed;

    using K = Kinds;

    public interface IDynamicVImm
    {
        /// <summary>
        /// Creates an immediate injector for unary operators with non-immediate operands of parametric width
        /// </summary>
        /// <typeparam name="W">The operand width</typeparam>
        IImmInjector VUnaryImmInjector<W>()
            where W : ITypeWidth;

        /// <summary>
        /// Creates an immediate injector for binary operators with non-immediate operands of parametric width
        /// </summary>
        /// <typeparam name="W">The operand width</typeparam>
        IImmInjector VBinaryImmInjector<W>()
            where W : ITypeWidth;         

        IImmInjector<UnaryOp<Vector128<T>>> V128UnaryOpImmInjector<T>()
            where T : unmanaged;                   

        IImmInjector<UnaryOp<Vector256<T>>> V256UnaryOpImmInjector<T>()            
            where T : unmanaged;            
        
        IImmInjector<BinaryOp<Vector128<T>>> V128BinaryOpImmInjector<T>()        
            where T : unmanaged;            

        IImmInjector<BinaryOp<Vector256<T>>> V256BinaryOpImmInjector<T>()
            where T : unmanaged;     

        /// <summary>
        /// Creates a 128-bit T-parametric unary immediate injector
        /// </summary>
        /// <param name="w">The vector operand width</param>
        /// <param name="k">The operator kind</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]            
        IImmInjector<UnaryOp<Vector128<T>>> Injector<T>(W128 w, K.UnaryOpClass k)
            where T : unmanaged                   
                => V128UnaryOpImmInjector<T>();


        /// <summary>
        /// Creates a 256-bit T-parametric unary immediate injector
        /// </summary>
        /// <param name="w">The vector operand width</param>
        /// <param name="k">The operator kind</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]            
        IImmInjector<UnaryOp<Vector256<T>>> Injector<T>(W256 w, K.UnaryOpClass k)
            where T : unmanaged                   
                => V256UnaryOpImmInjector<T>();

        /// <summary>
        /// Creates a 128-bit T-parametric binary immediate injector
        /// </summary>
        /// <param name="w">The vector operand width</param>
        /// <param name="k">The operator kind</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]            
        IImmInjector<BinaryOp<Vector128<T>>> Injector<T>(W128 w, K.BinaryOpClass k)
            where T : unmanaged                   
                => V128BinaryOpImmInjector<T>();

        /// <summary>
        /// Creates a 256-bit T-parametric binary immediate injector
        /// </summary>
        /// <param name="w">The vector operand width</param>
        /// <param name="k">The operator kind</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]            
        IImmInjector<BinaryOp<Vector256<T>>> Injector<T>(W256 w, K.BinaryOpClass k)
            where T : unmanaged                   
                => V256BinaryOpImmInjector<T>();

        /// <summary>
        /// Creates a 128-bit vectorized parametric unary operator that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]            
        DynamicDelegate<UnaryOp<Vector128<T>>> CreateImmV128UnaryOp<T>(MethodInfo src, byte imm)
            where T : unmanaged;

        /// <summary>
        /// Creates a parametric 128-bit vectorized binary operator that adapts a like-kinded operator that consumes an immediate value in the third argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        DynamicDelegate<BinaryOp<Vector128<T>>> CreateImmV128BinaryOp<T>(MethodInfo src, byte imm)
            where T : unmanaged;

        /// <summary>
        /// Creates a parametric 128-bit vectorized unary operator that adapts a like-kinded operator that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        DynamicDelegate<UnaryOp<Vector256<T>>> CreateImmV256UnaryOp<T>(MethodInfo src, byte imm)        
            where T : unmanaged;

        /// <summary>
        /// Creates a parametric 256-bit vectorized binary operator that adapts a like-kinded operator that consumes an immediate value in the third argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        DynamicDelegate<BinaryOp<Vector256<T>>> CreateV256BinaryOpImm<T>(MethodInfo src, byte imm)        
            where T : unmanaged;

        Option<DynamicDelegate> EmbedVUnaryOpImm(MethodInfo src, byte imm8, OpIdentity id);

        Option<DynamicDelegate> EmbedVUnaryOpImm(MethodInfo src, byte imm8);

        Option<DynamicDelegate> EmbedVBinaryOpImm(MethodInfo src, byte imm8, OpIdentity id);

        Option<DynamicDelegate> EmbedVBinaryOpImm(MethodInfo src, byte imm8);
    }   
}