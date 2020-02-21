//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static zfunc;
    using static nfunc;

    partial class DataBlocks
    {

        /// <summary>
        /// Fills a target block with replicated cell data
        /// </summary>
        /// <param name="data">The data used to fill the block</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>        
        [MethodImpl(Inline),Op, NumericClosures(NumericKind.Width8 | NumericKind.Width16)]
        public static void broadcast<T>(T data, in Block16<T> dst)
            where T : unmanaged        
                => dst.data.Fill(data);

        /// <summary>
        /// Fills a target block with replicated cell data
        /// </summary>
        /// <param name="data">The data used to fill the block</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>        
        [MethodImpl(Inline),Op, NumericClosures(NumericKind.Width8 | NumericKind.Width16 | NumericKind.Width32)]
        public static void broadcast<T>(T data, in Block32<T> dst)
            where T : unmanaged        
                => dst.data.Fill(data);
        
        /// <summary>
        /// Fills a target block with replicated cell data
        /// </summary>
        /// <param name="data">The data used to fill the block</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>        
        [MethodImpl(Inline),Op, NumericClosures(NumericKind.All)]
        public static void broadcast<T>(T data, in Block64<T> dst)
            where T : unmanaged        
                => dst.data.Fill(data);

        /// <summary>
        /// Fills a target block with replicated cell data
        /// </summary>
        /// <param name="data">The data used to fill the block</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>        
        [MethodImpl(Inline),Op, NumericClosures(NumericKind.All)]
        public static void broadcast<T>(T data, in Block128<T> dst)
            where T : unmanaged        
                => dst.data.Fill(data);

        /// <summary>
        /// Fills a target block with replicated cell data
        /// </summary>
        /// <param name="data">The data used to fill the block</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>        
        [MethodImpl(Inline),Op, NumericClosures(NumericKind.All)]
        public static void broadcast<T>(T data, in Block256<T> dst)
            where T : unmanaged        
                => dst.data.Fill(data); 

        /// <summary>
        /// Fills a target block with replicated cell data
        /// </summary>
        /// <param name="data">The data used to fill the block</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>        
        [MethodImpl(Inline),Op, NumericClosures(NumericKind.All)]
        public static void broadcast<T>(T data, in Block512<T> dst)
            where T : unmanaged        
                => dst.data.Fill(data); 
    }
}