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
        /// An aspect applied to those things that can exhibit a meaningful answer to the question "How many are your bits?"
        /// </summary>
        public interface sized
        {
            /// <summary>
            /// The size measure, specified in bits
            /// </summary>
            uint Size {get;}
        }

    }

    partial class AsmTypes
    {

    }
}