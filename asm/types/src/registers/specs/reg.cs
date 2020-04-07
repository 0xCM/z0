//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmSpecs
    {
        /// <summary>
        /// Characterizes a register
        /// </summary>
        public interface reg : data
        {
            /// <summary>
            /// The register's kind classifier
            /// </summary>
            RegisterKind Kind {get;}
        }

        /// <summary>
        /// Characerizes a register of parametric width
        /// </summary>
        /// <typeparam name="W">The register width</typeparam>
        public interface reg<W> : reg, data<W>
            where W : unmanaged, IDataWidth
        {
            /// <summary>
            /// The register kind with blended width facet
            /// </summary>
            RegisterKind reg.Kind => (RegisterKind)Widths.data<W>();            
        }

        /// <summary>
        /// Characterizes a width-parametric register reification
        /// </summary>
        /// <typeparam name="F">The reifying type</typeparam>
        /// <typeparam name="W">The register width</typeparam>
        public interface reg<W,S> : reg<W>, data<W,S>
            where W : unmanaged, IDataWidth
            where S : unmanaged
        {

        }

        /// <summary>
        /// Characterizes a width-parametric and state-parametric register reification
        /// </summary>
        /// <typeparam name="F">The reifying type</typeparam>
        /// <typeparam name="W">The register width</typeparam>
        public interface reg<F,W,S> : reg<W,S>
            where F : struct, reg<F,W,S>
            where W : unmanaged, IDataWidth
            where S : unmanaged
        {

        }

        /// <summary>
        /// Characterizes a register reification parametric in index, width and state
        /// </summary>
        /// <typeparam name="F">The reifying type</typeparam>
        /// <typeparam name="W">The register width</typeparam>
        public interface reg<F,N,W,S> : reg<F,W,S>, IIndexed<N>
            where F : struct, reg<F,N,W,S>
            where W : unmanaged, IDataWidth
            where S : unmanaged
            where N : unmanaged, ITypeNat
        {

        }
    }
}