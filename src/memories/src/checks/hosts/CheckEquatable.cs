//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct CheckEquatable : TCheckEquatable
    {                    
        public static TCheckEquatable Checker => default(CheckEquatable);        
    }

}