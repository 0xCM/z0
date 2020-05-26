//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;   
    using static RecordFields;

    public interface IRecordFields
    {
        F[] Literals<F>()
            where F : unmanaged, Enum;            

        string[] Labels<F>()
            where F : unmanaged, Enum;                    

        short Width<F>(F f)
            where F : unmanaged, Enum;            

        short Index<F>(F f)
            where F : unmanaged, Enum;

        bit Enabled<F>(F f)
            where F : unmanaged, Enum;            
    }

    public interface IRecordFields<F>
        where F : unmanaged,Enum
    {
        F[] Literals {get;}

        string[] Labels {get;}

        short Width(F f);

        short Index(F f);

        bit Enabled(F f);

    }
}