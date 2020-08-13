//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface ITool : ITooling, IDisposable
    {        
        FolderPath SourceDir {get;}

        FolderPath TargetDir {get;}
    }
    
    public interface ITool<T> : ITool
        where T : struct
    {
        
    }
    
    public interface ITool<T,F> : ITool<T>, IToolFlags<F>
        where T : struct, ITool<T,F>
        where F : unmanaged, Enum
    {
        IToolArchive<T,F> Target {get;}        

        ToolFlags<F> Flags {get;}
    }
}