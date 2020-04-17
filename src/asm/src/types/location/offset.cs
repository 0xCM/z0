//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    partial class AsmSpecs
    {
        /// <summary>
        /// A displacement
        /// </summary>
        public interface offset
        {
            
        }

        /// <summary>
        /// A displacement specified with W bits of information
        /// </summary>
        public interface offset<W> : offset
            where W : unmanaged, ITypeWidth
        {
            
        }

        /// <summary>
        /// An 8-bit displacement
        /// </summary>
        public interface offset8 : offset<W8>
        {

        }

        /// <summary>
        /// A 16-bit displacement
        /// </summary>
        public interface offset16 : offset<W16>
        {
            
        }

        /// <summary>
        /// A 32-bit displacement
        /// </summary>
        public interface offset32 : offset<W32>
        {
            
        }

        /// <summary>
        /// A 64-bit displacement
        /// </summary>
        public interface offset64 : offset<W64>
        {
            
        }

        public interface ishort
        {
            
        }    

        public interface near
        {
            
        }

        public interface near<W>
            where W : unmanaged, ITypeWidth
        {
            
        }

        public interface far
        {
            
        }

    }
}