//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    unsafe partial struct Buffers
    {
        /// <summary>
        /// Allocates a buffer sequence over segments of fixed type
        /// </summary>
        /// <param name="count">The number of buffers in the sequence</param>
        /// <typeparam name="F">The buffer segment type</typeparam>
        [Op]
        public static NativeCells<F> ncells<F>(byte count)
            where F : unmanaged
        {
            var cellSize = core.size<F>();
            var totalSize = count*(cellSize);
            var allocated = native(totalSize);
            return new NativeCells<F>(allocated, count, cellSize, totalSize);
        }
    }
}