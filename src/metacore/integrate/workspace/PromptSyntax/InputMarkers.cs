//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using D = InputMarkerDefaults;

    public readonly struct InputMarkers
    {
        public static InputMarkers Default 
        {
            [MethodImpl(Inline)]
            get => new InputMarkers(D.ParamMarker, D.ArgMarker, D.ArgQualifier);
        }
    
        [MethodImpl(Inline)]
        public InputMarkers(string param, string arg, string qualifier)
        {
            ParamMarker = param;
            ArgMarker = arg;            
            ArgQualifier = qualifier;
        }
        
        /// <summary>
        /// Expression which signals that a parameter begins immediately thereafter
        /// </summary>
        public readonly StringRef ParamMarker;

        /// <summary>
        /// Expression that terminates parameter designation and immediatly precedes
        /// argument specification
        /// </summary>
        public readonly StringRef ArgMarker;

        /// <summary>
        /// Expression that bounds argument value content when needed
        /// </summary>
        public readonly StringRef ArgQualifier;
    }
}