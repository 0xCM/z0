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
        /// A location - in memory, a register; potentially relative or absolute
        /// </summary>
        public interface location
        {

        }

        /// <summary>
        /// A target-parametric location
        /// </summary>
        public interface location<T> : location
        {

        }

        /// <summary>
        /// An absolute location
        /// </summary>
        public interface absolute : location
        {
            
        }

        /// <summary>
        /// A target-parametric absolute location
        /// </summary>
        public interface absolute<T> : absolute, location<T>
        {

        }
    }

    partial class AsmTypes
    {

    }
}