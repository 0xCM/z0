//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    partial class ApiQuery
    {
        [Op]
        public static bool part(Assembly src, out IPart dst)
        {
            var attempt = src.GetTypes().Where(t => t.Reifies<IPart>() && !t.IsAbstract).Map(t => (IPart)Activator.CreateInstance(t)).ToArray();
            if(attempt.Length != 0)
            {
                dst = attempt.First();
                return true;
            }
            else
            {
                 dst = default;
                 return false;
            }
        }

        [Op]
        public static Option<IPart> part(Assembly src)
        {
            if(part(src, out var dst))
                return Option.some(dst);
            else
                return Option.none<IPart>();
        }
    }
}