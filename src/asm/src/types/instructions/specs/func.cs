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
        public interface func : op
        {

        }

        /// <summary>
        /// A function suupported in 32-bit mode
        /// </summary>    
        public interface func32 : func, op32
        {

        }

        /// <summary>
        /// A function suupported in 64-bit mode
        /// </summary>    
        public interface func64 : func, op64
        {

        }

        /// <summary>
        /// A function suupported in 32 and 64-bit modes
        /// </summary>    
        public interface func32x64 : func32, func64, op32x64
        {

        }

        public interface func<F> : func
            where F : struct, func<F>
        {

        }

        public interface func32<F> : func<F>, func32
            where F : struct, func32<F>
        {

        }

        public interface func64<F> : func<F>, func64
            where F : struct, func64<F>
        {

        }

        public interface func32x64<F> : func<F>, func32x64
            where F : struct, func32x64<F>
        {

        }
    }
}