//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;

    partial struct Flow    
    {
        /// <summary>
        /// Defines an actor with a specified name, if given; otherwise the actor name is derived 
        /// from the path of the invoking member file
        /// </summary>
        /// <param name="name">The actor name</param>
        [MethodImpl(Inline), Op]
        public static WfWorker worker([CallerFilePath] string name = null)
            => new WfWorker(Path.GetFileNameWithoutExtension(name));
    }
}