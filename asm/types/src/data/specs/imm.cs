//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmSpecs
    {
        /// <summary>
        /// Characterizes an immediate value
        /// </summary>
        public interface imm : constant
        {

            
        }

        public interface imm<W> : imm
            where W : unmanaged, IDataWidth
        {
             ImmWidth Width  => (ImmWidth)Widths.data<W>();    

        }   

        public interface imm<F,W> : imm<W>
            where F : struct, imm<F,W>
            where W : unmanaged, IDataWidth
        {

        }

        /// <summary>
        /// Characterizes an F-bound polymorphic immediate representation, parametric in both width and data type
        /// </summary>
        /// <typeparam name="F">The reification type</typeparam>
        /// <typeparam name="W">The width</typeparam>
        /// <typeparam name="T">The scalar type used to represent the immediate value</typeparam>
        public interface imm<F,W,T> : imm<F,W>, constant<F,W,T>
            where F : struct, imm<F,W,T>
            where W : unmanaged, IDataWidth
            where T : unmanaged
        {
                        
            
        }
    }
}