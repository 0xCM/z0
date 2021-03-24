//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct ImageMaps
    {
        /// <summary>
        /// Creates a <see cref='ImageMap'/> for the current process
        /// </summary>
        [Op]
        public static ImageMap current()
            => define(sys.CurrentProcess);
    }
}