//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public interface IPartFileIndex
    {
        FilePath[] ExtractFiles {get;}

        FilePath[] ParseFiles {get;}

        FilePath[] AsmFiles {get;}

        FilePath[] HexFiles {get;}
    }
}