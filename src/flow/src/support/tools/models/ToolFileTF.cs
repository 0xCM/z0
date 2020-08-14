//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
        
    public struct ToolFile<T,F> : IToolFile<T,F>
        where T : struct, ITool<T>
        where F : unmanaged, Enum
    {
        public FilePath EmissionPath {get;}
        
        public F Kind {get;}
        
        [MethodImpl(Inline)]
        public ToolFile(F kind, FilePath path)
        {
            Kind = kind;
            EmissionPath = Files.normalize(path);
        }

        [MethodImpl(Inline)]
        public ToolFile(FilePath path)
        {
            Kind = default;
            EmissionPath = Files.normalize(path);
        }
    }   
}
