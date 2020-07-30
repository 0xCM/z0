//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    public readonly struct HandleInfo
    {
        public static HandleInfo Empty => new HandleInfo(0, 0);
        
        public HandleInfo(int token, TableIndex src)
        {
            Token = token;
            Source = src;
        }
        
        public readonly int Token;

        public readonly TableIndex Source;
    }
}