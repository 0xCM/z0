//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    
    public readonly partial struct AccessorCapture : IAccessorCapture
    {
        readonly IAsmContext Context;
        
        IAppContext IContextual<IAppContext>.Context 
            => Context.ContextRoot;

        IAccessorCapture This => this;

        FolderPath ResBytesDir
            => This.ResBytesDir;

        FilePath ResBytesCompiled
            => This.ResBytesCompiled;

        FolderPath ResBytesUncompiled
            => This.ResBytesUncompiled;

        [MethodImpl(Inline)]
        public AccessorCapture(IAsmContext context)
        {
            Context = context;            
            Context.AppPaths.AppDataRoot.Clear();
            ResBytesDir.Clear();
            ResBytesUncompiled.Clear();
        }                            
    }
}