//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class ApiTypeAttribute : ApiPartAttribute
    {
        public ApiTypeId Id{get;}

        public ApiTypeAttribute(ApiTypeId data)
            : base((ulong)data)
        {
            Id = data;
        }

        public ApiTypeAttribute()
        {

        }
    }
}