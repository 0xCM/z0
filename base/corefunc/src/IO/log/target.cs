//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    /// <summary>
    /// Defines a classifier relative to a predefined application area
    /// </summary>
    public readonly struct LogTarget : ILogTarget
    {
        public static LogTarget Define(LogArea area, string name = null)
            => new LogTarget(area, name ?? area.ToString().ToLower());

        public LogTarget(LogArea Area, string Name)
        {
            this.Area = Area;
            this.Name = Name;
        }

        public readonly LogArea Area {get;}

        
        /// <summary>
        /// The classifier name
        /// </summary>
        public readonly string Name {get;}
        
        public override string ToString()
            => $"{Area}/{Name}";
    }
}