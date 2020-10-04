//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

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
}