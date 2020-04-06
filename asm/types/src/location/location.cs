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

    }

    partial class AsmTypes
    {

    }
}