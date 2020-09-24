//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public class ApiSurfacePartAttribute : Attribute
    {
        public ushort SurfaceKey {get;}

        public string SurfaceName {get;}

        public ApiSurfacePartAttribute(string name)
        {
            SurfaceName = name;
            SurfaceKey = 0;
        }

        public ApiSurfacePartAttribute(string name, ushort key)
        {
            SurfaceName = name;
            SurfaceKey = key;
        }

        public ApiSurfacePartAttribute(ushort key)
        {
            SurfaceName = EmptyString;
            SurfaceKey = key;
        }
    }
}