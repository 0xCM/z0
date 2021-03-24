//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using Z0;

public class ApiPartAttribute : Attribute
{
    public ulong Data {get;}


    public ApiPartAttribute(ulong data)
    {
        Data = data;
    }

    public ApiPartAttribute()
    {

    }
}
