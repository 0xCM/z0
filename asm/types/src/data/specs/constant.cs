//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    using static AsmSpecs;
    using static AsmTypes;

    partial class AsmSpecs
    {
        /// <summary>
        /// Characterizes invariant data
        /// </summary>
        public interface constant
        {

        }

        /// <summary>
        /// Characterizes invariant data of known width, parametric in representation type
        /// </summary>
        /// <typeparam name="T">The data representation type</typeparam>
        public interface constant<T> : constant
            where T : unmanaged
        {
            /// <summary>
            /// The constant value
            /// </summary>
            T Literal {get;}
            

            DataWidth Width => (DataWidth)Widths.measure<T>();

        }

        /// <summary>
        /// Characterizes invariant data, parametric in both width and representation type
        /// </summary>
        /// <typeparam name="W">The data width</typeparam>
        /// <typeparam name="T">The data representation type type</typeparam>
        public interface constant<W,T> : constant<T>
            where W : unmanaged, IDataWidth
            where T : unmanaged
        {        
        }

        /// <summary>
        /// Characterizes an F-bound polymorphic representation of invariant data, parametric in both width and representation type
        /// </summary>
        /// <typeparam name="W">The data width</typeparam>
        /// <typeparam name="T">The data representation type type</typeparam>
        public interface constant<F,W,T> : constant<W,T>
            where W : unmanaged, IDataWidth
            where T : unmanaged
        {        


        }
    }
}