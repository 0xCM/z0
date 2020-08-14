//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
        
    public struct ToolFile<T> : IToolFile<T>
        where T : struct, ITool<T>
    {
        public FilePath EmissionPath {get;}
                
        [MethodImpl(Inline)]
        public ToolFile(FilePath path)
        {
            EmissionPath = Files.normalize(path);
        }
    }   
}