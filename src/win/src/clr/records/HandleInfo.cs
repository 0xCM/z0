//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    [Table]
    public readonly struct HandleInfo
    {
        public readonly int Token;

        public readonly TableIndex Source;
                
        public HandleInfo(int token, TableIndex src)
        {
            Token = token;
            Source = src;
        }
        
        public static HandleInfo Empty => new HandleInfo(0, 0);
    }
}