//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    partial struct Part
    {
        [Op]
        public static string format(PartId src)
        {
            var baseId = @base(src);
            var dst = baseId.ToString().ToLower();
                        
            if(isTest(src))
                return dst + TestSuffix;
            else if(isSvc(src))
                return dst + SvcSuffix;
            else
                return dst + BaseSuffix;
        }

        [MethodImpl(Inline), Op]
        public static string format(ExternId id)
            => id.ToString().ToLower();        

        const string TestSuffix = ".test";
        
        const string SvcSuffix = ".svc";
        
        const string BaseSuffix = "";
    }
}