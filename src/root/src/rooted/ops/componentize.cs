//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    partial struct Root
    {
        [Op]
        public static string[] componentize(PartId src)
        {
            var components = new List<string>();
            var current = EmptyString;
            var literal = @base(src).ToString();
            var length = literal.Length;
            for(var i=0; i<length; i++)
            {
                var c = literal[i];
                if(i == 0)
                    current += c.ToLower();
                else
                {
                    if(c.IsLower())
                        current += c;
                    else
                    {
                        if(current.IsNotBlank())
                        {
                            components.Add(current);
                            current = EmptyString;
                            current += c.ToLower();
                        }
                    }
                }
            }

            if(current.IsNotBlank())
                components.Add(current);

            if(isTest(src))
                components.Add("test");

            return components.ToArray();
        }
    }
}