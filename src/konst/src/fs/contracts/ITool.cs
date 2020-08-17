//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    using static FS;

    partial struct FS
    {
        public interface ITool : IExeFile
        {

        }
        
        public interface ITool<T> : ITool, IExeFile<T>
            where T : struct, ITool<T>
        {

        }    
    }
}