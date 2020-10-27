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
    using static z;
    using static ClrArtifacts;

    /// <summary>
    /// Defines the primary interface for clr artifact interrogation
    /// </summary>
    [ApiHost("reflex.views")]
    public readonly partial struct ClrViews
    {
        [MethodImpl(Inline), Op]
        public static ModuleView vManifest(Assembly src)
            => view(src.ManifestModule);

        /// <summary>
        /// Defines a <see cref='ModuleView'/> over the source
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        public static ModuleView view(Module src)
            => src;

        /// <summary>
        /// Defines a <see cref='MethodView'/> over the source
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        public static MethodView view(MethodInfo src)
            => src;

        /// <summary>
        /// Defines a <see cref='FieldView'/> over the source
        /// </summary>
        /// <param name="src">The source module</param>
        [MethodImpl(Inline), Op]
        public static FieldView view(FieldInfo src)
            => src;

        /// <summary>
        /// Defines a <see cref='ValueParamView'/> over the source
        /// </summary>
        /// <param name="src">The source module</param>

        [MethodImpl(Inline), Op]
        public static ValueParamView view(ParameterInfo src)
            => src;
    }
}
